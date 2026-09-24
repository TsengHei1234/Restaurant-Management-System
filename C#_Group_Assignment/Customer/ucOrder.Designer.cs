namespace C__Group_Assignment
{
    partial class ucOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucOrder));
            this.lblOrderName = new System.Windows.Forms.Label();
            this.numOrder = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderName
            // 
            this.lblOrderName.AutoSize = true;
            this.lblOrderName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblOrderName.Location = new System.Drawing.Point(82, 13);
            this.lblOrderName.Name = "lblOrderName";
            this.lblOrderName.Size = new System.Drawing.Size(149, 20);
            this.lblOrderName.TabIndex = 0;
            this.lblOrderName.Text = "Risotto alla Milanese";
            // 
            // numOrder
            // 
            this.numOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numOrder.Location = new System.Drawing.Point(205, 44);
            this.numOrder.Name = "numOrder";
            this.numOrder.Size = new System.Drawing.Size(44, 20);
            this.numOrder.TabIndex = 1;
            this.numOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOrder.ValueChanged += new System.EventHandler(this.numOrder_ValueChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(108, 42);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(22, 17);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "RM";
            // 
            // picFood
            // 
            this.picFood.Image = ((System.Drawing.Image)(resources.GetObject("picFood.Image")));
            this.picFood.Location = new System.Drawing.Point(8, 6);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(66, 61);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFood.TabIndex = 3;
            this.picFood.TabStop = false;
            // 
            // ucOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picFood);
            this.Controls.Add(this.numOrder);
            this.Controls.Add(this.lblOrderName);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.Name = "ucOrder";
            this.Size = new System.Drawing.Size(257, 73);
            this.Load += new System.EventHandler(this.ucOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderName;
        private System.Windows.Forms.NumericUpDown numOrder;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox picFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}
