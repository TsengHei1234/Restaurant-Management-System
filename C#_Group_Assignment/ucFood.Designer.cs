namespace C__Group_Assignment
{
    partial class ucFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFood));
            this.pnlFood = new System.Windows.Forms.Panel();
            this.pnlItemPriceOrder = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFood.SuspendLayout();
            this.pnlItemPriceOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFood
            // 
            this.pnlFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.pnlFood.Controls.Add(this.pnlItemPriceOrder);
            this.pnlFood.Controls.Add(this.picItem);
            this.pnlFood.Location = new System.Drawing.Point(0, 0);
            this.pnlFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFood.Name = "pnlFood";
            this.pnlFood.Size = new System.Drawing.Size(285, 394);
            this.pnlFood.TabIndex = 1;
            // 
            // pnlItemPriceOrder
            // 
            this.pnlItemPriceOrder.Controls.Add(this.lblFoodPrice);
            this.pnlItemPriceOrder.Controls.Add(this.label2);
            this.pnlItemPriceOrder.Controls.Add(this.btnOrder);
            this.pnlItemPriceOrder.Controls.Add(this.lblFoodName);
            this.pnlItemPriceOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlItemPriceOrder.Location = new System.Drawing.Point(0, 228);
            this.pnlItemPriceOrder.Margin = new System.Windows.Forms.Padding(15);
            this.pnlItemPriceOrder.Name = "pnlItemPriceOrder";
            this.pnlItemPriceOrder.Padding = new System.Windows.Forms.Padding(15);
            this.pnlItemPriceOrder.Size = new System.Drawing.Size(285, 166);
            this.pnlItemPriceOrder.TabIndex = 1;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Location = new System.Drawing.Point(68, 111);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(138, 35);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodPrice.Location = new System.Drawing.Point(137, 67);
            this.lblFoodPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(34, 28);
            this.lblFoodPrice.TabIndex = 1;
            this.lblFoodPrice.Text = "20";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.Location = new System.Drawing.Point(69, 23);
            this.lblFoodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(140, 32);
            this.lblFoodName.TabIndex = 0;
            this.lblFoodName.Text = "Food Name";
            this.lblFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picItem
            // 
            this.picItem.Image = ((System.Drawing.Image)(resources.GetObject("picItem.Image")));
            this.picItem.InitialImage = ((System.Drawing.Image)(resources.GetObject("picItem.InitialImage")));
            this.picItem.Location = new System.Drawing.Point(38, 26);
            this.picItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(210, 192);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItem.TabIndex = 0;
            this.picItem.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "RM";
            // 
            // ucFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlFood);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucFood";
            this.Size = new System.Drawing.Size(285, 394);
            this.pnlFood.ResumeLayout(false);
            this.pnlItemPriceOrder.ResumeLayout(false);
            this.pnlItemPriceOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFood;
        private System.Windows.Forms.Panel pnlItemPriceOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.Label label2;
    }
}
