namespace C__Group_Assignment
{
    partial class frmSetDateTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetDateTime));
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.btnSetDateTime = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlControlBox = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlControlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTime
            // 
            this.cmbTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            " 8:00 AM - 10:00 AM",
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
            this.cmbTime.Location = new System.Drawing.Point(53, 168);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(200, 21);
            this.cmbTime.TabIndex = 7;
            this.cmbTime.Text = "Choose time here...";
            // 
            // btnSetDateTime
            // 
            this.btnSetDateTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDateTime.Location = new System.Drawing.Point(76, 222);
            this.btnSetDateTime.Name = "btnSetDateTime";
            this.btnSetDateTime.Size = new System.Drawing.Size(151, 23);
            this.btnSetDateTime.TabIndex = 6;
            this.btnSetDateTime.Text = "Set Choosen Date Time";
            this.btnSetDateTime.UseVisualStyleBackColor = true;
            this.btnSetDateTime.Click += new System.EventHandler(this.btnSetDateTime_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(53, 119);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Set Date and Time";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.pnlTop.Controls.Add(this.pnlControlBox);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(307, 39);
            this.pnlTop.TabIndex = 9;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            // 
            // pnlControlBox
            // 
            this.pnlControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControlBox.Controls.Add(this.btnExit);
            this.pnlControlBox.Controls.Add(this.btnMinimize);
            this.pnlControlBox.Location = new System.Drawing.Point(207, 0);
            this.pnlControlBox.Name = "pnlControlBox";
            this.pnlControlBox.Size = new System.Drawing.Size(97, 41);
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
            this.btnExit.Location = new System.Drawing.Point(53, 3);
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
            this.btnMinimize.Location = new System.Drawing.Point(3, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 32);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // frmSetDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 299);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetDateTime);
            this.Controls.Add(this.dateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetDateTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSetDateTime";
            this.pnlTop.ResumeLayout(false);
            this.pnlControlBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Button btnSetDateTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlControlBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
    }
}