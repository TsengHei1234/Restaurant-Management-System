namespace C__Group_Assignment
{
    partial class frmViewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewOrder));
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblViewOrder = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlViewOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCheckout = new System.Windows.Forms.Panel();
            this.lblOnline = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.picOnline = new System.Windows.Forms.PictureBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.picCredit = new System.Windows.Forms.PictureBox();
            this.picCash = new System.Windows.Forms.PictureBox();
            this.pnlCheckoutClose = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.transitionCheckout = new System.Windows.Forms.Timer(this.components);
            this.pnlCategory.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlCheckout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCash)).BeginInit();
            this.pnlCheckoutClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategory
            // 
            this.pnlCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategory.Controls.Add(this.panel3);
            this.pnlCategory.Controls.Add(this.lblViewOrder);
            this.pnlCategory.Controls.Add(this.pnlInfo);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(973, 100);
            this.pnlCategory.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCheckout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(490, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 98);
            this.panel3.TabIndex = 0;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnCheckout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnCheckout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.ForeColor = System.Drawing.Color.Black;
            this.btnCheckout.Location = new System.Drawing.Point(0, 24);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(200, 49);
            this.btnCheckout.TabIndex = 26;
            this.btnCheckout.Text = "Proceed to Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblViewOrder
            // 
            this.lblViewOrder.AutoSize = true;
            this.lblViewOrder.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewOrder.Location = new System.Drawing.Point(39, 33);
            this.lblViewOrder.Name = "lblViewOrder";
            this.lblViewOrder.Size = new System.Drawing.Size(161, 37);
            this.lblViewOrder.TabIndex = 16;
            this.lblViewOrder.Text = "View Order";
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
            // pnlViewOrder
            // 
            this.pnlViewOrder.AutoScroll = true;
            this.pnlViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewOrder.Location = new System.Drawing.Point(0, 100);
            this.pnlViewOrder.Name = "pnlViewOrder";
            this.pnlViewOrder.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnlViewOrder.Size = new System.Drawing.Size(973, 528);
            this.pnlViewOrder.TabIndex = 9;
            // 
            // pnlCheckout
            // 
            this.pnlCheckout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCheckout.Controls.Add(this.lblOnline);
            this.pnlCheckout.Controls.Add(this.lblCredit);
            this.pnlCheckout.Controls.Add(this.lblCash);
            this.pnlCheckout.Controls.Add(this.picOnline);
            this.pnlCheckout.Controls.Add(this.btnPay);
            this.pnlCheckout.Controls.Add(this.picCredit);
            this.pnlCheckout.Controls.Add(this.picCash);
            this.pnlCheckout.Controls.Add(this.pnlCheckoutClose);
            this.pnlCheckout.Controls.Add(this.lblPrice);
            this.pnlCheckout.Controls.Add(this.lblPaymentMethod);
            this.pnlCheckout.Controls.Add(this.label2);
            this.pnlCheckout.Controls.Add(this.lblTotal);
            this.pnlCheckout.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCheckout.Location = new System.Drawing.Point(973, 100);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Size = new System.Drawing.Size(0, 528);
            this.pnlCheckout.TabIndex = 8;
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnline.Location = new System.Drawing.Point(196, 162);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(50, 30);
            this.lblOnline.TabIndex = 31;
            this.lblOnline.Text = "Online\r\nBanking";
            this.lblOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(104, 168);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(67, 15);
            this.lblCredit.TabIndex = 30;
            this.lblCredit.Text = "Credit Card";
            this.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(33, 162);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(46, 30);
            this.lblCash.TabIndex = 29;
            this.lblCash.Text = "Cash in\r\nHand";
            this.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picOnline
            // 
            this.picOnline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOnline.Image = global::C__Group_Assignment.Properties.Resources.Online_Banking;
            this.picOnline.Location = new System.Drawing.Point(185, 94);
            this.picOnline.Name = "picOnline";
            this.picOnline.Size = new System.Drawing.Size(70, 58);
            this.picOnline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOnline.TabIndex = 28;
            this.picOnline.TabStop = false;
            this.picOnline.Click += new System.EventHandler(this.picOnline_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Location = new System.Drawing.Point(27, 252);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(224, 49);
            this.btnPay.TabIndex = 25;
            this.btnPay.Text = "Pay Now";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // picCredit
            // 
            this.picCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCredit.Image = global::C__Group_Assignment.Properties.Resources.Pay_by_Credit_Card;
            this.picCredit.Location = new System.Drawing.Point(103, 94);
            this.picCredit.Name = "picCredit";
            this.picCredit.Size = new System.Drawing.Size(70, 58);
            this.picCredit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCredit.TabIndex = 27;
            this.picCredit.TabStop = false;
            this.picCredit.Click += new System.EventHandler(this.picCredit_Click);
            // 
            // picCash
            // 
            this.picCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCash.Image = global::C__Group_Assignment.Properties.Resources.Cash_in_hand;
            this.picCash.Location = new System.Drawing.Point(21, 94);
            this.picCash.Name = "picCash";
            this.picCash.Size = new System.Drawing.Size(70, 58);
            this.picCash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCash.TabIndex = 26;
            this.picCash.TabStop = false;
            this.picCash.Click += new System.EventHandler(this.picCash_Click);
            // 
            // pnlCheckoutClose
            // 
            this.pnlCheckoutClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCheckoutClose.Controls.Add(this.btnClose);
            this.pnlCheckoutClose.Controls.Add(this.lblCheckout);
            this.pnlCheckoutClose.Location = new System.Drawing.Point(0, 0);
            this.pnlCheckoutClose.Name = "pnlCheckoutClose";
            this.pnlCheckoutClose.Size = new System.Drawing.Size(278, 34);
            this.pnlCheckoutClose.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(234, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 32);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckout.Location = new System.Drawing.Point(14, 6);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(82, 21);
            this.lblCheckout.TabIndex = 16;
            this.lblCheckout.Text = "Checkout";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(228, 210);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(25, 20);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "20";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(16, 55);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(202, 21);
            this.lblPaymentMethod.TabIndex = 20;
            this.lblPaymentMethod.Text = "Choose Payment Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "RM";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(17, 210);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 20);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Your Total:";
            // 
            // transitionCheckout
            // 
            this.transitionCheckout.Interval = 10;
            this.transitionCheckout.Tick += new System.EventHandler(this.transitionCheckout_Tick);
            // 
            // frmViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 628);
            this.Controls.Add(this.pnlViewOrder);
            this.Controls.Add(this.pnlCheckout);
            this.Controls.Add(this.pnlCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmViewOrder";
            this.Load += new System.EventHandler(this.frmViewOrder_Load);
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlCheckout.ResumeLayout(false);
            this.pnlCheckout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCash)).EndInit();
            this.pnlCheckoutClose.ResumeLayout(false);
            this.pnlCheckoutClose.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblViewOrder;
        private System.Windows.Forms.Panel pnlCheckout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlCheckoutClose;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Timer transitionCheckout;
        private System.Windows.Forms.PictureBox picCash;
        private System.Windows.Forms.PictureBox picOnline;
        private System.Windows.Forms.PictureBox picCredit;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.FlowLayoutPanel pnlViewOrder;
    }
}