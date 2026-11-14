namespace mabalot_try
{
    partial class ItemsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblAccountRole = new System.Windows.Forms.Label();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblRecipes = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.lblPurchaseOrders = new System.Windows.Forms.Label();
            this.lblPurchasing = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblReports = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblOverview = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalNote = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.pnlInStock = new System.Windows.Forms.Panel();
            this.lblInStockNote = new System.Windows.Forms.Label();
            this.lblInStockCount = new System.Windows.Forms.Label();
            this.lblInStockTitle = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.lblLowStockNote = new System.Windows.Forms.Label();
            this.lblLowStockCount = new System.Windows.Forms.Label();
            this.lblLowStockTitle = new System.Windows.Forms.Label();
            this.pnlOutOfStock = new System.Windows.Forms.Panel();
            this.lblOutOfStockNote = new System.Windows.Forms.Label();
            this.lblOutOfStockCount = new System.Windows.Forms.Label();
            this.lblOutOfStockTitle = new System.Windows.Forms.Label();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.lblReorderHint = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblEmptyList = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlInStock.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlOutOfStock.SuspendLayout();
            this.pnlEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            //
            // pnlSidebar
            //
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.pnlAccount);
            this.pnlSidebar.Controls.Add(this.pnlBrand);
            this.pnlSidebar.Controls.Add(this.lblUsers);
            this.pnlSidebar.Controls.Add(this.lblAdmin);
            this.pnlSidebar.Controls.Add(this.lblRecipes);
            this.pnlSidebar.Controls.Add(this.lblMenu);
            this.pnlSidebar.Controls.Add(this.lblSuppliers);
            this.pnlSidebar.Controls.Add(this.lblPurchaseOrders);
            this.pnlSidebar.Controls.Add(this.lblPurchasing);
            this.pnlSidebar.Controls.Add(this.lblItems);
            this.pnlSidebar.Controls.Add(this.lblStock);
            this.pnlSidebar.Controls.Add(this.lblReports);
            this.pnlSidebar.Controls.Add(this.lblDashboard);
            this.pnlSidebar.Controls.Add(this.lblOverview);
            this.pnlSidebar.Location = new System.Drawing.Point(16, 15);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(431, 683);
            this.pnlSidebar.TabIndex = 30;
            //
            // pnlAccount
            //
            this.pnlAccount.BackColor = System.Drawing.Color.Brown;
            this.pnlAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAccount.Controls.Add(this.lblAccountName);
            this.pnlAccount.Controls.Add(this.lblAccountRole);
            this.pnlAccount.Controls.Add(this.btnLogOut);
            this.pnlAccount.Location = new System.Drawing.Point(1, 614);
            this.pnlAccount.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(423, 61);
            this.pnlAccount.TabIndex = 13;
            //
            // lblAccountName
            //
            this.lblAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAccountName.Location = new System.Drawing.Point(128, 16);
            this.lblAccountName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(182, 20);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Danah Mabalot";
            //
            // btnLogOut
            //
            this.btnLogOut.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLogOut.Location = new System.Drawing.Point(318, 15);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(92, 30);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            //
            // lblAccountRole
            //
            this.lblAccountRole.AutoSize = true;
            this.lblAccountRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblAccountRole.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAccountRole.Location = new System.Drawing.Point(128, 36);
            this.lblAccountRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountRole.Name = "lblAccountRole";
            this.lblAccountRole.Size = new System.Drawing.Size(37, 17);
            this.lblAccountRole.TabIndex = 1;
            this.lblAccountRole.Text = "User";
            //
            // pnlBrand
            //
            this.pnlBrand.BackColor = System.Drawing.Color.Brown;
            this.pnlBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBrand.Controls.Add(this.lblBrand);
            this.pnlBrand.Controls.Add(this.lblBranch);
            this.pnlBrand.Location = new System.Drawing.Point(1, 4);
            this.pnlBrand.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(423, 61);
            this.pnlBrand.TabIndex = 12;
            //
            // lblBrand
            //
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Brown;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBrand.Location = new System.Drawing.Point(128, 16);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(141, 20);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Jabibi Inventory";
            //
            // lblBranch
            //
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblBranch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBranch.Location = new System.Drawing.Point(128, 36);
            this.lblBranch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(105, 17);
            this.lblBranch.TabIndex = 1;
            this.lblBranch.Text = "Malolos Branch";
            //
            // lblUsers
            //
            this.lblUsers.AutoSize = true;
            this.lblUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(5, 515);
            this.lblUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(55, 20);
            this.lblUsers.TabIndex = 15;
            this.lblUsers.Text = "Users";
            this.lblUsers.Click += new System.EventHandler(this.lblUsers_Click);
            //
            // lblAdmin
            //
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblAdmin.Location = new System.Drawing.Point(5, 481);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(45, 17);
            this.lblAdmin.TabIndex = 14;
            this.lblAdmin.Text = "Admin";
            //
            // lblRecipes
            //
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipes.Location = new System.Drawing.Point(5, 433);
            this.lblRecipes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(77, 20);
            this.lblRecipes.TabIndex = 11;
            this.lblRecipes.Text = "Recipes";
            //
            // lblMenu
            //
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblMenu.Location = new System.Drawing.Point(5, 399);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(43, 17);
            this.lblMenu.TabIndex = 10;
            this.lblMenu.Text = "Menu";
            //
            // lblSuppliers
            //
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliers.Location = new System.Drawing.Point(4, 351);
            this.lblSuppliers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(88, 20);
            this.lblSuppliers.TabIndex = 9;
            this.lblSuppliers.Text = "Suppliers";
            //
            // lblPurchaseOrders
            //
            this.lblPurchaseOrders.AutoSize = true;
            this.lblPurchaseOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseOrders.Location = new System.Drawing.Point(4, 320);
            this.lblPurchaseOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchaseOrders.Name = "lblPurchaseOrders";
            this.lblPurchaseOrders.Size = new System.Drawing.Size(152, 20);
            this.lblPurchaseOrders.TabIndex = 8;
            this.lblPurchaseOrders.Text = "Purchase Orders";
            //
            // lblPurchasing
            //
            this.lblPurchasing.AutoSize = true;
            this.lblPurchasing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblPurchasing.Location = new System.Drawing.Point(4, 292);
            this.lblPurchasing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchasing.Name = "lblPurchasing";
            this.lblPurchasing.Size = new System.Drawing.Size(79, 17);
            this.lblPurchasing.TabIndex = 7;
            this.lblPurchasing.Text = "Purchasing";
            //
            // lblItems
            //
            this.lblItems.AutoSize = true;
            this.lblItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(4, 245);
            this.lblItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(55, 20);
            this.lblItems.TabIndex = 6;
            this.lblItems.Text = "Items";
            //
            // lblStock
            //
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblStock.Location = new System.Drawing.Point(4, 215);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 17);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock";
            //
            // lblReports
            //
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(4, 178);
            this.lblReports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(75, 20);
            this.lblReports.TabIndex = 4;
            this.lblReports.Text = "Reports";
            //
            // lblDashboard
            //
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(4, 148);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(100, 20);
            this.lblDashboard.TabIndex = 3;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            //
            // lblOverview
            //
            this.lblOverview.AutoSize = true;
            this.lblOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblOverview.Location = new System.Drawing.Point(4, 121);
            this.lblOverview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(66, 17);
            this.lblOverview.TabIndex = 2;
            this.lblOverview.Text = "Overview";
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(496, 36);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 46);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Items";
            //
            // lblSubtitle
            //
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSubtitle.Location = new System.Drawing.Point(501, 92);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(600, 17);
            this.lblSubtitle.TabIndex = 21;
            this.lblSubtitle.Text = "The Malolos Branch keeps these products in stock. Choose a row in the list to change or delete it.";
            //
            // pnlTotal
            //
            this.pnlTotal.BackColor = System.Drawing.Color.White;
            this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotal.Controls.Add(this.lblTotalNote);
            this.pnlTotal.Controls.Add(this.lblTotalCount);
            this.pnlTotal.Controls.Add(this.lblTotalTitle);
            this.pnlTotal.Location = new System.Drawing.Point(505, 122);
            this.pnlTotal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(235, 96);
            this.pnlTotal.TabIndex = 22;
            //
            // lblTotalNote
            //
            this.lblTotalNote.AutoSize = true;
            this.lblTotalNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblTotalNote.Location = new System.Drawing.Point(8, 68);
            this.lblTotalNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalNote.Name = "lblTotalNote";
            this.lblTotalNote.Size = new System.Drawing.Size(165, 17);
            this.lblTotalNote.TabIndex = 2;
            this.lblTotalNote.Text = "Every product on the list";
            //
            // lblTotalCount
            //
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.Location = new System.Drawing.Point(6, 30);
            this.lblTotalCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(32, 36);
            this.lblTotalCount.TabIndex = 1;
            this.lblTotalCount.Text = "0";
            //
            // lblTotalTitle
            //
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblTotalTitle.Location = new System.Drawing.Point(8, 8);
            this.lblTotalTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(103, 17);
            this.lblTotalTitle.TabIndex = 0;
            this.lblTotalTitle.Text = "Total products";
            //
            // pnlInStock
            //
            this.pnlInStock.BackColor = System.Drawing.Color.White;
            this.pnlInStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInStock.Controls.Add(this.lblInStockNote);
            this.pnlInStock.Controls.Add(this.lblInStockCount);
            this.pnlInStock.Controls.Add(this.lblInStockTitle);
            this.pnlInStock.Location = new System.Drawing.Point(749, 122);
            this.pnlInStock.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInStock.Name = "pnlInStock";
            this.pnlInStock.Size = new System.Drawing.Size(235, 96);
            this.pnlInStock.TabIndex = 23;
            //
            // lblInStockNote
            //
            this.lblInStockNote.AutoSize = true;
            this.lblInStockNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblInStockNote.Location = new System.Drawing.Point(8, 68);
            this.lblInStockNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInStockNote.Name = "lblInStockNote";
            this.lblInStockNote.Size = new System.Drawing.Size(165, 17);
            this.lblInStockNote.TabIndex = 2;
            this.lblInStockNote.Text = "Above the reorder level";
            //
            // lblInStockCount
            //
            this.lblInStockCount.AutoSize = true;
            this.lblInStockCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInStockCount.Location = new System.Drawing.Point(6, 30);
            this.lblInStockCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInStockCount.Name = "lblInStockCount";
            this.lblInStockCount.Size = new System.Drawing.Size(32, 36);
            this.lblInStockCount.TabIndex = 1;
            this.lblInStockCount.Text = "0";
            //
            // lblInStockTitle
            //
            this.lblInStockTitle.AutoSize = true;
            this.lblInStockTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblInStockTitle.Location = new System.Drawing.Point(8, 8);
            this.lblInStockTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInStockTitle.Name = "lblInStockTitle";
            this.lblInStockTitle.Size = new System.Drawing.Size(60, 17);
            this.lblInStockTitle.TabIndex = 0;
            this.lblInStockTitle.Text = "In stock";
            //
            // pnlLowStock
            //
            this.pnlLowStock.BackColor = System.Drawing.Color.White;
            this.pnlLowStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLowStock.Controls.Add(this.lblLowStockNote);
            this.pnlLowStock.Controls.Add(this.lblLowStockCount);
            this.pnlLowStock.Controls.Add(this.lblLowStockTitle);
            this.pnlLowStock.Location = new System.Drawing.Point(993, 122);
            this.pnlLowStock.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(235, 96);
            this.pnlLowStock.TabIndex = 24;
            //
            // lblLowStockNote
            //
            this.lblLowStockNote.AutoSize = true;
            this.lblLowStockNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblLowStockNote.Location = new System.Drawing.Point(8, 68);
            this.lblLowStockNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLowStockNote.Name = "lblLowStockNote";
            this.lblLowStockNote.Size = new System.Drawing.Size(196, 17);
            this.lblLowStockNote.TabIndex = 2;
            this.lblLowStockNote.Text = "1 up to the reorder level";
            //
            // lblLowStockCount
            //
            this.lblLowStockCount.AutoSize = true;
            this.lblLowStockCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStockCount.Location = new System.Drawing.Point(6, 30);
            this.lblLowStockCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLowStockCount.Name = "lblLowStockCount";
            this.lblLowStockCount.Size = new System.Drawing.Size(32, 36);
            this.lblLowStockCount.TabIndex = 1;
            this.lblLowStockCount.Text = "0";
            //
            // lblLowStockTitle
            //
            this.lblLowStockTitle.AutoSize = true;
            this.lblLowStockTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblLowStockTitle.Location = new System.Drawing.Point(8, 8);
            this.lblLowStockTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLowStockTitle.Name = "lblLowStockTitle";
            this.lblLowStockTitle.Size = new System.Drawing.Size(69, 17);
            this.lblLowStockTitle.TabIndex = 0;
            this.lblLowStockTitle.Text = "Low stock";
            //
            // pnlOutOfStock
            //
            this.pnlOutOfStock.BackColor = System.Drawing.Color.White;
            this.pnlOutOfStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOutOfStock.Controls.Add(this.lblOutOfStockNote);
            this.pnlOutOfStock.Controls.Add(this.lblOutOfStockCount);
            this.pnlOutOfStock.Controls.Add(this.lblOutOfStockTitle);
            this.pnlOutOfStock.Location = new System.Drawing.Point(1237, 122);
            this.pnlOutOfStock.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOutOfStock.Name = "pnlOutOfStock";
            this.pnlOutOfStock.Size = new System.Drawing.Size(235, 96);
            this.pnlOutOfStock.TabIndex = 25;
            //
            // lblOutOfStockNote
            //
            this.lblOutOfStockNote.AutoSize = true;
            this.lblOutOfStockNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblOutOfStockNote.Location = new System.Drawing.Point(8, 68);
            this.lblOutOfStockNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutOfStockNote.Name = "lblOutOfStockNote";
            this.lblOutOfStockNote.Size = new System.Drawing.Size(105, 17);
            this.lblOutOfStockNote.TabIndex = 2;
            this.lblOutOfStockNote.Text = "Quantity of 0";
            //
            // lblOutOfStockCount
            //
            this.lblOutOfStockCount.AutoSize = true;
            this.lblOutOfStockCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutOfStockCount.Location = new System.Drawing.Point(6, 30);
            this.lblOutOfStockCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutOfStockCount.Name = "lblOutOfStockCount";
            this.lblOutOfStockCount.Size = new System.Drawing.Size(32, 36);
            this.lblOutOfStockCount.TabIndex = 1;
            this.lblOutOfStockCount.Text = "0";
            //
            // lblOutOfStockTitle
            //
            this.lblOutOfStockTitle.AutoSize = true;
            this.lblOutOfStockTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblOutOfStockTitle.Location = new System.Drawing.Point(8, 8);
            this.lblOutOfStockTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutOfStockTitle.Name = "lblOutOfStockTitle";
            this.lblOutOfStockTitle.Size = new System.Drawing.Size(86, 17);
            this.lblOutOfStockTitle.TabIndex = 0;
            this.lblOutOfStockTitle.Text = "Out of stock";
            //
            // pnlEditor
            //
            this.pnlEditor.BackColor = System.Drawing.Color.White;
            this.pnlEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditor.Controls.Add(this.lblProductName);
            this.pnlEditor.Controls.Add(this.txtProductName);
            this.pnlEditor.Controls.Add(this.lblCategory);
            this.pnlEditor.Controls.Add(this.cmbCategory);
            this.pnlEditor.Controls.Add(this.lblUnitPrice);
            this.pnlEditor.Controls.Add(this.txtUnitPrice);
            this.pnlEditor.Controls.Add(this.lblDescription);
            this.pnlEditor.Controls.Add(this.txtDescription);
            this.pnlEditor.Controls.Add(this.lblQuantity);
            this.pnlEditor.Controls.Add(this.txtQuantity);
            this.pnlEditor.Controls.Add(this.lblReorderLevel);
            this.pnlEditor.Controls.Add(this.txtReorderLevel);
            this.pnlEditor.Controls.Add(this.lblReorderHint);
            this.pnlEditor.Controls.Add(this.btnAdd);
            this.pnlEditor.Controls.Add(this.btnUpdate);
            this.pnlEditor.Controls.Add(this.btnDelete);
            this.pnlEditor.Controls.Add(this.btnClear);
            this.pnlEditor.Location = new System.Drawing.Point(505, 232);
            this.pnlEditor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(967, 188);
            this.pnlEditor.TabIndex = 1;
            //
            // lblProductName
            //
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblProductName.Location = new System.Drawing.Point(14, 10);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(106, 17);
            this.lblProductName.TabIndex = 20;
            this.lblProductName.Text = "Product name";
            //
            // txtProductName
            //
            this.txtProductName.Location = new System.Drawing.Point(17, 30);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.MaxLength = 120;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(300, 22);
            this.txtProductName.TabIndex = 0;
            //
            // lblCategory
            //
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(334, 10);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 17);
            this.lblCategory.TabIndex = 21;
            this.lblCategory.Text = "Category";
            //
            // cmbCategory
            //
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Meat and poultry",
            "Seafood",
            "Rice and noodles",
            "Sauces and condiments",
            "Vegetables and fruits",
            "Cooking oil",
            "Beverages",
            "Packaging"});
            this.cmbCategory.Location = new System.Drawing.Point(337, 30);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(260, 24);
            this.cmbCategory.TabIndex = 1;
            //
            // lblUnitPrice
            //
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblUnitPrice.Location = new System.Drawing.Point(614, 10);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(143, 17);
            this.lblUnitPrice.TabIndex = 22;
            this.lblUnitPrice.Text = "Unit price, in pesos";
            //
            // txtUnitPrice
            //
            this.txtUnitPrice.Location = new System.Drawing.Point(617, 30);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(160, 22);
            this.txtUnitPrice.TabIndex = 2;
            //
            // lblDescription
            //
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(14, 66);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 17);
            this.lblDescription.TabIndex = 23;
            this.lblDescription.Text = "Description";
            //
            // txtDescription
            //
            this.txtDescription.Location = new System.Drawing.Point(17, 86);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.Size = new System.Drawing.Size(300, 76);
            this.txtDescription.TabIndex = 3;
            //
            // lblQuantity
            //
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.Location = new System.Drawing.Point(334, 66);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 17);
            this.lblQuantity.TabIndex = 24;
            this.lblQuantity.Text = "Quantity";
            //
            // txtQuantity
            //
            this.txtQuantity.Location = new System.Drawing.Point(337, 86);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(160, 22);
            this.txtQuantity.TabIndex = 4;
            //
            // lblReorderLevel
            //
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblReorderLevel.Location = new System.Drawing.Point(614, 66);
            this.lblReorderLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(104, 17);
            this.lblReorderLevel.TabIndex = 25;
            this.lblReorderLevel.Text = "Reorder level";
            //
            // txtReorderLevel
            //
            this.txtReorderLevel.Location = new System.Drawing.Point(617, 86);
            this.txtReorderLevel.Margin = new System.Windows.Forms.Padding(4);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(160, 22);
            this.txtReorderLevel.TabIndex = 5;
            //
            // lblReorderHint
            //
            this.lblReorderHint.AutoSize = true;
            this.lblReorderHint.Location = new System.Drawing.Point(334, 120);
            this.lblReorderHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReorderHint.Name = "lblReorderHint";
            this.lblReorderHint.Size = new System.Drawing.Size(390, 16);
            this.lblReorderHint.TabIndex = 26;
            this.lblReorderHint.Text = "Out of stock means 0 left. Low stock means 1 up to the reorder level.";
            //
            // btnAdd
            //
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(812, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add product";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnUpdate
            //
            this.btnUpdate.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUpdate.Location = new System.Drawing.Point(812, 50);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 32);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            //
            // btnDelete
            //
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Brown;
            this.btnDelete.Location = new System.Drawing.Point(816, 148);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 26);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnClear
            //
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClear.Location = new System.Drawing.Point(812, 90);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 32);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // lblListTitle
            //
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListTitle.Location = new System.Drawing.Point(500, 434);
            this.lblListTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(135, 25);
            this.lblListTitle.TabIndex = 26;
            this.lblListTitle.Text = "Product list";
            //
            // btnRefresh
            //
            this.btnRefresh.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRefresh.Location = new System.Drawing.Point(650, 430);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(1108, 438);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(58, 17);
            this.lblSearch.TabIndex = 27;
            this.lblSearch.Text = "Search";
            //
            // txtSearch
            //
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(1172, 434);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            //
            // dgvProducts
            //
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(505, 468);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(967, 228);
            this.dgvProducts.TabIndex = 4;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            //
            // lblEmptyList
            //
            this.lblEmptyList.BackColor = System.Drawing.Color.White;
            this.lblEmptyList.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmptyList.Location = new System.Drawing.Point(507, 530);
            this.lblEmptyList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmptyList.Name = "lblEmptyList";
            this.lblEmptyList.Size = new System.Drawing.Size(963, 40);
            this.lblEmptyList.TabIndex = 32;
            this.lblEmptyList.Text = "No products yet. Fill in the fields above and choose Add product.";
            this.lblEmptyList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmptyList.Visible = false;
            //
            // ItemsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1500, 713);
            this.Controls.Add(this.lblEmptyList);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblListTitle);
            this.Controls.Add(this.pnlEditor);
            this.Controls.Add(this.pnlOutOfStock);
            this.Controls.Add(this.pnlLowStock);
            this.Controls.Add(this.pnlInStock);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemsForm";
            this.Text = "Jabibi Inventory: Items";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlInStock.ResumeLayout(false);
            this.pnlInStock.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlOutOfStock.ResumeLayout(false);
            this.pnlOutOfStock.PerformLayout();
            this.pnlEditor.ResumeLayout(false);
            this.pnlEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblAccountRole;
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblRecipes;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Label lblPurchaseOrders;
        private System.Windows.Forms.Label lblPurchasing;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblOverview;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalNote;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Panel pnlInStock;
        private System.Windows.Forms.Label lblInStockNote;
        private System.Windows.Forms.Label lblInStockCount;
        private System.Windows.Forms.Label lblInStockTitle;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Label lblLowStockNote;
        private System.Windows.Forms.Label lblLowStockCount;
        private System.Windows.Forms.Label lblLowStockTitle;
        private System.Windows.Forms.Panel pnlOutOfStock;
        private System.Windows.Forms.Label lblOutOfStockNote;
        private System.Windows.Forms.Label lblOutOfStockCount;
        private System.Windows.Forms.Label lblOutOfStockTitle;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.Label lblReorderHint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblEmptyList;
        private System.Windows.Forms.Button btnLogOut;
    }
}
