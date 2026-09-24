namespace C__Group_Assignment
{
    partial class frmMakeReservation
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblMakeReservation = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblReservationDate = new System.Windows.Forms.Label();
            this.pnlReservation = new System.Windows.Forms.Panel();
            this.lblGraduation = new System.Windows.Forms.Label();
            this.picGraduation = new System.Windows.Forms.PictureBox();
            this.numPeople = new System.Windows.Forms.NumericUpDown();
            this.btnComfirmReservation = new System.Windows.Forms.Button();
            this.lblParty = new System.Windows.Forms.Label();
            this.lblGathering = new System.Windows.Forms.Label();
            this.picParty = new System.Windows.Forms.PictureBox();
            this.picGathering = new System.Windows.Forms.PictureBox();
            this.picBirthday = new System.Windows.Forms.PictureBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblChooseVenueType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbReservationTime = new System.Windows.Forms.ComboBox();
            this.lblReservationTime = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraduation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGathering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblMakeReservation);
            this.pnlTop.Controls.Add(this.pnlInfo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(973, 100);
            this.pnlTop.TabIndex = 8;
            // 
            // lblMakeReservation
            // 
            this.lblMakeReservation.AutoSize = true;
            this.lblMakeReservation.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeReservation.Location = new System.Drawing.Point(39, 33);
            this.lblMakeReservation.Name = "lblMakeReservation";
            this.lblMakeReservation.Size = new System.Drawing.Size(248, 37);
            this.lblMakeReservation.TabIndex = 16;
            this.lblMakeReservation.Text = "Make Reservation";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblStatus);
            this.pnlInfo.Controls.Add(this.lblTime);
            this.pnlInfo.Controls.Add(this.lblName);
            this.pnlInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.Location = new System.Drawing.Point(693, 0);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(278, 98);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(16, 51);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(173, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status: Reservation | Birthday Party";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(16, 71);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(139, 13);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time: 21/5/2024 | 11.59PM";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(16, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 38);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Welcome Back! \r\nUsername";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(57, 295);
            this.dateTimePicker.MinDate = new System.DateTime(2024, 5, 26, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker.Size = new System.Drawing.Size(231, 25);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // lblReservationDate
            // 
            this.lblReservationDate.AutoSize = true;
            this.lblReservationDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationDate.Location = new System.Drawing.Point(59, 264);
            this.lblReservationDate.Name = "lblReservationDate";
            this.lblReservationDate.Size = new System.Drawing.Size(42, 20);
            this.lblReservationDate.TabIndex = 10;
            this.lblReservationDate.Text = "Date";
            // 
            // pnlReservation
            // 
            this.pnlReservation.Controls.Add(this.lblGraduation);
            this.pnlReservation.Controls.Add(this.picGraduation);
            this.pnlReservation.Controls.Add(this.numPeople);
            this.pnlReservation.Controls.Add(this.btnComfirmReservation);
            this.pnlReservation.Controls.Add(this.lblParty);
            this.pnlReservation.Controls.Add(this.lblGathering);
            this.pnlReservation.Controls.Add(this.picParty);
            this.pnlReservation.Controls.Add(this.picGathering);
            this.pnlReservation.Controls.Add(this.picBirthday);
            this.pnlReservation.Controls.Add(this.lblBirthday);
            this.pnlReservation.Controls.Add(this.lblChooseVenueType);
            this.pnlReservation.Controls.Add(this.label1);
            this.pnlReservation.Controls.Add(this.cmbReservationTime);
            this.pnlReservation.Controls.Add(this.lblReservationTime);
            this.pnlReservation.Controls.Add(this.lblReservationDate);
            this.pnlReservation.Controls.Add(this.dateTimePicker);
            this.pnlReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReservation.Location = new System.Drawing.Point(0, 100);
            this.pnlReservation.Name = "pnlReservation";
            this.pnlReservation.Size = new System.Drawing.Size(973, 528);
            this.pnlReservation.TabIndex = 9;
            // 
            // lblGraduation
            // 
            this.lblGraduation.AutoSize = true;
            this.lblGraduation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraduation.Location = new System.Drawing.Point(605, 205);
            this.lblGraduation.Name = "lblGraduation";
            this.lblGraduation.Size = new System.Drawing.Size(88, 21);
            this.lblGraduation.TabIndex = 52;
            this.lblGraduation.Text = "Graduation";
            this.lblGraduation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picGraduation
            // 
            this.picGraduation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGraduation.Image = global::C__Group_Assignment.Properties.Resources.Graduation;
            this.picGraduation.Location = new System.Drawing.Point(584, 82);
            this.picGraduation.Name = "picGraduation";
            this.picGraduation.Size = new System.Drawing.Size(124, 109);
            this.picGraduation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGraduation.TabIndex = 50;
            this.picGraduation.TabStop = false;
            this.picGraduation.Click += new System.EventHandler(this.picGraduation_Click);
            // 
            // numPeople
            // 
            this.numPeople.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPeople.Location = new System.Drawing.Point(57, 384);
            this.numPeople.Name = "numPeople";
            this.numPeople.Size = new System.Drawing.Size(230, 25);
            this.numPeople.TabIndex = 48;
            this.numPeople.ValueChanged += new System.EventHandler(this.numPeople_ValueChanged);
            // 
            // btnComfirmReservation
            // 
            this.btnComfirmReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnComfirmReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnComfirmReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnComfirmReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComfirmReservation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComfirmReservation.Location = new System.Drawing.Point(57, 451);
            this.btnComfirmReservation.Name = "btnComfirmReservation";
            this.btnComfirmReservation.Size = new System.Drawing.Size(642, 52);
            this.btnComfirmReservation.TabIndex = 47;
            this.btnComfirmReservation.Text = "Comfirm Reservation";
            this.btnComfirmReservation.UseVisualStyleBackColor = false;
            this.btnComfirmReservation.Click += new System.EventHandler(this.btnComfirmReservation_Click);
            // 
            // lblParty
            // 
            this.lblParty.AutoSize = true;
            this.lblParty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParty.Location = new System.Drawing.Point(447, 205);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(45, 21);
            this.lblParty.TabIndex = 45;
            this.lblParty.Text = "Party";
            this.lblParty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGathering
            // 
            this.lblGathering.AutoSize = true;
            this.lblGathering.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGathering.Location = new System.Drawing.Point(258, 205);
            this.lblGathering.Name = "lblGathering";
            this.lblGathering.Size = new System.Drawing.Size(79, 21);
            this.lblGathering.TabIndex = 44;
            this.lblGathering.Text = "Gathering";
            this.lblGathering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picParty
            // 
            this.picParty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picParty.Image = global::C__Group_Assignment.Properties.Resources.Party;
            this.picParty.Location = new System.Drawing.Point(410, 82);
            this.picParty.Name = "picParty";
            this.picParty.Size = new System.Drawing.Size(124, 109);
            this.picParty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picParty.TabIndex = 43;
            this.picParty.TabStop = false;
            this.picParty.Click += new System.EventHandler(this.picParty_Click);
            // 
            // picGathering
            // 
            this.picGathering.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGathering.Image = global::C__Group_Assignment.Properties.Resources.Gathering;
            this.picGathering.Location = new System.Drawing.Point(236, 82);
            this.picGathering.Name = "picGathering";
            this.picGathering.Size = new System.Drawing.Size(124, 109);
            this.picGathering.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGathering.TabIndex = 42;
            this.picGathering.TabStop = false;
            this.picGathering.Click += new System.EventHandler(this.picGathering_Click);
            // 
            // picBirthday
            // 
            this.picBirthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBirthday.Image = global::C__Group_Assignment.Properties.Resources.Birthday;
            this.picBirthday.Location = new System.Drawing.Point(65, 82);
            this.picBirthday.Name = "picBirthday";
            this.picBirthday.Size = new System.Drawing.Size(124, 109);
            this.picBirthday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBirthday.TabIndex = 41;
            this.picBirthday.TabStop = false;
            this.picBirthday.Click += new System.EventHandler(this.picBirthday_Click);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(91, 205);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(68, 21);
            this.lblBirthday.TabIndex = 36;
            this.lblBirthday.Text = "Birthday";
            this.lblBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChooseVenueType
            // 
            this.lblChooseVenueType.AutoSize = true;
            this.lblChooseVenueType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseVenueType.Location = new System.Drawing.Point(54, 36);
            this.lblChooseVenueType.Name = "lblChooseVenueType";
            this.lblChooseVenueType.Size = new System.Drawing.Size(162, 21);
            this.lblChooseVenueType.TabIndex = 32;
            this.lblChooseVenueType.Text = "Choose Venue Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Number of People";
            // 
            // cmbReservationTime
            // 
            this.cmbReservationTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReservationTime.FormattingEnabled = true;
            this.cmbReservationTime.Items.AddRange(new object[] {
            "8:00 AM - 10:00 AM",
            "9:00 AM - 11:00 AM",
            "10:00 AM - 12:00 PM",
            "11:00 AM - 1:00 PM",
            "12:00 PM - 2:00 PM",
            "1:00 PM - 3:00 PM",
            "2:00 PM - 4:00 PM",
            "3:00 PM - 5:00 PM",
            "4:00 PM - 6:00 PM",
            "5:00 PM - 7:00 PM",
            "6:00 PM - 8:00 PM",
            "7:00 PM - 9:00 PM",
            "8:00 PM - 10:00 PM",
            "9:00 PM - 11:00 PM",
            "10:00 PM - 12:00 AM"});
            this.cmbReservationTime.Location = new System.Drawing.Point(329, 295);
            this.cmbReservationTime.Name = "cmbReservationTime";
            this.cmbReservationTime.Size = new System.Drawing.Size(231, 25);
            this.cmbReservationTime.TabIndex = 12;
            this.cmbReservationTime.Text = "Choose your time here...";
            this.cmbReservationTime.SelectedIndexChanged += new System.EventHandler(this.cmbReservationTime_SelectedIndexChanged);
            // 
            // lblReservationTime
            // 
            this.lblReservationTime.AutoSize = true;
            this.lblReservationTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationTime.Location = new System.Drawing.Point(328, 263);
            this.lblReservationTime.Name = "lblReservationTime";
            this.lblReservationTime.Size = new System.Drawing.Size(44, 20);
            this.lblReservationTime.TabIndex = 11;
            this.lblReservationTime.Text = "Time";
            // 
            // frmMakeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 628);
            this.Controls.Add(this.pnlReservation);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMakeReservation";
            this.Text = "frmMakeReservation";
            this.Load += new System.EventHandler(this.frmMakeReservation_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlReservation.ResumeLayout(false);
            this.pnlReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraduation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGathering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblMakeReservation;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblReservationDate;
        private System.Windows.Forms.Panel pnlReservation;
        private System.Windows.Forms.Label lblReservationTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblChooseVenueType;
        private System.Windows.Forms.PictureBox picGathering;
        private System.Windows.Forms.PictureBox picBirthday;
        private System.Windows.Forms.PictureBox picParty;
        private System.Windows.Forms.Label lblGathering;
        private System.Windows.Forms.Label lblParty;
        private System.Windows.Forms.Button btnComfirmReservation;
        private System.Windows.Forms.NumericUpDown numPeople;
        private System.Windows.Forms.Label lblGraduation;
        private System.Windows.Forms.PictureBox picGraduation;
        private System.Windows.Forms.ComboBox cmbReservationTime;
    }
}