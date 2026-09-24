namespace C__Group_Assignment
{
    partial class frmDineInMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDineInMethod));
            this.pnlReservationDetails = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblReservationVenue = new System.Windows.Forms.Label();
            this.lblReservationNumber = new System.Windows.Forms.Label();
            this.lblReservationType = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.cmbReservationDates = new System.Windows.Forms.ComboBox();
            this.btnChooseReservation = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblReservationDetails = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChooseTable = new System.Windows.Forms.Button();
            this.lblSelectTable = new System.Windows.Forms.Label();
            this.cmbTableNumber = new System.Windows.Forms.ComboBox();
            this.btnReservation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWalkIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.transitionReservationDetails = new System.Windows.Forms.Timer(this.components);
            this.pnlReservationDetails.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReservationDetails
            // 
            this.pnlReservationDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReservationDetails.Controls.Add(this.label10);
            this.pnlReservationDetails.Controls.Add(this.lblReservationVenue);
            this.pnlReservationDetails.Controls.Add(this.lblReservationNumber);
            this.pnlReservationDetails.Controls.Add(this.lblReservationType);
            this.pnlReservationDetails.Controls.Add(this.lblReservationID);
            this.pnlReservationDetails.Controls.Add(this.cmbReservationDates);
            this.pnlReservationDetails.Controls.Add(this.btnChooseReservation);
            this.pnlReservationDetails.Controls.Add(this.label12);
            this.pnlReservationDetails.Controls.Add(this.panel4);
            this.pnlReservationDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlReservationDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlReservationDetails.Name = "pnlReservationDetails";
            this.pnlReservationDetails.Size = new System.Drawing.Size(0, 628);
            this.pnlReservationDetails.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-260, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Details";
            // 
            // lblReservationVenue
            // 
            this.lblReservationVenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReservationVenue.AutoSize = true;
            this.lblReservationVenue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationVenue.Location = new System.Drawing.Point(-260, 257);
            this.lblReservationVenue.Name = "lblReservationVenue";
            this.lblReservationVenue.Size = new System.Drawing.Size(141, 20);
            this.lblReservationVenue.TabIndex = 46;
            this.lblReservationVenue.Text = "Reservation Venue:";
            // 
            // lblReservationNumber
            // 
            this.lblReservationNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReservationNumber.AutoSize = true;
            this.lblReservationNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationNumber.Location = new System.Drawing.Point(-260, 297);
            this.lblReservationNumber.Name = "lblReservationNumber";
            this.lblReservationNumber.Size = new System.Drawing.Size(138, 20);
            this.lblReservationNumber.TabIndex = 45;
            this.lblReservationNumber.Text = "Number of People:";
            // 
            // lblReservationType
            // 
            this.lblReservationType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReservationType.AutoSize = true;
            this.lblReservationType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationType.Location = new System.Drawing.Point(-260, 217);
            this.lblReservationType.Name = "lblReservationType";
            this.lblReservationType.Size = new System.Drawing.Size(130, 20);
            this.lblReservationType.TabIndex = 44;
            this.lblReservationType.Text = "Reservation Type:";
            // 
            // lblReservationID
            // 
            this.lblReservationID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationID.Location = new System.Drawing.Point(-260, 177);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(113, 20);
            this.lblReservationID.TabIndex = 43;
            this.lblReservationID.Text = "Reservation ID:";
            // 
            // cmbReservationDates
            // 
            this.cmbReservationDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReservationDates.FormattingEnabled = true;
            this.cmbReservationDates.Items.AddRange(new object[] {
            "2023-12-29 23:59:59",
            "2023-12-30 23:59:59",
            "2023-12-31 23:59:59"});
            this.cmbReservationDates.Location = new System.Drawing.Point(-258, 89);
            this.cmbReservationDates.Name = "cmbReservationDates";
            this.cmbReservationDates.Size = new System.Drawing.Size(197, 21);
            this.cmbReservationDates.TabIndex = 42;
            this.cmbReservationDates.Text = "Select your datetime...";
            this.cmbReservationDates.SelectedIndexChanged += new System.EventHandler(this.cmbReservationDates_SelectedIndexChanged);
            // 
            // btnChooseReservation
            // 
            this.btnChooseReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnChooseReservation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChooseReservation.FlatAppearance.BorderSize = 0;
            this.btnChooseReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnChooseReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnChooseReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseReservation.ForeColor = System.Drawing.Color.Black;
            this.btnChooseReservation.Location = new System.Drawing.Point(-256, 350);
            this.btnChooseReservation.Name = "btnChooseReservation";
            this.btnChooseReservation.Size = new System.Drawing.Size(224, 49);
            this.btnChooseReservation.TabIndex = 41;
            this.btnChooseReservation.Text = "Choose Reservation";
            this.btnChooseReservation.UseVisualStyleBackColor = false;
            this.btnChooseReservation.Click += new System.EventHandler(this.btnChooseReservation_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-262, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 21);
            this.label12.TabIndex = 40;
            this.label12.Text = "Choose Reservation Date";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.lblReservationDetails);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 34);
            this.panel4.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(-47, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 32);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblReservationDetails
            // 
            this.lblReservationDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReservationDetails.AutoSize = true;
            this.lblReservationDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationDetails.Location = new System.Drawing.Point(-267, 6);
            this.lblReservationDetails.Name = "lblReservationDetails";
            this.lblReservationDetails.Size = new System.Drawing.Size(158, 21);
            this.lblReservationDetails.TabIndex = 16;
            this.lblReservationDetails.Text = "Reservation Details";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChooseTable);
            this.panel1.Controls.Add(this.lblSelectTable);
            this.panel1.Controls.Add(this.cmbTableNumber);
            this.panel1.Controls.Add(this.btnReservation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnWalkIn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 628);
            this.panel1.TabIndex = 74;
            // 
            // btnChooseTable
            // 
            this.btnChooseTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnChooseTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseTable.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseTable.Location = new System.Drawing.Point(669, 328);
            this.btnChooseTable.Name = "btnChooseTable";
            this.btnChooseTable.Size = new System.Drawing.Size(104, 27);
            this.btnChooseTable.TabIndex = 14;
            this.btnChooseTable.Text = "Choose Table";
            this.btnChooseTable.UseVisualStyleBackColor = false;
            this.btnChooseTable.Visible = false;
            this.btnChooseTable.Click += new System.EventHandler(this.btnChooseTable_Click);
            // 
            // lblSelectTable
            // 
            this.lblSelectTable.AutoSize = true;
            this.lblSelectTable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTable.Location = new System.Drawing.Point(623, 260);
            this.lblSelectTable.Name = "lblSelectTable";
            this.lblSelectTable.Size = new System.Drawing.Size(203, 21);
            this.lblSelectTable.TabIndex = 13;
            this.lblSelectTable.Text = "Select your Table Number:";
            this.lblSelectTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSelectTable.Visible = false;
            // 
            // cmbTableNumber
            // 
            this.cmbTableNumber.FormattingEnabled = true;
            this.cmbTableNumber.Location = new System.Drawing.Point(660, 294);
            this.cmbTableNumber.Name = "cmbTableNumber";
            this.cmbTableNumber.Size = new System.Drawing.Size(121, 21);
            this.cmbTableNumber.TabIndex = 12;
            this.cmbTableNumber.Text = "Choose here...";
            this.cmbTableNumber.Visible = false;
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.Location = new System.Drawing.Point(360, 403);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(224, 48);
            this.btnReservation.TabIndex = 11;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "OR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWalkIn
            // 
            this.btnWalkIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnWalkIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWalkIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWalkIn.Location = new System.Drawing.Point(360, 279);
            this.btnWalkIn.Name = "btnWalkIn";
            this.btnWalkIn.Size = new System.Drawing.Size(224, 48);
            this.btnWalkIn.TabIndex = 9;
            this.btnWalkIn.Text = "Walk-In";
            this.btnWalkIn.UseVisualStyleBackColor = false;
            this.btnWalkIn.Click += new System.EventHandler(this.btnWalkIn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please choose your Dine-in Method";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(194, 140);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(556, 33);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Welcome Back Name Name Name Name Name";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transitionReservationDetails
            // 
            this.transitionReservationDetails.Interval = 10;
            this.transitionReservationDetails.Tick += new System.EventHandler(this.transitionReservationDetails_Tick);
            // 
            // frmDineInMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlReservationDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDineInMethod";
            this.Text = "frmDineInMethod";
            this.Load += new System.EventHandler(this.frmDineInMethod_Load);
            this.pnlReservationDetails.ResumeLayout(false);
            this.pnlReservationDetails.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReservationDetails;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblReservationDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnWalkIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Timer transitionReservationDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblReservationVenue;
        private System.Windows.Forms.Label lblReservationNumber;
        private System.Windows.Forms.Label lblReservationType;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.ComboBox cmbReservationDates;
        private System.Windows.Forms.Button btnChooseReservation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSelectTable;
        private System.Windows.Forms.ComboBox cmbTableNumber;
        private System.Windows.Forms.Button btnChooseTable;
    }
}