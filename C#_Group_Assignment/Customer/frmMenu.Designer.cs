namespace C__Group_Assignment
{
    partial class frmMenu
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
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlYourOrders = new System.Windows.Forms.Panel();
            this.lblYourOrders = new System.Windows.Forms.Label();
            this.pnlInfoOrder = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.containerCategory = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnItalian = new System.Windows.Forms.Button();
            this.btnMexican = new System.Windows.Forms.Button();
            this.btnJapanese = new System.Windows.Forms.Button();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.pnlFoods = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlInfo.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlYourOrders.SuspendLayout();
            this.pnlInfoOrder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.containerCategory.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblStatus);
            this.pnlInfo.Controls.Add(this.lblTime);
            this.pnlInfo.Controls.Add(this.lblName);
            this.pnlInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(278, 100);
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
            // pnlOrders
            // 
            this.pnlOrders.AutoScroll = true;
            this.pnlOrders.Controls.Add(this.pnlYourOrders);
            this.pnlOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrders.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlOrders.Location = new System.Drawing.Point(0, 100);
            this.pnlOrders.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(278, 452);
            this.pnlOrders.TabIndex = 2;
            this.pnlOrders.WrapContents = false;
            // 
            // pnlYourOrders
            // 
            this.pnlYourOrders.Controls.Add(this.lblYourOrders);
            this.pnlYourOrders.Location = new System.Drawing.Point(3, 3);
            this.pnlYourOrders.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pnlYourOrders.Name = "pnlYourOrders";
            this.pnlYourOrders.Size = new System.Drawing.Size(271, 36);
            this.pnlYourOrders.TabIndex = 0;
            // 
            // lblYourOrders
            // 
            this.lblYourOrders.AutoSize = true;
            this.lblYourOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourOrders.Location = new System.Drawing.Point(7, 7);
            this.lblYourOrders.Name = "lblYourOrders";
            this.lblYourOrders.Size = new System.Drawing.Size(97, 21);
            this.lblYourOrders.TabIndex = 0;
            this.lblYourOrders.Text = "Your Orders";
            // 
            // pnlInfoOrder
            // 
            this.pnlInfoOrder.Controls.Add(this.pnlOrders);
            this.pnlInfoOrder.Controls.Add(this.panel1);
            this.pnlInfoOrder.Controls.Add(this.pnlInfo);
            this.pnlInfoOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfoOrder.Location = new System.Drawing.Point(695, 0);
            this.pnlInfoOrder.Name = "pnlInfoOrder";
            this.pnlInfoOrder.Size = new System.Drawing.Size(278, 628);
            this.pnlInfoOrder.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 552);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 76);
            this.panel1.TabIndex = 1;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(238, 7);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(19, 21);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "RM";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Location = new System.Drawing.Point(50, 33);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(186, 36);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order Now";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL";
            // 
            // containerCategory
            // 
            this.containerCategory.Controls.Add(this.lblCategory);
            this.containerCategory.Controls.Add(this.btnAll);
            this.containerCategory.Controls.Add(this.btnItalian);
            this.containerCategory.Controls.Add(this.btnMexican);
            this.containerCategory.Controls.Add(this.btnJapanese);
            this.containerCategory.Location = new System.Drawing.Point(8, 8);
            this.containerCategory.Name = "containerCategory";
            this.containerCategory.Size = new System.Drawing.Size(490, 84);
            this.containerCategory.TabIndex = 10;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(20, 3);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(128, 21);
            this.lblCategory.TabIndex = 15;
            this.lblCategory.Text = "Menu Category";
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(8, 34);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(115, 47);
            this.btnAll.TabIndex = 14;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnItalian
            // 
            this.btnItalian.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItalian.Location = new System.Drawing.Point(129, 34);
            this.btnItalian.Name = "btnItalian";
            this.btnItalian.Size = new System.Drawing.Size(115, 47);
            this.btnItalian.TabIndex = 13;
            this.btnItalian.Text = "Italian";
            this.btnItalian.UseVisualStyleBackColor = true;
            this.btnItalian.Click += new System.EventHandler(this.btnItalian_Click);
            // 
            // btnMexican
            // 
            this.btnMexican.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMexican.Location = new System.Drawing.Point(250, 34);
            this.btnMexican.Name = "btnMexican";
            this.btnMexican.Size = new System.Drawing.Size(115, 47);
            this.btnMexican.TabIndex = 12;
            this.btnMexican.Text = "Mexican";
            this.btnMexican.UseVisualStyleBackColor = true;
            this.btnMexican.Click += new System.EventHandler(this.btnMexican_Click);
            // 
            // btnJapanese
            // 
            this.btnJapanese.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJapanese.Location = new System.Drawing.Point(371, 34);
            this.btnJapanese.Name = "btnJapanese";
            this.btnJapanese.Size = new System.Drawing.Size(115, 47);
            this.btnJapanese.TabIndex = 11;
            this.btnJapanese.Text = "Japanese";
            this.btnJapanese.UseVisualStyleBackColor = true;
            this.btnJapanese.Click += new System.EventHandler(this.btnJapanese_Click);
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.containerCategory);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(695, 100);
            this.pnlCategory.TabIndex = 4;
            // 
            // pnlFoods
            // 
            this.pnlFoods.AutoScroll = true;
            this.pnlFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFoods.Location = new System.Drawing.Point(0, 100);
            this.pnlFoods.Name = "pnlFoods";
            this.pnlFoods.Size = new System.Drawing.Size(695, 528);
            this.pnlFoods.TabIndex = 5;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 628);
            this.Controls.Add(this.pnlFoods);
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.pnlInfoOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlYourOrders.ResumeLayout(false);
            this.pnlYourOrders.PerformLayout();
            this.pnlInfoOrder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.containerCategory.ResumeLayout(false);
            this.containerCategory.PerformLayout();
            this.pnlCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlYourOrders;
        private System.Windows.Forms.Label lblYourOrders;
        private System.Windows.Forms.Panel pnlInfoOrder;
        private System.Windows.Forms.Panel containerCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnItalian;
        private System.Windows.Forms.Button btnMexican;
        private System.Windows.Forms.Button btnJapanese;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.FlowLayoutPanel pnlFoods;
        public System.Windows.Forms.FlowLayoutPanel pnlOrders;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label1;
    }
}