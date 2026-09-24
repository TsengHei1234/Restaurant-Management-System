namespace C__Group_Assignment
{
    partial class frmReservationStatus
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
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.lblReservationStatus = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlCategory.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategory
            // 
            this.pnlCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategory.Controls.Add(this.lblReservationStatus);
            this.pnlCategory.Controls.Add(this.pnlInfo);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(973, 100);
            this.pnlCategory.TabIndex = 10;
            // 
            // lblReservationStatus
            // 
            this.lblReservationStatus.AutoSize = true;
            this.lblReservationStatus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationStatus.Location = new System.Drawing.Point(39, 33);
            this.lblReservationStatus.Name = "lblReservationStatus";
            this.lblReservationStatus.Size = new System.Drawing.Size(256, 37);
            this.lblReservationStatus.TabIndex = 16;
            this.lblReservationStatus.Text = "Reservation Status";
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
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(12, 82);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.Size = new System.Drawing.Size(949, 298);
            this.dgvReservations.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.dgvReservations);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 528);
            this.panel1.TabIndex = 11;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(42, 34);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(224, 25);
            this.lblCategory.TabIndex = 18;
            this.lblCategory.Text = "Your Reservation Status";
            // 
            // frmReservationStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservationStatus";
            this.Text = "frmReservationStatus";
            this.Load += new System.EventHandler(this.frmReservationStatus_Load);
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Label lblReservationStatus;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCategory;
    }
}