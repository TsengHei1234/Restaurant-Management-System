namespace C__Group_Assignment
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlControlBox = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnSidebar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlViewOrder = new System.Windows.Forms.Panel();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.containerReservation = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlReservation = new System.Windows.Forms.Panel();
            this.btnReservation = new System.Windows.Forms.Button();
            this.pnlMakeReservation = new System.Windows.Forms.Panel();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.pnlReservationStatus = new System.Windows.Forms.Panel();
            this.btnReservationStatus = new System.Windows.Forms.Button();
            this.containerFeedback = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSendFeedback = new System.Windows.Forms.Panel();
            this.btnSendFeedback = new System.Windows.Forms.Button();
            this.pnlReservationFeedback = new System.Windows.Forms.Panel();
            this.btnReservationFeedback = new System.Windows.Forms.Button();
            this.pnlMenuFeedback = new System.Windows.Forms.Panel();
            this.btnMenuFeedback = new System.Windows.Forms.Button();
            this.containerAccount = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.pnlPersonalInfo = new System.Windows.Forms.Panel();
            this.btnPersonalInfo = new System.Windows.Forms.Button();
            this.pnlSecurity = new System.Windows.Forms.Panel();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.pnlSignOut = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.dropdownFeedback = new System.Windows.Forms.Timer(this.components);
            this.dropdownAccount = new System.Windows.Forms.Timer(this.components);
            this.dropdownReservation = new System.Windows.Forms.Timer(this.components);
            this.transitionSidebar = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlControlBox.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlViewOrder.SuspendLayout();
            this.containerReservation.SuspendLayout();
            this.pnlReservation.SuspendLayout();
            this.pnlMakeReservation.SuspendLayout();
            this.pnlReservationStatus.SuspendLayout();
            this.containerFeedback.SuspendLayout();
            this.pnlSendFeedback.SuspendLayout();
            this.pnlReservationFeedback.SuspendLayout();
            this.pnlMenuFeedback.SuspendLayout();
            this.containerAccount.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            this.pnlPersonalInfo.SuspendLayout();
            this.pnlSecurity.SuspendLayout();
            this.pnlSignOut.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlTop.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Page";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoScroll = true;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.pnlSidebar.Controls.Add(this.pnlMenu);
            this.pnlSidebar.Controls.Add(this.pnlViewOrder);
            this.pnlSidebar.Controls.Add(this.containerReservation);
            this.pnlSidebar.Controls.Add(this.containerFeedback);
            this.pnlSidebar.Controls.Add(this.containerAccount);
            this.pnlSidebar.Controls.Add(this.pnlSignOut);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 39);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 589);
            this.pnlSidebar.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 57);
            this.pnlMenu.TabIndex = 6;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(-12, -19);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(235, 98);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "            Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlViewOrder
            // 
            this.pnlViewOrder.Controls.Add(this.btnViewOrder);
            this.pnlViewOrder.Location = new System.Drawing.Point(0, 57);
            this.pnlViewOrder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlViewOrder.Name = "pnlViewOrder";
            this.pnlViewOrder.Size = new System.Drawing.Size(200, 57);
            this.pnlViewOrder.TabIndex = 7;
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnViewOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnViewOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.ForeColor = System.Drawing.Color.White;
            this.btnViewOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnViewOrder.Image")));
            this.btnViewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewOrder.Location = new System.Drawing.Point(-12, -19);
            this.btnViewOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnViewOrder.Size = new System.Drawing.Size(235, 98);
            this.btnViewOrder.TabIndex = 5;
            this.btnViewOrder.Text = "            View Order";
            this.btnViewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewOrder.UseVisualStyleBackColor = false;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // containerReservation
            // 
            this.containerReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.containerReservation.Controls.Add(this.pnlReservation);
            this.containerReservation.Controls.Add(this.pnlMakeReservation);
            this.containerReservation.Controls.Add(this.pnlReservationStatus);
            this.containerReservation.ForeColor = System.Drawing.Color.White;
            this.containerReservation.Location = new System.Drawing.Point(0, 114);
            this.containerReservation.Margin = new System.Windows.Forms.Padding(0);
            this.containerReservation.Name = "containerReservation";
            this.containerReservation.Size = new System.Drawing.Size(200, 56);
            this.containerReservation.TabIndex = 8;
            // 
            // pnlReservation
            // 
            this.pnlReservation.Controls.Add(this.btnReservation);
            this.pnlReservation.Location = new System.Drawing.Point(0, 0);
            this.pnlReservation.Margin = new System.Windows.Forms.Padding(0);
            this.pnlReservation.Name = "pnlReservation";
            this.pnlReservation.Size = new System.Drawing.Size(200, 57);
            this.pnlReservation.TabIndex = 8;
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnReservation.Image")));
            this.btnReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservation.Location = new System.Drawing.Point(-12, -19);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(0);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReservation.Size = new System.Drawing.Size(246, 98);
            this.btnReservation.TabIndex = 5;
            this.btnReservation.Text = "            Reservation";
            this.btnReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // pnlMakeReservation
            // 
            this.pnlMakeReservation.Controls.Add(this.btnMakeReservation);
            this.pnlMakeReservation.Location = new System.Drawing.Point(0, 57);
            this.pnlMakeReservation.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMakeReservation.Name = "pnlMakeReservation";
            this.pnlMakeReservation.Size = new System.Drawing.Size(200, 57);
            this.pnlMakeReservation.TabIndex = 9;
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.btnMakeReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnMakeReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMakeReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeReservation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReservation.ForeColor = System.Drawing.Color.White;
            this.btnMakeReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnMakeReservation.Image")));
            this.btnMakeReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMakeReservation.Location = new System.Drawing.Point(-12, -19);
            this.btnMakeReservation.Margin = new System.Windows.Forms.Padding(0);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMakeReservation.Size = new System.Drawing.Size(235, 98);
            this.btnMakeReservation.TabIndex = 5;
            this.btnMakeReservation.Text = "            Make Reservation";
            this.btnMakeReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMakeReservation.UseVisualStyleBackColor = false;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click);
            // 
            // pnlReservationStatus
            // 
            this.pnlReservationStatus.Controls.Add(this.btnReservationStatus);
            this.pnlReservationStatus.Location = new System.Drawing.Point(0, 114);
            this.pnlReservationStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnlReservationStatus.Name = "pnlReservationStatus";
            this.pnlReservationStatus.Size = new System.Drawing.Size(200, 57);
            this.pnlReservationStatus.TabIndex = 10;
            // 
            // btnReservationStatus
            // 
            this.btnReservationStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.btnReservationStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnReservationStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnReservationStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationStatus.ForeColor = System.Drawing.Color.White;
            this.btnReservationStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnReservationStatus.Image")));
            this.btnReservationStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservationStatus.Location = new System.Drawing.Point(-12, -19);
            this.btnReservationStatus.Margin = new System.Windows.Forms.Padding(0);
            this.btnReservationStatus.Name = "btnReservationStatus";
            this.btnReservationStatus.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReservationStatus.Size = new System.Drawing.Size(235, 98);
            this.btnReservationStatus.TabIndex = 5;
            this.btnReservationStatus.Text = "            Reservation Status";
            this.btnReservationStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservationStatus.UseVisualStyleBackColor = false;
            this.btnReservationStatus.Click += new System.EventHandler(this.btnReservationStatus_Click);
            // 
            // containerFeedback
            // 
            this.containerFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.containerFeedback.Controls.Add(this.pnlSendFeedback);
            this.containerFeedback.Controls.Add(this.pnlReservationFeedback);
            this.containerFeedback.Controls.Add(this.pnlMenuFeedback);
            this.containerFeedback.ForeColor = System.Drawing.Color.White;
            this.containerFeedback.Location = new System.Drawing.Point(0, 170);
            this.containerFeedback.Margin = new System.Windows.Forms.Padding(0);
            this.containerFeedback.Name = "containerFeedback";
            this.containerFeedback.Size = new System.Drawing.Size(200, 56);
            this.containerFeedback.TabIndex = 11;
            // 
            // pnlSendFeedback
            // 
            this.pnlSendFeedback.Controls.Add(this.btnSendFeedback);
            this.pnlSendFeedback.Location = new System.Drawing.Point(0, 0);
            this.pnlSendFeedback.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSendFeedback.Name = "pnlSendFeedback";
            this.pnlSendFeedback.Size = new System.Drawing.Size(200, 57);
            this.pnlSendFeedback.TabIndex = 8;
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnSendFeedback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnSendFeedback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSendFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendFeedback.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFeedback.ForeColor = System.Drawing.Color.White;
            this.btnSendFeedback.Image = ((System.Drawing.Image)(resources.GetObject("btnSendFeedback.Image")));
            this.btnSendFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendFeedback.Location = new System.Drawing.Point(-12, -19);
            this.btnSendFeedback.Margin = new System.Windows.Forms.Padding(0);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSendFeedback.Size = new System.Drawing.Size(246, 98);
            this.btnSendFeedback.TabIndex = 5;
            this.btnSendFeedback.Text = "            Send Feedback";
            this.btnSendFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendFeedback.UseVisualStyleBackColor = false;
            this.btnSendFeedback.Click += new System.EventHandler(this.btnSendFeedback_Click);
            // 
            // pnlReservationFeedback
            // 
            this.pnlReservationFeedback.Controls.Add(this.btnReservationFeedback);
            this.pnlReservationFeedback.Location = new System.Drawing.Point(0, 57);
            this.pnlReservationFeedback.Margin = new System.Windows.Forms.Padding(0);
            this.pnlReservationFeedback.Name = "pnlReservationFeedback";
            this.pnlReservationFeedback.Size = new System.Drawing.Size(200, 57);
            this.pnlReservationFeedback.TabIndex = 10;
            // 
            // btnReservationFeedback
            // 
            this.btnReservationFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.btnReservationFeedback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnReservationFeedback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnReservationFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationFeedback.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationFeedback.ForeColor = System.Drawing.Color.White;
            this.btnReservationFeedback.Image = ((System.Drawing.Image)(resources.GetObject("btnReservationFeedback.Image")));
            this.btnReservationFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservationFeedback.Location = new System.Drawing.Point(-12, -19);
            this.btnReservationFeedback.Margin = new System.Windows.Forms.Padding(0);
            this.btnReservationFeedback.Name = "btnReservationFeedback";
            this.btnReservationFeedback.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReservationFeedback.Size = new System.Drawing.Size(235, 98);
            this.btnReservationFeedback.TabIndex = 5;
            this.btnReservationFeedback.Text = "            Reservation";
            this.btnReservationFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservationFeedback.UseVisualStyleBackColor = false;
            this.btnReservationFeedback.Click += new System.EventHandler(this.btnReservationFeedback_Click);
            // 
            // pnlMenuFeedback
            // 
            this.pnlMenuFeedback.Controls.Add(this.btnMenuFeedback);
            this.pnlMenuFeedback.Location = new System.Drawing.Point(0, 114);
            this.pnlMenuFeedback.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuFeedback.Name = "pnlMenuFeedback";
            this.pnlMenuFeedback.Size = new System.Drawing.Size(200, 57);
            this.pnlMenuFeedback.TabIndex = 9;
            // 
            // btnMenuFeedback
            // 
            this.btnMenuFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.btnMenuFeedback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnMenuFeedback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMenuFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuFeedback.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuFeedback.ForeColor = System.Drawing.Color.White;
            this.btnMenuFeedback.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuFeedback.Image")));
            this.btnMenuFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuFeedback.Location = new System.Drawing.Point(-12, -19);
            this.btnMenuFeedback.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuFeedback.Name = "btnMenuFeedback";
            this.btnMenuFeedback.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMenuFeedback.Size = new System.Drawing.Size(235, 98);
            this.btnMenuFeedback.TabIndex = 5;
            this.btnMenuFeedback.Text = "            Menu Feedback";
            this.btnMenuFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuFeedback.UseVisualStyleBackColor = false;
            this.btnMenuFeedback.Click += new System.EventHandler(this.btnMenuFeedback_Click);
            // 
            // containerAccount
            // 
            this.containerAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.containerAccount.Controls.Add(this.pnlAccount);
            this.containerAccount.Controls.Add(this.pnlPersonalInfo);
            this.containerAccount.Controls.Add(this.pnlSecurity);
            this.containerAccount.ForeColor = System.Drawing.Color.White;
            this.containerAccount.Location = new System.Drawing.Point(0, 226);
            this.containerAccount.Margin = new System.Windows.Forms.Padding(0);
            this.containerAccount.Name = "containerAccount";
            this.containerAccount.Size = new System.Drawing.Size(200, 56);
            this.containerAccount.TabIndex = 12;
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
            this.pnlSignOut.Location = new System.Drawing.Point(0, 282);
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
            // dropdownFeedback
            // 
            this.dropdownFeedback.Interval = 10;
            this.dropdownFeedback.Tick += new System.EventHandler(this.dropdownFeedback_Tick);
            // 
            // dropdownAccount
            // 
            this.dropdownAccount.Interval = 10;
            this.dropdownAccount.Tick += new System.EventHandler(this.dropdownAccount_Tick);
            // 
            // dropdownReservation
            // 
            this.dropdownReservation.Interval = 10;
            this.dropdownReservation.Tick += new System.EventHandler(this.dropdownReservation_Tick);
            // 
            // transitionSidebar
            // 
            this.transitionSidebar.Interval = 10;
            this.transitionSidebar.Tick += new System.EventHandler(this.transitionSidebar_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 39);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(773, 589);
            this.pnlMain.TabIndex = 2;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(973, 628);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomer";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlControlBox.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlViewOrder.ResumeLayout(false);
            this.containerReservation.ResumeLayout(false);
            this.pnlReservation.ResumeLayout(false);
            this.pnlMakeReservation.ResumeLayout(false);
            this.pnlReservationStatus.ResumeLayout(false);
            this.containerFeedback.ResumeLayout(false);
            this.pnlSendFeedback.ResumeLayout(false);
            this.pnlReservationFeedback.ResumeLayout(false);
            this.pnlMenuFeedback.ResumeLayout(false);
            this.containerAccount.ResumeLayout(false);
            this.pnlAccount.ResumeLayout(false);
            this.pnlPersonalInfo.ResumeLayout(false);
            this.pnlSecurity.ResumeLayout(false);
            this.pnlSignOut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlSidebar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlViewOrder;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Panel pnlSignOut;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.FlowLayoutPanel containerReservation;
        private System.Windows.Forms.Panel pnlReservation;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Panel pnlMakeReservation;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Panel pnlReservationStatus;
        private System.Windows.Forms.Button btnReservationStatus;
        private System.Windows.Forms.FlowLayoutPanel containerFeedback;
        private System.Windows.Forms.Panel pnlSendFeedback;
        private System.Windows.Forms.Button btnSendFeedback;
        private System.Windows.Forms.Panel pnlMenuFeedback;
        private System.Windows.Forms.Button btnMenuFeedback;
        private System.Windows.Forms.Panel pnlReservationFeedback;
        private System.Windows.Forms.Button btnReservationFeedback;
        private System.Windows.Forms.FlowLayoutPanel containerAccount;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel pnlPersonalInfo;
        private System.Windows.Forms.Button btnPersonalInfo;
        private System.Windows.Forms.Panel pnlSecurity;
        private System.Windows.Forms.Button btnSecurity;
        private System.Windows.Forms.Timer dropdownFeedback;
        private System.Windows.Forms.Timer dropdownAccount;
        private System.Windows.Forms.Timer dropdownReservation;
        private System.Windows.Forms.Timer transitionSidebar;
        private System.Windows.Forms.Button btnSidebar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlControlBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
    }
}