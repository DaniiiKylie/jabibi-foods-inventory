using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace mabalot_try
{
    // Items: adds, lists, changes and deletes rows of the Products table, with the four stock
    // counts above the list. Follows the final term CRUD lesson: every value goes into the query
    // as a ? parameter, in the same order as the columns, so a quote in a name cannot break the SQL.
    public partial class ItemsForm : Form, ISidebarPage
    {
        // The ProductID of the row chosen in the list; 0 while none is chosen.
        private int selectedProductID = 0;

        // The name the chosen row has in the database. Delete names this one, not the text box,
        // which may hold an edit that was never saved.
        private string selectedProductName = "";

        public string NextPage { get; private set; }

        // Low stock and Out of stock in the Status column, the rows someone has to act on.
        private Font statusFont;

        public ItemsForm() : this("", "")
        {
        }

        public ItemsForm(string fullName, string role)
        {
            InitializeComponent();

            lblAccountName.Text = JABIBI_FOODS_DASHBOARD.FitToWidth(fullName, lblAccountName.Font, lblAccountName.Width);
            lblAccountRole.Text = role;

            if (lblAccountName.Text != fullName)
            {
                if (components == null) components = new Container();
                new ToolTip(components).SetToolTip(lblAccountName, fullName);
            }

            StyleGrid(dgvProducts);
            statusFont = new Font(dgvProducts.Font, FontStyle.Bold);
            dgvProducts.CellFormatting += dgvProducts_CellFormatting;

            // The sidebar's Log out would otherwise take first focus, and Enter would press it.
            this.ActiveControl = txtProductName;

            LoadProducts();
            LoadStats();
        }

        // Headers in the app's colors, shared with the Users page. Windows' own header style turns
        // the clicked column's header blue, and a sortable column keeps room for a sort arrow that
        // pushes a right-aligned header away from its numbers; FormatColumns turns sorting off.
        internal static void StyleGrid(DataGridView grid)
        {
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.MistyRose;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.MistyRose;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 192, 192);
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        // The grid picks its first row when the window first shows, after LoadProducts has cleared
        // the selection, so a row would look chosen while selectedProductID is still 0.
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            dgvProducts.ClearSelection();
            dgvProducts.CurrentCell = null;
        }

        // ---------- Read ----------

        private void LoadProducts()
        {
            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string search = txtSearch.Text.Trim();
                    // Status uses the same rules as the four counts, so a row says why it is counted
                    // where it is.
                    string query = "SELECT ProductID, ProductName, Category, Description, UnitPrice, Quantity, ReorderLevel, " +
                        "IIF(Quantity = 0, 'Out of stock', IIF(Quantity <= ReorderLevel, 'Low stock', 'In stock')) AS Status, " +
                        "CreatedAt FROM Products";

                    if (search != "")
                        query += " WHERE ProductName LIKE ? OR Category LIKE ?";

                    // Newest first, so a product just added is the top row.
                    query += " ORDER BY ProductID DESC";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        if (search != "")
                        {
                            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = LikePattern(search);
                            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = LikePattern(search);
                        }

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dgvProducts.DataSource = table;

                            // An empty grid says why it is empty instead of showing a blank box.
                            lblEmptyList.Text = search == ""
                                ? "No products yet. Fill in the fields above and choose Add product."
                                : "No product matches that search.";
                            lblEmptyList.Visible = table.Rows.Count == 0;
                        }
                    }
                }

                FormatColumns();
                dgvProducts.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The product list did not load." + Environment.NewLine + Environment.NewLine + ex.Message, "Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // The four counts in one pass over Products. Every product lands in exactly one of the
        // last three: above its reorder level, at or under it with some left, or at 0.
        private void LoadStats()
        {
            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = "SELECT COUNT(*) AS TotalProducts, " +
                        "SUM(IIF(Quantity > ReorderLevel, 1, 0)) AS InStock, " +
                        "SUM(IIF(Quantity > 0 AND Quantity <= ReorderLevel, 1, 0)) AS LowStock, " +
                        "SUM(IIF(Quantity = 0, 1, 0)) AS OutOfStock " +
                        "FROM Products";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTotalCount.Text = CountText(reader["TotalProducts"]);
                            lblInStockCount.Text = CountText(reader["InStock"]);
                            lblLowStockCount.Text = CountText(reader["LowStock"]);
                            lblOutOfStockCount.Text = CountText(reader["OutOfStock"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The stock counts did not load." + Environment.NewLine + Environment.NewLine + ex.Message, "Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SUM over an empty table is NULL, not 0.
        private static string CountText(object value)
        {
            return value == DBNull.Value ? "0" : Convert.ToInt32(value).ToString("N0");
        }

        // LIKE treats %, _ and [ as wildcards; brackets make them plain characters, so a search
        // for "50%" finds "50%" instead of everything that starts with 50.
        private static string LikePattern(string text)
        {
            string escaped = text.Replace("[", "[[]").Replace("%", "[%]").Replace("_", "[_]");
            return "%" + escaped + "%";
        }

        private void FormatColumns()
        {
            if (dgvProducts.Columns.Count == 0)
                return;

            dgvProducts.Columns["ProductID"].HeaderText = "ID";
            dgvProducts.Columns["ProductName"].HeaderText = "Product name";
            dgvProducts.Columns["UnitPrice"].HeaderText = "Unit price";
            dgvProducts.Columns["ReorderLevel"].HeaderText = "Reorder level";
            dgvProducts.Columns["CreatedAt"].HeaderText = "Added";

            // The description stays in the table behind the grid, so choosing a row still fills the
            // Description box, but the list leaves it out: eight columns cut every name short.
            dgvProducts.Columns["Description"].Visible = false;

            foreach (DataGridViewColumn column in dgvProducts.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            // Weights in pixels of the list as it shows on screen (about 705 wide inside the scroll
            // bar), each sized to its longest word or header. The list never changes width, so the
            // name keeps its 172, enough for "Lola Nena's banana ketchup, 4 L". No MinimumWidth:
            // set while the page is still hidden, it threw a NullReferenceException inside the grid
            // and the rest of this method never ran.
            dgvProducts.Columns["ProductID"].FillWeight = 26;
            dgvProducts.Columns["ProductName"].FillWeight = 172;
            dgvProducts.Columns["Category"].FillWeight = 126;
            dgvProducts.Columns["UnitPrice"].FillWeight = 70;
            dgvProducts.Columns["Quantity"].FillWeight = 62;
            dgvProducts.Columns["ReorderLevel"].FillWeight = 92;
            dgvProducts.Columns["Status"].FillWeight = 80;
            dgvProducts.Columns["CreatedAt"].FillWeight = 77;

            dgvProducts.Columns["UnitPrice"].DefaultCellStyle.Format = "N2";
            dgvProducts.Columns["CreatedAt"].DefaultCellStyle.Format = "MMM d, yyyy";

            // Numbers line up on the right, as in a ledger.
            foreach (string name in new[] { "ProductID", "UnitPrice", "Quantity", "ReorderLevel" })
            {
                dgvProducts.Columns[name].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProducts.Columns[name].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        // Low stock and Out of stock show bold and brown. The word still says the state, so the
        // color is a second signal, not the only one.
        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvProducts.Columns[e.ColumnIndex].Name != "Status")
                return;

            string status = e.Value as string;
            if (status == "Low stock" || status == "Out of stock")
            {
                e.CellStyle.Font = statusFont;
                e.CellStyle.ForeColor = Color.Brown;
                e.CellStyle.SelectionForeColor = Color.Brown;
            }
        }

        // ---------- Create ----------

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateProduct(out decimal unitPrice, out int quantity, out int reorderLevel))
                return;

            string productName = txtProductName.Text.Trim();

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    if (NameTaken(con, productName, 0))
                    {
                        MessageBox.Show($"{productName} is already on the list. Choose its row to change it.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtProductName.Focus();
                        return;
                    }

                    string query = "INSERT INTO Products (ProductName, Category, Description, UnitPrice, Quantity, ReorderLevel, CreatedAt) VALUES (?, ?, ?, ?, ?, ?, Now())";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = productName;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = cmbCategory.Text;
                        cmd.Parameters.Add("?", OleDbType.LongVarWChar).Value = DescriptionValue();
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = unitPrice;
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = quantity;
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = reorderLevel;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"{productName} is added to the list.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadProducts();
                LoadStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The product was not added." + Environment.NewLine + Environment.NewLine + ex.Message, "Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- Update ----------

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductID == 0)
            {
                MessageBox.Show("Choose a product in the list first.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateProduct(out decimal unitPrice, out int quantity, out int reorderLevel))
                return;

            string productName = txtProductName.Text.Trim();

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    if (NameTaken(con, productName, selectedProductID))
                    {
                        MessageBox.Show($"Another product is already named {productName}. Choose a different name.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtProductName.Focus();
                        return;
                    }

                    string query = "UPDATE Products SET ProductName = ?, Category = ?, Description = ?, UnitPrice = ?, Quantity = ?, ReorderLevel = ? WHERE ProductID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = productName;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = cmbCategory.Text;
                        cmd.Parameters.Add("?", OleDbType.LongVarWChar).Value = DescriptionValue();
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = unitPrice;
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = quantity;
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = reorderLevel;
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedProductID;

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("That product is no longer on the list. Refresh the list and choose again.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ClearFields();
                            LoadProducts();
                            LoadStats();
                            return;
                        }
                    }
                }

                MessageBox.Show($"{productName} is updated.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadProducts();
                LoadStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The product was not updated." + Environment.NewLine + Environment.NewLine + ex.Message, "Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- Delete ----------

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductID == 0)
            {
                MessageBox.Show("Choose a product in the list first.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productName = selectedProductName;

            // No is the default button, so pressing Enter by habit keeps the product.
            DialogResult result = MessageBox.Show($"Delete {productName} from the list? Its row is removed from the database.", "Delete product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = "DELETE FROM Products WHERE ProductID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedProductID;
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"{productName} is deleted from the list.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadProducts();
                LoadStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The product was not deleted." + Environment.NewLine + Environment.NewLine + ex.Message, "Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- Helpers ----------

        // Checks every field before a save and points at the first one that needs fixing.
        private bool ValidateProduct(out decimal unitPrice, out int quantity, out int reorderLevel)
        {
            unitPrice = 0;
            quantity = 0;
            reorderLevel = 0;

            if (txtProductName.Text.Trim() == "")
            {
                MessageBox.Show("Enter the product name.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return false;
            }

            if (cmbCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Choose a category.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Enter the unit price as a number of 0 or more, like 125.50.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return false;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out quantity) || quantity < 0)
            {
                MessageBox.Show("Enter the quantity as a whole number of 0 or more.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }

            if (!int.TryParse(txtReorderLevel.Text.Trim(), out reorderLevel) || reorderLevel < 0)
            {
                MessageBox.Show("Enter the reorder level as a whole number of 0 or more.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReorderLevel.Focus();
                return false;
            }

            return true;
        }

        // Access compares text without regard to letter case, so "soy sauce" matches "Soy Sauce".
        private static bool NameTaken(OleDbConnection con, string productName, int exceptProductID)
        {
            string query = "SELECT COUNT(*) FROM Products WHERE ProductName = ? AND ProductID <> ?";

            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = productName;
                cmd.Parameters.Add("?", OleDbType.Integer).Value = exceptProductID;
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // A blank description is stored as an empty field (NULL), not as an empty string.
        private object DescriptionValue()
        {
            string description = txtDescription.Text.Trim();
            return description == "" ? (object)DBNull.Value : description;
        }

        private void ClearFields()
        {
            txtProductName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtDescription.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtReorderLevel.Clear();

            selectedProductID = 0;
            selectedProductName = "";
            dgvProducts.ClearSelection();
            txtProductName.Focus();
        }

        // Clicking a row fills the fields with that product, ready for Update or Delete.
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // -1 is the header row.
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

            selectedProductID = Convert.ToInt32(row.Cells["ProductID"].Value);
            selectedProductName = row.Cells["ProductName"].Value.ToString();

            txtProductName.Text = selectedProductName;
            txtDescription.Text = row.Cells["Description"].Value.ToString();
            txtUnitPrice.Text = Convert.ToDecimal(row.Cells["UnitPrice"].Value).ToString("0.00", CultureInfo.CurrentCulture);
            txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
            txtReorderLevel.Text = row.Cells["ReorderLevel"].Value.ToString();

            // A category saved before the list changed is added back, so the row shows what it holds.
            string category = row.Cells["Category"].Value.ToString();
            if (category != "" && !cmbCategory.Items.Contains(category))
                cmbCategory.Items.Add(category);
            cmbCategory.SelectedItem = category == "" ? null : category;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
            LoadStats();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        // ---------- Sidebar ----------

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            NextPage = null;
            this.Close();
        }

        private void lblUsers_Click(object sender, EventArgs e)
        {
            NextPage = "Users";
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
