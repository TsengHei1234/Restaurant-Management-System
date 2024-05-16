namespace C__Group_Assignment
{
    partial class frmChef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChef));
            this.pnlControlBox = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnSidebar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlViewUpdateOrder = new System.Windows.Forms.Panel();
            this.btnViewUpdateOrder = new System.Windows.Forms.Button();
            this.pnlManageInventory = new System.Windows.Forms.Panel();
            this.btnManageInventory = new System.Windows.Forms.Button();
            this.containerAccount = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.pnlPersonalInfo = new System.Windows.Forms.Panel();
            this.btnPersonalInfo = new System.Windows.Forms.Button();
            this.pnlSecurity = new System.Windows.Forms.Panel();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.pnlSignOut = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.transitionSidebar = new System.Windows.Forms.Timer(this.components);
            this.dropdownAccount = new System.Windows.Forms.Timer(this.components);
            this.pnlControlBox.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlViewUpdateOrder.SuspendLayout();
            this.pnlManageInventory.SuspendLayout();
            this.containerAccount.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            this.pnlPersonalInfo.SuspendLayout();
            this.pnlSecurity.SuspendLayout();
            this.pnlSignOut.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chef Page";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoScroll = true;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.pnlSidebar.Controls.Add(this.pnlViewUpdateOrder);
            this.pnlSidebar.Controls.Add(this.pnlManageInventory);
            this.pnlSidebar.Controls.Add(this.containerAccount);
            this.pnlSidebar.Controls.Add(this.pnlSignOut);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 39);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 589);
            this.pnlSidebar.TabIndex = 2;
            // 
            // pnlViewUpdateOrder
            // 
            this.pnlViewUpdateOrder.Controls.Add(this.btnViewUpdateOrder);
            this.pnlViewUpdateOrder.Location = new System.Drawing.Point(0, 0);
            this.pnlViewUpdateOrder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlViewUpdateOrder.Name = "pnlViewUpdateOrder";
            this.pnlViewUpdateOrder.Size = new System.Drawing.Size(200, 57);
            this.pnlViewUpdateOrder.TabIndex = 6;
            // 
            // btnViewUpdateOrder
            // 
            this.btnViewUpdateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnViewUpdateOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnViewUpdateOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnViewUpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUpdateOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUpdateOrder.ForeColor = System.Drawing.Color.White;
            this.btnViewUpdateOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnViewUpdateOrder.Image")));
            this.btnViewUpdateOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewUpdateOrder.Location = new System.Drawing.Point(-12, -19);
            this.btnViewUpdateOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewUpdateOrder.Name = "btnViewUpdateOrder";
            this.btnViewUpdateOrder.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnViewUpdateOrder.Size = new System.Drawing.Size(235, 98);
            this.btnViewUpdateOrder.TabIndex = 5;
            this.btnViewUpdateOrder.Text = "            View/Update Order";
            this.btnViewUpdateOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewUpdateOrder.UseVisualStyleBackColor = false;
            this.btnViewUpdateOrder.Click += new System.EventHandler(this.btnViewUpdateOrder_Click);
            // 
            // pnlManageInventory
            // 
            this.pnlManageInventory.Controls.Add(this.btnManageInventory);
            this.pnlManageInventory.Location = new System.Drawing.Point(0, 57);
            this.pnlManageInventory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlManageInventory.Name = "pnlManageInventory";
            this.pnlManageInventory.Size = new System.Drawing.Size(200, 57);
            this.pnlManageInventory.TabIndex = 7;
            // 
            // btnManageInventory
            // 
            this.btnManageInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnManageInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnManageInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnManageInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageInventory.ForeColor = System.Drawing.Color.White;
            this.btnManageInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnManageInventory.Image")));
            this.btnManageInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageInventory.Location = new System.Drawing.Point(-12, -19);
            this.btnManageInventory.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageInventory.Name = "btnManageInventory";
            this.btnManageInventory.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnManageInventory.Size = new System.Drawing.Size(235, 98);
            this.btnManageInventory.TabIndex = 5;
            this.btnManageInventory.Text = "            Manage Inventory";
            this.btnManageInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageInventory.UseVisualStyleBackColor = false;
            this.btnManageInventory.Click += new System.EventHandler(this.btnManageInventory_Click);
            // 
            // containerAccount
            // 
            this.containerAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.containerAccount.Controls.Add(this.pnlAccount);
            this.containerAccount.Controls.Add(this.pnlPersonalInfo);
            this.containerAccount.Controls.Add(this.pnlSecurity);
            this.containerAccount.ForeColor = System.Drawing.Color.White;
            this.containerAccount.Location = new System.Drawing.Point(0, 114);
            this.containerAccount.Margin = new System.Windows.Forms.Padding(0);
            this.containerAccount.Name = "containerAccount";
            this.containerAccount.Size = new System.Drawing.Size(200, 56);
            this.containerAccount.TabIndex = 13;
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.btnAccount);
            this.pnlAccount.Location = new System.Drawing.Point(0, 0);
            this.pnlAccount.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(200, 57);
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
            this.pnlPersonalInfo.Size = new System.Drawing.Size(200, 57);
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
            this.pnlSecurity.Size = new System.Drawing.Size(200, 57);
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
            // pnlSignOut
            // 
            this.pnlSignOut.Controls.Add(this.btnSignOut);
            this.pnlSignOut.Location = new System.Drawing.Point(0, 170);
            this.pnlSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSignOut.Name = "pnlSignOut";
            this.pnlSignOut.Size = new System.Drawing.Size(200, 57);
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
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 39);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(773, 589);
            this.pnlMain.TabIndex = 3;
            // 
            // transitionSidebar
            // 
            this.transitionSidebar.Interval = 10;
            this.transitionSidebar.Tick += new System.EventHandler(this.transitionSidebar_Tick);
            // 
            // dropdownAccount
            // 
            this.dropdownAccount.Interval = 10;
            this.dropdownAccount.Tick += new System.EventHandler(this.dropdownAccount_Tick);
            // 
            // frmChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(973, 628);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChef";
            this.pnlControlBox.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlViewUpdateOrder.ResumeLayout(false);
            this.pnlManageInventory.ResumeLayout(false);
            this.containerAccount.ResumeLayout(false);
            this.pnlAccount.ResumeLayout(false);
            this.pnlPersonalInfo.ResumeLayout(false);
            this.pnlSecurity.ResumeLayout(false);
            this.pnlSignOut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControlBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnSidebar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlSidebar;
        private System.Windows.Forms.Panel pnlViewUpdateOrder;
        private System.Windows.Forms.Button btnViewUpdateOrder;
        private System.Windows.Forms.Panel pnlManageInventory;
        private System.Windows.Forms.Button btnManageInventory;
        private System.Windows.Forms.Panel pnlSignOut;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Timer transitionSidebar;
        private System.Windows.Forms.FlowLayoutPanel containerAccount;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel pnlPersonalInfo;
        private System.Windows.Forms.Button btnPersonalInfo;
        private System.Windows.Forms.Panel pnlSecurity;
        private System.Windows.Forms.Button btnSecurity;
        private System.Windows.Forms.Timer dropdownAccount;
    }
}