namespace C__Group_Assignment
{
    partial class frmManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            this.btnSidebar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlControlBox = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlReservations = new System.Windows.Forms.Panel();
            this.btnReservations = new System.Windows.Forms.Button();
            this.pnlSignOut = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.containerInventory = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlReservation = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.pnlMakeReservation = new System.Windows.Forms.Panel();
            this.btnAddMenuItem = new System.Windows.Forms.Button();
            this.pnlReservationStatus = new System.Windows.Forms.Panel();
            this.btnEditItems = new System.Windows.Forms.Button();
            this.containerAccount = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.pnlPersonalInfo = new System.Windows.Forms.Panel();
            this.btnPersonalInfo = new System.Windows.Forms.Button();
            this.pnlSecurity = new System.Windows.Forms.Panel();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.containerReports = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSendFeedback = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.pnlReservationFeedback = new System.Windows.Forms.Panel();
            this.btnReservationsReports = new System.Windows.Forms.Button();
            this.pnlMenuFeedback = new System.Windows.Forms.Panel();
            this.btnSaleReports = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.dropdownReports = new System.Windows.Forms.Timer(this.components);
            this.dropdownAccount = new System.Windows.Forms.Timer(this.components);
            this.transitionSidebar = new System.Windows.Forms.Timer(this.components);
            this.dropdownInventory = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlControlBox.SuspendLayout();
            this.pnlReservations.SuspendLayout();
            this.pnlSignOut.SuspendLayout();
            this.containerInventory.SuspendLayout();
            this.pnlReservation.SuspendLayout();
            this.pnlMakeReservation.SuspendLayout();
            this.pnlReservationStatus.SuspendLayout();
            this.containerAccount.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            this.pnlPersonalInfo.SuspendLayout();
            this.pnlSecurity.SuspendLayout();
            this.containerReports.SuspendLayout();
            this.pnlSendFeedback.SuspendLayout();
            this.pnlReservationFeedback.SuspendLayout();
            this.pnlMenuFeedback.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSidebar
            // 
            this.btnSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnSidebar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSidebar.FlatAppearance.BorderSize = 0;
            this.btnSidebar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnSidebar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSidebar.ForeColor = System.Drawing.Color.Transparent;
            this.btnSidebar.Image = ((System.Drawing.Image)(resources.GetObject("btnSidebar.Image")));
            this.btnSidebar.Location = new System.Drawing.Point(13, 4);
            this.btnSidebar.Name = "btnSidebar";
            this.btnSidebar.Size = new System.Drawing.Size(44, 32);
            this.btnSidebar.TabIndex = 0;
            this.btnSidebar.UseVisualStyleBackColor = false;
            this.btnSidebar.Click += new System.EventHandler(this.btnSidebar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(73, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manager Page";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.pnlTop.Controls.Add(this.pnlControlBox);
            this.pnlTop.Controls.Add(this.btnSidebar);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(973, 39);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            // 
            // pnlControlBox
            // 
            this.pnlControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControlBox.Controls.Add(this.btnExit);
            this.pnlControlBox.Controls.Add(this.btnMinimize);
            this.pnlControlBox.Controls.Add(this.btnMaximize);
            this.pnlControlBox.Location = new System.Drawing.Point(796, -2);
            this.pnlControlBox.Name = "pnlControlBox";
            this.pnlControlBox.Size = new System.Drawing.Size(173, 41);
            this.pnlControlBox.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(123, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 32);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(6, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 32);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Image = global::C__Group_Assignment.Properties.Resources.Maximized_Icon_Resized;
            this.btnMaximize.Location = new System.Drawing.Point(65, 5);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(44, 32);
            this.btnMaximize.TabIndex = 7;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(217, 39);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(756, 589);
            this.pnlMain.TabIndex = 4;
            // 
            // pnlReservations
            // 
            this.pnlReservations.Controls.Add(this.btnReservations);
            this.pnlReservations.Location = new System.Drawing.Point(0, 56);
            this.pnlReservations.Margin = new System.Windows.Forms.Padding(0);
            this.pnlReservations.Name = "pnlReservations";
            this.pnlReservations.Size = new System.Drawing.Size(217, 57);
            this.pnlReservations.TabIndex = 6;
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnReservations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnReservations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.Color.White;
            this.btnReservations.Image = ((System.Drawing.Image)(resources.GetObject("btnReservations.Image")));
            this.btnReservations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.Location = new System.Drawing.Point(-12, -19);
            this.btnReservations.Margin = new System.Windows.Forms.Padding(0);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReservations.Size = new System.Drawing.Size(235, 98);
            this.btnReservations.TabIndex = 5;
            this.btnReservations.Text = "            Reservations";
            this.btnReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.UseVisualStyleBackColor = false;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // pnlSignOut
            // 
            this.pnlSignOut.Controls.Add(this.btnSignOut);
            this.pnlSignOut.Location = new System.Drawing.Point(0, 225);
            this.pnlSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSignOut.Name = "pnlSignOut";
            this.pnlSignOut.Size = new System.Drawing.Size(217, 57);
            this.pnlSignOut.TabIndex = 7;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnSignOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnSignOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Location = new System.Drawing.Point(-12, -19);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSignOut.Size = new System.Drawing.Size(235, 98);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "            Sign Out";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.UseVisualStyleBackColor = false;
            // 
            // containerInventory
            // 
            this.containerInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.containerInventory.Controls.Add(this.pnlReservation);
            this.containerInventory.Controls.Add(this.pnlMakeReservation);
            this.containerInventory.Controls.Add(this.pnlReservationStatus);
            this.containerInventory.ForeColor = System.Drawing.Color.White;
            this.containerInventory.Location = new System.Drawing.Point(0, 0);
            this.containerInventory.Margin = new System.Windows.Forms.Padding(0);
            this.containerInventory.Name = "containerInventory";
            this.containerInventory.Size = new System.Drawing.Size(217, 56);
            this.containerInventory.TabIndex = 8;
            // 
            // pnlReservation
            // 
            this.pnlReservation.Controls.Add(this.btnInventory);
            this.pnlReservation.Location = new System.Drawing.Point(0, 0);
            this.pnlReservation.Margin = new System.Windows.Forms.Padding(0);
            this.pnlReservation.Name = "pnlReservation";
            this.pnlReservation.Size = new System.Drawing.Size(217, 57);
            this.pnlReservation.TabIndex = 8;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(-12, -19);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(0);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(246, 98);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "            Inventory and Pricing";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // pnlMakeReservation
            // 
            this.pnlMakeReservation.Controls.Add(this.btnAddMenuItem);
            this.pnlMakeReservation.Location = new System.Drawing.Point(0, 57);
            this.pnlMakeReservation.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMakeReservation.Name = "pnlMakeReservation";
            this.pnlMakeReservation.Size = new System.Drawing.Size(217, 57);
            this.pnlMakeReservation.TabIndex = 9;
            // 
            // btnAddMenuItem
            // 
            this.btnAddMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.btnAddMenuItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnAddMenuItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAddMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMenuItem.ForeColor = System.Drawing.Color.White;
            this.btnAddMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMenuItem.Image")));
            this.btnAddMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMenuItem.Location = new System.Drawing.Point(-12, -19);
            this.btnAddMenuItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddMenuItem.Name = "btnAddMenuItem";
            this.btnAddMenuItem.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddMenuItem.Size = new System.Drawing.Size(235, 98);
            this.btnAddMenuItem.TabIndex = 5;
            this.btnAddMenuItem.Text = "            Add Menu Item";
            this.btnAddMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMenuItem.UseVisualStyleBackColor = false;
            this.btnAddMenuItem.Click += new System.EventHandler(this.btnAddMenuItem_Click);
            // 
            // pnlReservationStatus
            // 
            this.pnlReservationStatus.Controls.Add(this.btnEditItems);
            this.pnlReservationStatus.Location = new System.Drawing.Point(0, 114);
            this.pnlReservationStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnlReservationStatus.Name = "pnlReservationStatus";
            this.pnlReservationStatus.Size = new System.Drawing.Size(217, 57);
            this.pnlReservationStatus.TabIndex = 10;
            // 
            // btnEditItems
            // 
            this.btnEditItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.btnEditItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnEditItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEditItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditItems.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItems.ForeColor = System.Drawing.Color.White;
            this.btnEditItems.Image = ((System.Drawing.Image)(resources.GetObject("btnEditItems.Image")));
            this.btnEditItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditItems.Location = new System.Drawing.Point(-12, -19);
            this.btnEditItems.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditItems.Name = "btnEditItems";
            this.btnEditItems.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnEditItems.Size = new System.Drawing.Size(235, 98);
            this.btnEditItems.TabIndex = 5;
            this.btnEditItems.Text = "            Edit Items";
            this.btnEditItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditItems.UseVisualStyleBackColor = false;
            this.btnEditItems.Click += new System.EventHandler(this.btnEditItems_Click);
            // 
            // containerAccount
            // 
            this.containerAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.containerAccount.Controls.Add(this.pnlAccount);
            this.containerAccount.Controls.Add(this.pnlPersonalInfo);
            this.containerAccount.Controls.Add(this.pnlSecurity);
            this.containerAccount.ForeColor = System.Drawing.Color.White;
            this.containerAccount.Location = new System.Drawing.Point(0, 169);
            this.containerAccount.Margin = new System.Windows.Forms.Padding(0);
            this.containerAccount.Name = "containerAccount";
            this.containerAccount.Size = new System.Drawing.Size(217, 56);
            this.containerAccount.TabIndex = 12;
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.btnAccount);
            this.pnlAccount.Location = new System.Drawing.Point(0, 0);
            this.pnlAccount.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(217, 57);
            this.pnlAccount.TabIndex = 8;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(-12, -19);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(246, 98);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "            Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // pnlPersonalInfo
            // 
            this.pnlPersonalInfo.Controls.Add(this.btnPersonalInfo);
            this.pnlPersonalInfo.Location = new System.Drawing.Point(0, 57);
            this.pnlPersonalInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPersonalInfo.Name = "pnlPersonalInfo";
            this.pnlPersonalInfo.Size = new System.Drawing.Size(217, 57);
            this.pnlPersonalInfo.TabIndex = 9;
            // 
            // btnPersonalInfo
            // 
            this.btnPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.btnPersonalInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnPersonalInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonalInfo.ForeColor = System.Drawing.Color.White;
            this.btnPersonalInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonalInfo.Image")));
            this.btnPersonalInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalInfo.Location = new System.Drawing.Point(-12, -19);
            this.btnPersonalInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnPersonalInfo.Name = "btnPersonalInfo";
            this.btnPersonalInfo.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPersonalInfo.Size = new System.Drawing.Size(235, 98);
            this.btnPersonalInfo.TabIndex = 5;
            this.btnPersonalInfo.Text = "            Personal Info";
            this.btnPersonalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalInfo.UseVisualStyleBackColor = false;
            this.btnPersonalInfo.Click += new System.EventHandler(this.btnPersonalInfo_Click);
            // 
            // pnlSecurity
            // 
            this.pnlSecurity.Controls.Add(this.btnSecurity);
            this.pnlSecurity.Location = new System.Drawing.Point(0, 114);
            this.pnlSecurity.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSecurity.Name = "pnlSecurity";
            this.pnlSecurity.Size = new System.Drawing.Size(217, 57);
            this.pnlSecurity.TabIndex = 10;
            // 
            // btnSecurity
            // 
            this.btnSecurity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.btnSecurity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnSecurity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecurity.ForeColor = System.Drawing.Color.White;
            this.btnSecurity.Image = ((System.Drawing.Image)(resources.GetObject("btnSecurity.Image")));
            this.btnSecurity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurity.Location = new System.Drawing.Point(-12, -19);
            this.btnSecurity.Margin = new System.Windows.Forms.Padding(0);
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSecurity.Size = new System.Drawing.Size(235, 98);
            this.btnSecurity.TabIndex = 5;
            this.btnSecurity.Text = "            Security";
            this.btnSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurity.UseVisualStyleBackColor = false;
            this.btnSecurity.Click += new System.EventHandler(this.btnSecurity_Click);
            // 
            // containerReports
            // 
            this.containerReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.containerReports.Controls.Add(this.pnlSendFeedback);
            this.containerReports.Controls.Add(this.pnlReservationFeedback);
            this.containerReports.Controls.Add(this.pnlMenuFeedback);
            this.containerReports.ForeColor = System.Drawing.Color.White;
            this.containerReports.Location = new System.Drawing.Point(0, 113);
            this.containerReports.Margin = new System.Windows.Forms.Padding(0);
            this.containerReports.Name = "containerReports";
            this.containerReports.Size = new System.Drawing.Size(217, 56);
            this.containerReports.TabIndex = 11;
            // 
            // pnlSendFeedback
            // 
            this.pnlSendFeedback.Controls.Add(this.btnReports);
            this.pnlSendFeedback.Location = new System.Drawing.Point(0, 0);
            this.pnlSendFeedback.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSendFeedback.Name = "pnlSendFeedback";
            this.pnlSendFeedback.Size = new System.Drawing.Size(217, 57);
            this.pnlSendFeedback.TabIndex = 8;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(-12, -19);
            this.btnReports.Margin = new System.Windows.Forms.Padding(0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(246, 98);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "            Reports and Analytics";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // pnlReservationFeedback
            // 
            this.pnlReservationFeedback.Controls.Add(this.btnReservationsReports);
            this.pnlReservationFeedback.Location = new System.Drawing.Point(0, 57);
            this.pnlReservationFeedback.Margin = new System.Windows.Forms.Padding(0);
            this.pnlReservationFeedback.Name = "pnlReservationFeedback";
            this.pnlReservationFeedback.Size = new System.Drawing.Size(217, 57);
            this.pnlReservationFeedback.TabIndex = 10;
            // 
            // btnReservationsReports
            // 
            this.btnReservationsReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.btnReservationsReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnReservationsReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnReservationsReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationsReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationsReports.ForeColor = System.Drawing.Color.White;
            this.btnReservationsReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReservationsReports.Image")));
            this.btnReservationsReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservationsReports.Location = new System.Drawing.Point(-12, -19);
            this.btnReservationsReports.Margin = new System.Windows.Forms.Padding(0);
            this.btnReservationsReports.Name = "btnReservationsReports";
            this.btnReservationsReports.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReservationsReports.Size = new System.Drawing.Size(235, 98);
            this.btnReservationsReports.TabIndex = 5;
            this.btnReservationsReports.Text = "            Reservations Reports";
            this.btnReservationsReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservationsReports.UseVisualStyleBackColor = false;
            this.btnReservationsReports.Click += new System.EventHandler(this.btnReservationsReports_Click);
            // 
            // pnlMenuFeedback
            // 
            this.pnlMenuFeedback.Controls.Add(this.btnSaleReports);
            this.pnlMenuFeedback.Location = new System.Drawing.Point(0, 114);
            this.pnlMenuFeedback.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuFeedback.Name = "pnlMenuFeedback";
            this.pnlMenuFeedback.Size = new System.Drawing.Size(217, 57);
            this.pnlMenuFeedback.TabIndex = 9;
            // 
            // btnSaleReports
            // 
            this.btnSaleReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.btnSaleReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnSaleReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSaleReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleReports.ForeColor = System.Drawing.Color.White;
            this.btnSaleReports.Image = ((System.Drawing.Image)(resources.GetObject("btnSaleReports.Image")));
            this.btnSaleReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaleReports.Location = new System.Drawing.Point(-12, -19);
            this.btnSaleReports.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaleReports.Name = "btnSaleReports";
            this.btnSaleReports.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSaleReports.Size = new System.Drawing.Size(235, 98);
            this.btnSaleReports.TabIndex = 5;
            this.btnSaleReports.Text = "            Sales Reports";
            this.btnSaleReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaleReports.UseVisualStyleBackColor = false;
            this.btnSaleReports.Click += new System.EventHandler(this.btnSaleReports_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoScroll = true;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.pnlSidebar.Controls.Add(this.containerInventory);
            this.pnlSidebar.Controls.Add(this.pnlReservations);
            this.pnlSidebar.Controls.Add(this.containerReports);
            this.pnlSidebar.Controls.Add(this.containerAccount);
            this.pnlSidebar.Controls.Add(this.pnlSignOut);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 39);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(217, 589);
            this.pnlSidebar.TabIndex = 3;
            // 
            // dropdownReports
            // 
            this.dropdownReports.Interval = 10;
            this.dropdownReports.Tick += new System.EventHandler(this.dropdownReports_Tick);
            // 
            // dropdownAccount
            // 
            this.dropdownAccount.Interval = 10;
            this.dropdownAccount.Tick += new System.EventHandler(this.dropdownAccount_Tick);
            // 
            // transitionSidebar
            // 
            this.transitionSidebar.Interval = 10;
            this.transitionSidebar.Tick += new System.EventHandler(this.transitionSidebar_Tick);
            // 
            // dropdownInventory
            // 
            this.dropdownInventory.Interval = 10;
            this.dropdownInventory.Tick += new System.EventHandler(this.dropdownInventory_Tick);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(973, 628);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManager";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlControlBox.ResumeLayout(false);
            this.pnlReservations.ResumeLayout(false);
            this.pnlSignOut.ResumeLayout(false);
            this.containerInventory.ResumeLayout(false);
            this.pnlReservation.ResumeLayout(false);
            this.pnlMakeReservation.ResumeLayout(false);
            this.pnlReservationStatus.ResumeLayout(false);
            this.containerAccount.ResumeLayout(false);
            this.pnlAccount.ResumeLayout(false);
            this.pnlPersonalInfo.ResumeLayout(false);
            this.pnlSecurity.ResumeLayout(false);
            this.containerReports.ResumeLayout(false);
            this.pnlSendFeedback.ResumeLayout(false);
            this.pnlReservationFeedback.ResumeLayout(false);
            this.pnlMenuFeedback.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSidebar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlControlBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlReservations;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Panel pnlSignOut;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.FlowLayoutPanel containerInventory;
        private System.Windows.Forms.Panel pnlReservation;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel pnlMakeReservation;
        private System.Windows.Forms.Button btnAddMenuItem;
        private System.Windows.Forms.Panel pnlReservationStatus;
        private System.Windows.Forms.Button btnEditItems;
        private System.Windows.Forms.FlowLayoutPanel containerAccount;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel pnlPersonalInfo;
        private System.Windows.Forms.Button btnPersonalInfo;
        private System.Windows.Forms.Panel pnlSecurity;
        private System.Windows.Forms.Button btnSecurity;
        private System.Windows.Forms.FlowLayoutPanel containerReports;
        private System.Windows.Forms.Panel pnlSendFeedback;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel pnlReservationFeedback;
        private System.Windows.Forms.Button btnReservationsReports;
        private System.Windows.Forms.Panel pnlMenuFeedback;
        private System.Windows.Forms.Button btnSaleReports;
        private System.Windows.Forms.FlowLayoutPanel pnlSidebar;
        private System.Windows.Forms.Timer dropdownReports;
        private System.Windows.Forms.Timer dropdownAccount;
        private System.Windows.Forms.Timer transitionSidebar;
        private System.Windows.Forms.Timer dropdownInventory;
    }
}