using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace mabalot_try
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Enter your username and password.", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool matched = false;
            string fullName = "";
            string role = "";
            bool isActive = false;

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = "SELECT PasswordHash, FullName, UserRole, IsActive FROM Users WHERE Username = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read() && PasswordHelper.VerifyPassword(password, reader["PasswordHash"].ToString()))
                            {
                                matched = true;
                                fullName = reader["FullName"].ToString();
                                role = reader["UserRole"].ToString();
                                isActive = Convert.ToBoolean(reader["IsActive"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The login did not finish." + Environment.NewLine + Environment.NewLine + ex.Message, "Log in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // One message for an unknown username and a wrong password, so the form does not reveal which usernames exist.
            if (!matched)
            {
                MessageBox.Show("No account matches that username and password.", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isActive)
            {
                MessageBox.Show("This account is turned off. Ask the administrator to turn it back on.", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Welcome, {fullName}.", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Information);

            JABIBI_FOODS_DASHBOARD dashboard = new JABIBI_FOODS_DASHBOARD(fullName, role, username);
            dashboard.FormClosed += Dashboard_FormClosed;
            txtPassword.Clear();
            this.Hide();
            dashboard.Show();
        }

        // Log out brings this form back; closing the dashboard any other way ends the app,
        // instead of leaving this hidden form running.
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (((JABIBI_FOODS_DASHBOARD)sender).LoggedOut)
            {
                this.Show();
                txtPassword.Focus();
            }
            else
            {
                this.Close();
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (RegisterForm register = new RegisterForm())
            {
                register.StartPosition = FormStartPosition.Manual;
                register.Location = this.Location;

                this.Hide();
                DialogResult result = register.ShowDialog();
                this.Show();

                if (result == DialogResult.OK)
                {
                    txtUsername.Text = register.RegisteredUsername;
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
        }
    }
}
