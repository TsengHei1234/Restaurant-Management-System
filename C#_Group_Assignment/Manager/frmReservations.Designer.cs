namespace C__Group_Assignment
{
    partial class frmReservations
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReservations = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.pbWarning = new System.Windows.Forms.PictureBox();
            this.lblExistingReservations = new System.Windows.Forms.Label();
            this.btnSelectReservation = new System.Windows.Forms.Button();
            this.panelvenue = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnParty = new System.Windows.Forms.Button();
            this.btnGathering = new System.Windows.Forms.Button();
            this.btnBirthday = new System.Windows.Forms.Button();
            this.btnGraduation = new System.Windows.Forms.Button();
            this.pcParty = new System.Windows.Forms.PictureBox();
            this.pbGathering = new System.Windows.Forms.PictureBox();
            this.pbBirthday = new System.Windows.Forms.PictureBox();
            this.pbGraduation = new System.Windows.Forms.PictureBox();
            this.lbEditReservation = new System.Windows.Forms.ListBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cmbVenue = new System.Windows.Forms.ComboBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSetDate = new System.Windows.Forms.Label();
            this.numericGuest = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfGuests = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarning)).BeginInit();
            this.panelvenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcParty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGathering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraduation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblReservations);
            this.panel1.Controls.Add(this.pnlInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 140);
            this.panel1.TabIndex = 0;
            // 
            // lblReservations
            // 
            this.lblReservations.AutoSize = true;
            this.lblReservations.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservations.Location = new System.Drawing.Point(35, 50);
            this.lblReservations.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReservations.Name = "lblReservations";
            this.lblReservations.Size = new System.Drawing.Size(222, 46);
            this.lblReservations.TabIndex = 18;
            this.lblReservations.Text = "Reservations";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblTime);
            this.pnlInfo.Controls.Add(this.lblName);
            this.pnlInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.Location = new System.Drawing.Point(726, 0);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(341, 140);
            this.pnlInfo.TabIndex = 17;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(28, 107);
            this.lblTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(161, 16);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time: 21/5/2024 | 11.59PM";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(28, 12);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 46);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Welcome Back! \r\nUsername";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 414);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCurrent);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnDeleteReservation);
            this.panel3.Controls.Add(this.pbWarning);
            this.panel3.Controls.Add(this.lblExistingReservations);
            this.panel3.Controls.Add(this.btnSelectReservation);
            this.panel3.Controls.Add(this.panelvenue);
            this.panel3.Controls.Add(this.lbEditReservation);
            this.panel3.Controls.Add(this.lblCustomer);
            this.panel3.Controls.Add(this.cmbVenue);
            this.panel3.Controls.Add(this.lblVenue);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtCustomerID);
            this.panel3.Controls.Add(this.cmbTime);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.lblSetDate);
            this.panel3.Controls.Add(this.numericGuest);
            this.panel3.Controls.Add(this.lblNumberOfGuests);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 414);
            this.panel3.TabIndex = 0;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(546, 5);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(203, 25);
            this.lblCurrent.TabIndex = 45;
            this.lblCurrent.Text = "Adding New Reservation";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(41, 260);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 52);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.BackColor = System.Drawing.Color.LightGray;
            this.btnDeleteReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnDeleteReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDeleteReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteReservation.Location = new System.Drawing.Point(94, 336);
            this.btnDeleteReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(149, 32);
            this.btnDeleteReservation.TabIndex = 43;
            this.btnDeleteReservation.Text = "Reject";
            this.btnDeleteReservation.UseVisualStyleBackColor = false;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // pbWarning
            // 
            this.pbWarning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbWarning.Image = global::C__Group_Assignment.Properties.Resources.caution_danger_sign_free_vector_removebg_preview1;
            this.pbWarning.Location = new System.Drawing.Point(41, 329);
            this.pbWarning.Margin = new System.Windows.Forms.Padding(4);
            this.pbWarning.Name = "pbWarning";
            this.pbWarning.Size = new System.Drawing.Size(49, 39);
            this.pbWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWarning.TabIndex = 42;
            this.pbWarning.TabStop = false;
            // 
            // lblExistingReservations
            // 
            this.lblExistingReservations.AutoSize = true;
            this.lblExistingReservations.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistingReservations.Location = new System.Drawing.Point(39, 40);
            this.lblExistingReservations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExistingReservations.Name = "lblExistingReservations";
            this.lblExistingReservations.Size = new System.Drawing.Size(172, 23);
            this.lblExistingReservations.TabIndex = 41;
            this.lblExistingReservations.Text = "Existing Reservations";
            // 
            // btnSelectReservation
            // 
            this.btnSelectReservation.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSelectReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnSelectReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSelectReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectReservation.Location = new System.Drawing.Point(149, 260);
            this.btnSelectReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectReservation.Name = "btnSelectReservation";
            this.btnSelectReservation.Size = new System.Drawing.Size(108, 52);
            this.btnSelectReservation.TabIndex = 40;
            this.btnSelectReservation.Text = "Select";
            this.btnSelectReservation.UseVisualStyleBackColor = false;
            this.btnSelectReservation.Click += new System.EventHandler(this.btnSelectReservation_Click);
            // 
            // panelvenue
            // 
            this.panelvenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelvenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelvenue.Controls.Add(this.label2);
            this.panelvenue.Controls.Add(this.btnParty);
            this.panelvenue.Controls.Add(this.btnGathering);
            this.panelvenue.Controls.Add(this.btnBirthday);
            this.panelvenue.Controls.Add(this.btnGraduation);
            this.panelvenue.Controls.Add(this.pcParty);
            this.panelvenue.Controls.Add(this.pbGathering);
            this.panelvenue.Controls.Add(this.pbBirthday);
            this.panelvenue.Controls.Add(this.pbGraduation);
            this.panelvenue.Location = new System.Drawing.Point(306, 176);
            this.panelvenue.Name = "panelvenue";
            this.panelvenue.Size = new System.Drawing.Size(666, 226);
            this.panelvenue.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Click On Reservation Type To Save/Edit";
            // 
            // btnParty
            // 
            this.btnParty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnParty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnParty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParty.Location = new System.Drawing.Point(510, 151);
            this.btnParty.Margin = new System.Windows.Forms.Padding(4);
            this.btnParty.Name = "btnParty";
            this.btnParty.Size = new System.Drawing.Size(129, 48);
            this.btnParty.TabIndex = 23;
            this.btnParty.Text = "Party";
            this.btnParty.UseVisualStyleBackColor = false;
            this.btnParty.Click += new System.EventHandler(this.btnParty_Click);
            // 
            // btnGathering
            // 
            this.btnGathering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnGathering.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnGathering.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnGathering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGathering.Location = new System.Drawing.Point(347, 151);
            this.btnGathering.Margin = new System.Windows.Forms.Padding(4);
            this.btnGathering.Name = "btnGathering";
            this.btnGathering.Size = new System.Drawing.Size(129, 48);
            this.btnGathering.TabIndex = 22;
            this.btnGathering.Text = "Gathering";
            this.btnGathering.UseVisualStyleBackColor = false;
            this.btnGathering.Click += new System.EventHandler(this.btnGathering_Click);
            // 
            // btnBirthday
            // 
            this.btnBirthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnBirthday.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnBirthday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnBirthday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBirthday.Location = new System.Drawing.Point(183, 151);
            this.btnBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.btnBirthday.Name = "btnBirthday";
            this.btnBirthday.Size = new System.Drawing.Size(130, 48);
            this.btnBirthday.TabIndex = 21;
            this.btnBirthday.Text = "Birthday";
            this.btnBirthday.UseVisualStyleBackColor = false;
            this.btnBirthday.Click += new System.EventHandler(this.btnBirthday_Click);
            // 
            // btnGraduation
            // 
            this.btnGraduation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnGraduation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnGraduation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnGraduation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraduation.Location = new System.Drawing.Point(19, 151);
            this.btnGraduation.Margin = new System.Windows.Forms.Padding(4);
            this.btnGraduation.Name = "btnGraduation";
            this.btnGraduation.Size = new System.Drawing.Size(130, 48);
            this.btnGraduation.TabIndex = 20;
            this.btnGraduation.Text = "Graduation";
            this.btnGraduation.UseVisualStyleBackColor = false;
            this.btnGraduation.Click += new System.EventHandler(this.btnGraduation_Click);
            // 
            // pcParty
            // 
            this.pcParty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcParty.Image = global::C__Group_Assignment.Properties.Resources.R;
            this.pcParty.Location = new System.Drawing.Point(510, 33);
            this.pcParty.Margin = new System.Windows.Forms.Padding(4);
            this.pcParty.Name = "pcParty";
            this.pcParty.Size = new System.Drawing.Size(129, 123);
            this.pcParty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcParty.TabIndex = 3;
            this.pcParty.TabStop = false;
            // 
            // pbGathering
            // 
            this.pbGathering.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGathering.Image = global::C__Group_Assignment.Properties.Resources.Gathering_with_Family;
            this.pbGathering.Location = new System.Drawing.Point(347, 33);
            this.pbGathering.Margin = new System.Windows.Forms.Padding(4);
            this.pbGathering.Name = "pbGathering";
            this.pbGathering.Size = new System.Drawing.Size(129, 123);
            this.pbGathering.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGathering.TabIndex = 2;
            this.pbGathering.TabStop = false;
            // 
            // pbBirthday
            // 
            this.pbBirthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBirthday.Image = global::C__Group_Assignment.Properties.Resources.iStock_918933880;
            this.pbBirthday.Location = new System.Drawing.Point(183, 33);
            this.pbBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.pbBirthday.Name = "pbBirthday";
            this.pbBirthday.Size = new System.Drawing.Size(130, 123);
            this.pbBirthday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBirthday.TabIndex = 1;
            this.pbBirthday.TabStop = false;
            // 
            // pbGraduation
            // 
            this.pbGraduation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGraduation.Image = global::C__Group_Assignment.Properties.Resources.Grduation_Party;
            this.pbGraduation.Location = new System.Drawing.Point(19, 33);
            this.pbGraduation.Margin = new System.Windows.Forms.Padding(4);
            this.pbGraduation.Name = "pbGraduation";
            this.pbGraduation.Size = new System.Drawing.Size(130, 123);
            this.pbGraduation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGraduation.TabIndex = 0;
            this.pbGraduation.TabStop = false;
            // 
            // lbEditReservation
            // 
            this.lbEditReservation.FormattingEnabled = true;
            this.lbEditReservation.ItemHeight = 21;
            this.lbEditReservation.Location = new System.Drawing.Point(41, 68);
            this.lbEditReservation.Margin = new System.Windows.Forms.Padding(4);
            this.lbEditReservation.Name = "lbEditReservation";
            this.lbEditReservation.Size = new System.Drawing.Size(216, 193);
            this.lbEditReservation.TabIndex = 39;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(302, 111);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(101, 23);
            this.lblCustomer.TabIndex = 36;
            this.lblCustomer.Text = "CustomerID";
            // 
            // cmbVenue
            // 
            this.cmbVenue.FormattingEnabled = true;
            this.cmbVenue.Location = new System.Drawing.Point(826, 128);
            this.cmbVenue.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVenue.Name = "cmbVenue";
            this.cmbVenue.Size = new System.Drawing.Size(152, 29);
            this.cmbVenue.TabIndex = 35;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(822, 101);
            this.lblVenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(87, 23);
            this.lblVenue.TabIndex = 34;
            this.lblVenue.Text = "Set Venue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(822, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Set Time";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(306, 138);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(318, 29);
            this.txtCustomerID.TabIndex = 31;
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(826, 68);
            this.cmbTime.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(158, 29);
            this.cmbTime.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(501, 68);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 29);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // lblSetDate
            // 
            this.lblSetDate.AutoSize = true;
            this.lblSetDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetDate.Location = new System.Drawing.Point(497, 40);
            this.lblSetDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSetDate.Name = "lblSetDate";
            this.lblSetDate.Size = new System.Drawing.Size(75, 23);
            this.lblSetDate.TabIndex = 26;
            this.lblSetDate.Text = "Set Date";
            // 
            // numericGuest
            // 
            this.numericGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.numericGuest.Location = new System.Drawing.Point(306, 65);
            this.numericGuest.Margin = new System.Windows.Forms.Padding(4);
            this.numericGuest.Name = "numericGuest";
            this.numericGuest.Size = new System.Drawing.Size(157, 29);
            this.numericGuest.TabIndex = 25;
            // 
            // lblNumberOfGuests
            // 
            this.lblNumberOfGuests.AutoSize = true;
            this.lblNumberOfGuests.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfGuests.Location = new System.Drawing.Point(302, 40);
            this.lblNumberOfGuests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfGuests.Name = "lblNumberOfGuests";
            this.lblNumberOfGuests.Size = new System.Drawing.Size(153, 23);
            this.lblNumberOfGuests.TabIndex = 24;
            this.lblNumberOfGuests.Text = "Number Of Guests";
            // 
            // frmReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReservations";
            this.Text = "frmReservations";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarning)).EndInit();
            this.panelvenue.ResumeLayout(false);
            this.panelvenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcParty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGathering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraduation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGuest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReservations;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbGraduation;
        private System.Windows.Forms.PictureBox pcParty;
        private System.Windows.Forms.PictureBox pbGathering;
        private System.Windows.Forms.PictureBox pbBirthday;
        private System.Windows.Forms.Button btnGraduation;
        private System.Windows.Forms.Button btnParty;
        private System.Windows.Forms.Button btnGathering;
        private System.Windows.Forms.Button btnBirthday;
        private System.Windows.Forms.NumericUpDown numericGuest;
        private System.Windows.Forms.Label lblNumberOfGuests;
        private System.Windows.Forms.Label lblSetDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVenue;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Panel panelvenue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectReservation;
        private System.Windows.Forms.ListBox lbEditReservation;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.PictureBox pbWarning;
        private System.Windows.Forms.Label lblExistingReservations;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCurrent;
    }
}