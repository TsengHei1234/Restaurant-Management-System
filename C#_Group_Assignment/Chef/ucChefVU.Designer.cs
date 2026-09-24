namespace C__Group_Assignment
{
    partial class ucChefVU
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChefVU));
            this.lblTable = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.lblOrderTime = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIP = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(28, 19);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(59, 20);
            this.lblTable.TabIndex = 22;
            this.lblTable.Text = "Table: 1";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.Location = new System.Drawing.Point(46, 16);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(121, 20);
            this.lblFood.TabIndex = 21;
            this.lblFood.Text = "Food: Hambuger";
            this.lblFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblOrderNo.Location = new System.Drawing.Point(-165, 104);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(78, 40);
            this.lblOrderNo.TabIndex = 20;
            this.lblOrderNo.Text = "Order No.\r\n1";
            this.lblOrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picFood
            // 
            this.picFood.Image = ((System.Drawing.Image)(resources.GetObject("picFood.Image")));
            this.picFood.Location = new System.Drawing.Point(-76, 91);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(66, 61);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFood.TabIndex = 24;
            this.picFood.TabStop = false;
            // 
            // lblOrderTime
            // 
            this.lblOrderTime.AutoSize = true;
            this.lblOrderTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTime.Location = new System.Drawing.Point(28, 49);
            this.lblOrderTime.Name = "lblOrderTime";
            this.lblOrderTime.Size = new System.Drawing.Size(147, 20);
            this.lblOrderTime.TabIndex = 27;
            this.lblOrderTime.Text = "Order Time: 12:29PM";
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.Location = new System.Drawing.Point(28, 78);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(166, 20);
            this.lblOrderType.TabIndex = 28;
            this.lblOrderType.Text = "Order Type: Reservation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnIP);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.lblFood);
            this.panel1.Controls.Add(this.btnComplete);
            this.panel1.Location = new System.Drawing.Point(0, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 128);
            this.panel1.TabIndex = 29;
            // 
            // btnIP
            // 
            this.btnIP.Location = new System.Drawing.Point(24, 78);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(158, 36);
            this.btnIP.TabIndex = 23;
            this.btnIP.Text = "In Progress";
            this.btnIP.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(64, 43);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(77, 20);
            this.lblAmount.TabIndex = 22;
            this.lblAmount.Text = "Amount: 1";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(24, 78);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(158, 36);
            this.btnComplete.TabIndex = 24;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // ucChefVU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.lblOrderTime);
            this.Controls.Add(this.picFood);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblOrderNo);
            this.Name = "ucChefVU";
            this.Size = new System.Drawing.Size(210, 243);
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picFood;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblOrderTime;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnIP;
        private System.Windows.Forms.Button btnComplete;
    }
}
