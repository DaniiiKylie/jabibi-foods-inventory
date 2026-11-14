using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace mabalot_try
{
    // Users: adds, lists, changes and deletes rows of the Users table, with the four account
    // counts above the list. Passwords go through PasswordHelper, the same as the register form,
    // so an account added here logs in on the sign in form, and the list never shows the hash.
    public partial class UsersForm : Form, ISidebarPage
    {
        private const int MinPasswordLength = 8;

        // The UserID of the row chosen in the list; 0 while none is chosen.
        private int selectedUserID = 0;

        // The username the chosen row has in the database. Delete names this one, not the text
        // box, which may hold an edit that was never saved.
        private string selectedUsername = "";

        // The account that is logged in, so it cannot be turned off or deleted from under itself.
        private int currentUserID = 0;

        public string NextPage { get; private set; }

        public UsersForm() : this("", "", "")
        {
        }

        public UsersForm(string fullName, string role, string username)
        {
            InitializeComponent();

            lblAccountName.Text = JABIBI_FOODS_DASHBOARD.FitToWidth(fullName, lblAccountName.Font, lblAccountName.Width);
            lblAccountRole.Text = role;

            if (lblAccountName.Text != fullName)
            {
                if (components == null) components = new Container();
                new ToolTip(components).SetToolTip(lblAccountName, fullName);
            }

            ItemsForm.StyleGrid(dgvUsers);

            // The sidebar's Log out would otherwise take first focus, and Enter would press it.
            this.ActiveControl = txtFullName;

            currentUserID = FindUserID(username);

            LoadUsers();
            LoadStats();
        }

        // The grid picks its first row when the window first shows, after LoadUsers has cleared
        // the selection, so a row would look chosen while selectedUserID is still 0.
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            dgvUsers.ClearSelection();
            dgvUsers.CurrentCell = null;
        }

        // ---------- Read ----------

        private void LoadUsers()
        {
            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string search = txtSearch.Text.Trim();

                    // PasswordHash stays out of the SELECT, so it never reaches the screen.
                    string query = "SELECT UserID, FullName, Username, UserRole, IsActive FROM Users";

                    if (search != "")
                        query += " WHERE Username LIKE ? OR FullName LIKE ? OR UserRole LIKE ?";

                    // Newest first, so an account just added is the top row.
                    query += " ORDER BY UserID DESC";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        if (search != "")
                        {
                            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = LikePattern(search);
                            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = LikePattern(search);
                            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = LikePattern(search);
                        }

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dgvUsers.DataSource = table;

                            // An empty grid says why it is empty instead of showing a blank box.
                            lblEmptyList.Text = search == ""
                                ? "No accounts yet. Fill in the fields above and choose Add user."
                                : "No account matches that search.";
                            lblEmptyList.Visible = table.Rows.Count == 0;
                        }
                    }
                }

                FormatColumns();
                dgvUsers.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The user list did not load." + Environment.NewLine + Environment.NewLine + ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // The four counts in one pass over Users. Active and turned off add up to the total.
        private void LoadStats()
        {
            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = "SELECT COUNT(*) AS TotalUsers, " +
                        "SUM(IIF(IsActive, 1, 0)) AS ActiveUsers, " +
                        "SUM(IIF(IsActive, 0, 1)) AS TurnedOffUsers, " +
                        "SUM(IIF(UserRole = 'Admin', 1, 0)) AS Admins " +
                        "FROM Users";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTotalCount.Text = CountText(reader["TotalUsers"]);
                            lblActiveCount.Text = CountText(reader["ActiveUsers"]);
                            lblTurnedOffCount.Text = CountText(reader["TurnedOffUsers"]);
                            lblAdminsCount.Text = CountText(reader["Admins"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The account counts did not load." + Environment.NewLine + Environment.NewLine + ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SUM over an empty table is NULL, not 0.
        private static string CountText(object value)
        {
            return value == DBNull.Value ? "0" : Convert.ToInt32(value).ToString("N0");
        }

        // LIKE treats %, _ and [ as wildcards; brackets make them plain characters.
        private static string LikePattern(string text)
        {
            string escaped = text.Replace("[", "[[]").Replace("%", "[%]").Replace("_", "[_]");
            return "%" + escaped + "%";
        }

        private void FormatColumns()
        {
            if (dgvUsers.Columns.Count == 0)
                return;

            dgvUsers.Columns["UserID"].HeaderText = "ID";
            dgvUsers.Columns["FullName"].HeaderText = "Full name";
            dgvUsers.Columns["UserRole"].HeaderText = "Role";
            dgvUsers.Columns["IsActive"].HeaderText = "Active";

            foreach (DataGridViewColumn column in dgvUsers.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvUsers.Columns["UserID"].FillWeight = 40;
            dgvUsers.Columns["FullName"].FillWeight = 220;
            dgvUsers.Columns["Username"].FillWeight = 140;
            dgvUsers.Columns["UserRole"].FillWeight = 80;
            dgvUsers.Columns["IsActive"].FillWeight = 60;

            dgvUsers.Columns["UserID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvUsers.Columns["UserID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvUsers.Columns["IsActive"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private static int FindUserID(string username)
        {
            if (string.IsNullOrEmpty(username))
                return 0;

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    using (OleDbCommand cmd = new OleDbCommand("SELECT UserID FROM Users WHERE Username = ?", con))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = username;
                        object id = cmd.ExecuteScalar();
                        return id == null || id == DBNull.Value ? 0 : Convert.ToInt32(id);
                    }
                }
            }
            catch (OleDbException)
            {
                // The list load right after this reports the database problem in its own message.
                return 0;
            }
        }

        // ---------- Create ----------

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateUser(true))
                return;

            string username = txtUsername.Text.Trim();

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    if (UsernameTaken(con, username, 0))
                    {
                        MessageBox.Show("That username is taken. Choose another one.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                        return;
                    }

                    string query = "INSERT INTO Users (Username, PasswordHash, FullName, UserRole, IsActive) VALUES (?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = username;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = PasswordHelper.HashPassword(txtPassword.Text);
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtFullName.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = cmbRole.Text;
                        cmd.Parameters.Add("?", OleDbType.Boolean).Value = chkActive.Checked;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"{username} is added. The account can log in {(chkActive.Checked ? "now" : "once it is turned on")}.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadUsers();
                LoadStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The account was not added." + Environment.NewLine + Environment.NewLine + ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- Update ----------

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserID == 0)
            {
                MessageBox.Show("Choose an account in the list first.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // A blank pair of password boxes keeps the password the account has now.
            bool newPassword = txtPassword.Text != "" || txtConfirmPassword.Text != "";

            if (!ValidateUser(newPassword))
                return;

            if (selectedUserID == currentUserID && !chkActive.Checked)
            {
                MessageBox.Show("You are logged in as this account, so it stays active. Log in as another account to turn it off.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkActive.Checked = true;
                return;
            }

            string username = txtUsername.Text.Trim();

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    if (UsernameTaken(con, username, selectedUserID))
                    {
                        MessageBox.Show("That username is taken. Choose another one.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                        return;
                    }

                    string query = newPassword
                        ? "UPDATE Users SET Username = ?, FullName = ?, UserRole = ?, IsActive = ?, PasswordHash = ? WHERE UserID = ?"
                        : "UPDATE Users SET Username = ?, FullName = ?, UserRole = ?, IsActive = ? WHERE UserID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        // Positional parameters: added in the same order as the ? marks above.
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = username;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtFullName.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = cmbRole.Text;
                        cmd.Parameters.Add("?", OleDbType.Boolean).Value = chkActive.Checked;

                        if (newPassword)
                            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = PasswordHelper.HashPassword(txtPassword.Text);

                        cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedUserID;

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("That account is no longer on the list. Refresh the list and choose again.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ClearFields();
                            LoadUsers();
                            LoadStats();
                            return;
                        }
                    }
                }

                string passwordNote = newPassword ? " The new password works the next time the account logs in." : "";
                MessageBox.Show($"{username} is updated.{passwordNote}", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadUsers();
                LoadStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The account was not updated." + Environment.NewLine + Environment.NewLine + ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- Delete ----------

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserID == 0)
            {
                MessageBox.Show("Choose an account in the list first.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedUserID == currentUserID)
            {
                MessageBox.Show("You are logged in as this account. Log in as another account to delete it.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = selectedUsername;

            // No is the default button, so pressing Enter by habit keeps the account.
            DialogResult result = MessageBox.Show($"Delete the account {username}? It can no longer log in, and its row is removed from the database.", "Delete account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = "DELETE FROM Users WHERE UserID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedUserID;
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"{username} is deleted.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadUsers();
                LoadStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The account was not deleted." + Environment.NewLine + Environment.NewLine + ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- Helpers ----------

        // Checks every field before a save and points at the first one that needs fixing.
        // checkPassword is false only for an update that keeps the current password.
        private bool ValidateUser(bool checkPassword)
        {
            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("Enter the full name.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Enter the username.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (cmbRole.SelectedIndex < 0)
            {
                MessageBox.Show("Choose a role.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
                return false;
            }

            if (!checkPassword)
                return true;

            if (txtPassword.Text.Length < MinPasswordLength)
            {
                MessageBox.Show("Use at least 8 characters for the password.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("The two passwords do not match.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            return true;
        }

        // Access compares text without regard to letter case, so "Danah" matches "danah",
        // the same rule the sign in form uses to find an account.
        private static bool UsernameTaken(OleDbConnection con, string username, int exceptUserID)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = ? AND UserID <> ?";

            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = username;
                cmd.Parameters.Add("?", OleDbType.Integer).Value = exceptUserID;
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            txtUsername.Clear();
            cmbRole.SelectedIndex = -1;
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            chkActive.Checked = true;

            selectedUserID = 0;
            selectedUsername = "";
            dgvUsers.ClearSelection();
            txtFullName.Focus();
        }

        // Clicking a row fills the fields with that account, ready for Update or Delete.
        // The password boxes stay blank: the stored hash cannot be turned back into a password.
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // -1 is the header row.
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

            selectedUserID = Convert.ToInt32(row.Cells["UserID"].Value);
            selectedUsername = row.Cells["Username"].Value.ToString();

            txtFullName.Text = row.Cells["FullName"].Value.ToString();
            txtUsername.Text = selectedUsername;
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            chkActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);

            // A role outside the list (typed into the database by hand) is added back, so the row shows what it holds.
            string role = row.Cells["UserRole"].Value.ToString();
            if (role != "" && !cmbRole.Items.Contains(role))
                cmbRole.Items.Add(role);
            cmbRole.SelectedItem = role == "" ? null : role;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
            LoadStats();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }

        // ---------- Sidebar ----------

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            NextPage = null;
            this.Close();
        }

        private void lblItems_Click(object sender, EventArgs e)
        {
            NextPage = "Items";
            this.Close();
        }

        // The same question as the dashboard's Log out; the dashboard does the logging out when
        // this page closes with "LogOut".
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Log out of Jabibi Inventory?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                NextPage = "LogOut";
                this.Close();
            }
        }
    }
}
