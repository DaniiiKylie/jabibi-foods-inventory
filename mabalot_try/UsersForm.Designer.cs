namespace mabalot_try
{
    partial class UsersForm
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
            this.pnlActive = new System.Windows.Forms.Panel();
            this.lblActiveNote = new System.Windows.Forms.Label();
            this.lblActiveCount = new System.Windows.Forms.Label();
            this.lblActiveTitle = new System.Windows.Forms.Label();
            this.pnlTurnedOff = new System.Windows.Forms.Panel();
            this.lblTurnedOffNote = new System.Windows.Forms.Label();
            this.lblTurnedOffCount = new System.Windows.Forms.Label();
            this.lblTurnedOffTitle = new System.Windows.Forms.Label();
            this.pnlAdmins = new System.Windows.Forms.Panel();
            this.lblAdminsNote = new System.Windows.Forms.Label();
            this.lblAdminsCount = new System.Windows.Forms.Label();
            this.lblAdminsTitle = new System.Windows.Forms.Label();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lblPasswordHint = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblEmptyList = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlActive.SuspendLayout();
            this.pnlTurnedOff.SuspendLayout();
            this.pnlAdmins.SuspendLayout();
            this.pnlEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
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
            this.lblUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(5, 515);
            this.lblUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(55, 20);
            this.lblUsers.TabIndex = 15;
            this.lblUsers.Text = "Users";
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
            this.lblItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(4, 245);
            this.lblItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(55, 20);
            this.lblItems.TabIndex = 6;
            this.lblItems.Text = "Items";
            this.lblItems.Click += new System.EventHandler(this.lblItems_Click);
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
            this.lblTitle.Size = new System.Drawing.Size(119, 46);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Users";
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
            this.lblSubtitle.Text = "These accounts can log in to Jabibi Inventory. Choose a row in the list to change or delete it.";
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
            this.lblTotalNote.Size = new System.Drawing.Size(172, 17);
            this.lblTotalNote.TabIndex = 2;
            this.lblTotalNote.Text = "Every account on the list";
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
            this.lblTotalTitle.Size = new System.Drawing.Size(80, 17);
            this.lblTotalTitle.TabIndex = 0;
            this.lblTotalTitle.Text = "Total users";
            //
            // pnlActive
            //
            this.pnlActive.BackColor = System.Drawing.Color.White;
            this.pnlActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActive.Controls.Add(this.lblActiveNote);
            this.pnlActive.Controls.Add(this.lblActiveCount);
            this.pnlActive.Controls.Add(this.lblActiveTitle);
            this.pnlActive.Location = new System.Drawing.Point(749, 122);
            this.pnlActive.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(235, 96);
            this.pnlActive.TabIndex = 23;
            //
            // lblActiveNote
            //
            this.lblActiveNote.AutoSize = true;
            this.lblActiveNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblActiveNote.Location = new System.Drawing.Point(8, 68);
            this.lblActiveNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveNote.Name = "lblActiveNote";
            this.lblActiveNote.Size = new System.Drawing.Size(68, 17);
            this.lblActiveNote.TabIndex = 2;
            this.lblActiveNote.Text = "Can log in";
            //
            // lblActiveCount
            //
            this.lblActiveCount.AutoSize = true;
            this.lblActiveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveCount.Location = new System.Drawing.Point(6, 30);
            this.lblActiveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveCount.Name = "lblActiveCount";
            this.lblActiveCount.Size = new System.Drawing.Size(32, 36);
            this.lblActiveCount.TabIndex = 1;
            this.lblActiveCount.Text = "0";
            //
            // lblActiveTitle
            //
            this.lblActiveTitle.AutoSize = true;
            this.lblActiveTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblActiveTitle.Location = new System.Drawing.Point(8, 8);
            this.lblActiveTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveTitle.Name = "lblActiveTitle";
            this.lblActiveTitle.Size = new System.Drawing.Size(46, 17);
            this.lblActiveTitle.TabIndex = 0;
            this.lblActiveTitle.Text = "Active";
            //
            // pnlTurnedOff
            //
            this.pnlTurnedOff.BackColor = System.Drawing.Color.White;
            this.pnlTurnedOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTurnedOff.Controls.Add(this.lblTurnedOffNote);
            this.pnlTurnedOff.Controls.Add(this.lblTurnedOffCount);
            this.pnlTurnedOff.Controls.Add(this.lblTurnedOffTitle);
            this.pnlTurnedOff.Location = new System.Drawing.Point(993, 122);
            this.pnlTurnedOff.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTurnedOff.Name = "pnlTurnedOff";
            this.pnlTurnedOff.Size = new System.Drawing.Size(235, 96);
            this.pnlTurnedOff.TabIndex = 24;
            //
            // lblTurnedOffNote
            //
            this.lblTurnedOffNote.AutoSize = true;
            this.lblTurnedOffNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblTurnedOffNote.Location = new System.Drawing.Point(8, 68);
            this.lblTurnedOffNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurnedOffNote.Name = "lblTurnedOffNote";
            this.lblTurnedOffNote.Size = new System.Drawing.Size(158, 17);
            this.lblTurnedOffNote.TabIndex = 2;
            this.lblTurnedOffNote.Text = "Kept from logging in";
            //
            // lblTurnedOffCount
            //
            this.lblTurnedOffCount.AutoSize = true;
            this.lblTurnedOffCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnedOffCount.Location = new System.Drawing.Point(6, 30);
            this.lblTurnedOffCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurnedOffCount.Name = "lblTurnedOffCount";
            this.lblTurnedOffCount.Size = new System.Drawing.Size(32, 36);
            this.lblTurnedOffCount.TabIndex = 1;
            this.lblTurnedOffCount.Text = "0";
            //
            // lblTurnedOffTitle
            //
            this.lblTurnedOffTitle.AutoSize = true;
            this.lblTurnedOffTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblTurnedOffTitle.Location = new System.Drawing.Point(8, 8);
            this.lblTurnedOffTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurnedOffTitle.Name = "lblTurnedOffTitle";
            this.lblTurnedOffTitle.Size = new System.Drawing.Size(73, 17);
            this.lblTurnedOffTitle.TabIndex = 0;
            this.lblTurnedOffTitle.Text = "Turned off";
            //
            // pnlAdmins
            //
            this.pnlAdmins.BackColor = System.Drawing.Color.White;
            this.pnlAdmins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdmins.Controls.Add(this.lblAdminsNote);
            this.pnlAdmins.Controls.Add(this.lblAdminsCount);
            this.pnlAdmins.Controls.Add(this.lblAdminsTitle);
            this.pnlAdmins.Location = new System.Drawing.Point(1237, 122);
            this.pnlAdmins.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAdmins.Name = "pnlAdmins";
            this.pnlAdmins.Size = new System.Drawing.Size(235, 96);
            this.pnlAdmins.TabIndex = 25;
            //
            // lblAdminsNote
            //
            this.lblAdminsNote.AutoSize = true;
            this.lblAdminsNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblAdminsNote.Location = new System.Drawing.Point(8, 68);
            this.lblAdminsNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminsNote.Name = "lblAdminsNote";
            this.lblAdminsNote.Size = new System.Drawing.Size(131, 17);
            this.lblAdminsNote.TabIndex = 2;
            this.lblAdminsNote.Text = "Role set to Admin";
            //
            // lblAdminsCount
            //
            this.lblAdminsCount.AutoSize = true;
            this.lblAdminsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminsCount.Location = new System.Drawing.Point(6, 30);
            this.lblAdminsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminsCount.Name = "lblAdminsCount";
            this.lblAdminsCount.Size = new System.Drawing.Size(32, 36);
            this.lblAdminsCount.TabIndex = 1;
            this.lblAdminsCount.Text = "0";
            //
            // lblAdminsTitle
            //
            this.lblAdminsTitle.AutoSize = true;
            this.lblAdminsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblAdminsTitle.Location = new System.Drawing.Point(8, 8);
            this.lblAdminsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminsTitle.Name = "lblAdminsTitle";
            this.lblAdminsTitle.Size = new System.Drawing.Size(100, 17);
            this.lblAdminsTitle.TabIndex = 0;
            this.lblAdminsTitle.Text = "Administrators";
            //
            // pnlEditor
            //
            this.pnlEditor.BackColor = System.Drawing.Color.White;
            this.pnlEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditor.Controls.Add(this.lblFullName);
            this.pnlEditor.Controls.Add(this.txtFullName);
            this.pnlEditor.Controls.Add(this.lblUsername);
            this.pnlEditor.Controls.Add(this.txtUsername);
            this.pnlEditor.Controls.Add(this.lblRole);
            this.pnlEditor.Controls.Add(this.cmbRole);
            this.pnlEditor.Controls.Add(this.lblPassword);
            this.pnlEditor.Controls.Add(this.txtPassword);
            this.pnlEditor.Controls.Add(this.lblConfirmPassword);
            this.pnlEditor.Controls.Add(this.txtConfirmPassword);
            this.pnlEditor.Controls.Add(this.chkActive);
            this.pnlEditor.Controls.Add(this.lblPasswordHint);
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
            // lblFullName
            //
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(14, 10);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(77, 17);
            this.lblFullName.TabIndex = 20;
            this.lblFullName.Text = "Full name";
            //
            // txtFullName
            //
            this.txtFullName.Location = new System.Drawing.Point(17, 30);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.MaxLength = 100;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(300, 22);
            this.txtFullName.TabIndex = 0;
            //
            // lblUsername
            //
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(334, 10);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 17);
            this.lblUsername.TabIndex = 21;
            this.lblUsername.Text = "Username";
            //
            // txtUsername
            //
            this.txtUsername.Location = new System.Drawing.Point(337, 30);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(260, 22);
            this.txtUsername.TabIndex = 1;
            //
            // lblRole
            //
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(614, 10);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 17);
            this.lblRole.TabIndex = 22;
            this.lblRole.Text = "Role";
            //
            // cmbRole
            //
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmbRole.Location = new System.Drawing.Point(617, 30);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(160, 24);
            this.cmbRole.TabIndex = 2;
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(14, 66);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 17);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Password";
            //
            // txtPassword
            //
            this.txtPassword.Location = new System.Drawing.Point(17, 86);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            //
            // lblConfirmPassword
            //
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPassword.Location = new System.Drawing.Point(334, 66);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(138, 17);
            this.lblConfirmPassword.TabIndex = 24;
            this.lblConfirmPassword.Text = "Confirm password";
            //
            // txtConfirmPassword
            //
            this.txtConfirmPassword.Location = new System.Drawing.Point(337, 86);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(260, 22);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            //
            // chkActive
            //
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(617, 88);
            this.chkActive.Margin = new System.Windows.Forms.Padding(4);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(140, 20);
            this.chkActive.TabIndex = 5;
            this.chkActive.Text = "Active, can log in";
            this.chkActive.UseVisualStyleBackColor = true;
            //
            // lblPasswordHint
            //
            this.lblPasswordHint.AutoSize = true;
            this.lblPasswordHint.Location = new System.Drawing.Point(14, 120);
            this.lblPasswordHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordHint.Name = "lblPasswordHint";
            this.lblPasswordHint.Size = new System.Drawing.Size(560, 16);
            this.lblPasswordHint.TabIndex = 25;
            this.lblPasswordHint.Text = "Use at least 8 characters. When updating, leave both password boxes blank to keep the current password.";
            //
            // btnAdd
            //
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(812, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add user";
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
            this.lblListTitle.Size = new System.Drawing.Size(98, 25);
            this.lblListTitle.TabIndex = 26;
            this.lblListTitle.Text = "User list";
            //
            // btnRefresh
            //
            this.btnRefresh.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRefresh.Location = new System.Drawing.Point(619, 430);
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
            // dgvUsers
            //
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(505, 468);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(967, 228);
            this.dgvUsers.TabIndex = 4;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            //
            // lblEmptyList
            //
            this.lblEmptyList.BackColor = System.Drawing.Color.White;
            this.lblEmptyList.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmptyList.Location = new System.Drawing.Point(507, 530);
            this.lblEmptyList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmptyList.Name = "lblEmptyList";
            this.lblEmptyList.Size = new System.Drawing.Size(963, 40);
            this.lblEmptyList.TabIndex = 28;
            this.lblEmptyList.Text = "No account matches that search.";
            this.lblEmptyList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmptyList.Visible = false;
            //
            // UsersForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1500, 713);
            this.Controls.Add(this.lblEmptyList);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblListTitle);
            this.Controls.Add(this.pnlEditor);
            this.Controls.Add(this.pnlAdmins);
            this.Controls.Add(this.pnlTurnedOff);
            this.Controls.Add(this.pnlActive);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsersForm";
            this.Text = "Jabibi Inventory: Users";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlActive.ResumeLayout(false);
            this.pnlActive.PerformLayout();
            this.pnlTurnedOff.ResumeLayout(false);
            this.pnlTurnedOff.PerformLayout();
            this.pnlAdmins.ResumeLayout(false);
            this.pnlAdmins.PerformLayout();
            this.pnlEditor.ResumeLayout(false);
            this.pnlEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
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
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.Label lblActiveNote;
        private System.Windows.Forms.Label lblActiveCount;
        private System.Windows.Forms.Label lblActiveTitle;
        private System.Windows.Forms.Panel pnlTurnedOff;
        private System.Windows.Forms.Label lblTurnedOffNote;
        private System.Windows.Forms.Label lblTurnedOffCount;
        private System.Windows.Forms.Label lblTurnedOffTitle;
        private System.Windows.Forms.Panel pnlAdmins;
        private System.Windows.Forms.Label lblAdminsNote;
        private System.Windows.Forms.Label lblAdminsCount;
        private System.Windows.Forms.Label lblAdminsTitle;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label lblPasswordHint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblEmptyList;
        private System.Windows.Forms.Button btnLogOut;
    }
}
