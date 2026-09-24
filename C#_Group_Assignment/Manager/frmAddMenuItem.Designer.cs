namespace C__Group_Assignment
{
    partial class frmAddMenuItem
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
            this.lblAddMenuItem = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbUnavailable = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbAvailable = new System.Windows.Forms.RadioButton();
            this.lblEditStatus = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbAddCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbUploadItem = new System.Windows.Forms.PictureBox();
            this.btnUploadItem = new System.Windows.Forms.Button();
            this.lblDisplayImage = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUploadItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAddMenuItem);
            this.panel1.Controls.Add(this.pnlInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 140);
            this.panel1.TabIndex = 4;
            // 
            // lblAddMenuItem
            // 
            this.lblAddMenuItem.AutoSize = true;
            this.lblAddMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMenuItem.Location = new System.Drawing.Point(35, 50);
            this.lblAddMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddMenuItem.Name = "lblAddMenuItem";
            this.lblAddMenuItem.Size = new System.Drawing.Size(270, 46);
            this.lblAddMenuItem.TabIndex = 18;
            this.lblAddMenuItem.Text = "Add Menu Item";
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
            this.panel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 414);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pbUploadItem);
            this.panel3.Controls.Add(this.btnUploadItem);
            this.panel3.Controls.Add(this.lblDisplayImage);
            this.panel3.Controls.Add(this.txtItemName);
            this.panel3.Controls.Add(this.lblItemName);
            this.panel3.Location = new System.Drawing.Point(57, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(981, 406);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(229)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.rbUnavailable);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.rbAvailable);
            this.panel5.Controls.Add(this.lblEditStatus);
            this.panel5.Controls.Add(this.checkedListBox1);
            this.panel5.Controls.Add(this.lblIngredients);
            this.panel5.Controls.Add(this.txtPrice);
            this.panel5.Controls.Add(this.lblPrice);
            this.panel5.Controls.Add(this.cbAddCategory);
            this.panel5.Controls.Add(this.lblCategory);
            this.panel5.Location = new System.Drawing.Point(465, -1);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(486, 404);
            this.panel5.TabIndex = 18;
            // 
            // rbUnavailable
            // 
            this.rbUnavailable.AutoSize = true;
            this.rbUnavailable.Location = new System.Drawing.Point(335, 60);
            this.rbUnavailable.Margin = new System.Windows.Forms.Padding(4);
            this.rbUnavailable.Name = "rbUnavailable";
            this.rbUnavailable.Size = new System.Drawing.Size(120, 27);
            this.rbUnavailable.TabIndex = 17;
            this.rbUnavailable.TabStop = true;
            this.rbUnavailable.Text = "Unavailable";
            this.rbUnavailable.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(31, 336);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 44);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbAvailable
            // 
            this.rbAvailable.AutoSize = true;
            this.rbAvailable.Location = new System.Drawing.Point(335, 27);
            this.rbAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.rbAvailable.Name = "rbAvailable";
            this.rbAvailable.Size = new System.Drawing.Size(100, 27);
            this.rbAvailable.TabIndex = 16;
            this.rbAvailable.TabStop = true;
            this.rbAvailable.Text = "Available";
            this.rbAvailable.UseVisualStyleBackColor = true;
            // 
            // lblEditStatus
            // 
            this.lblEditStatus.AutoSize = true;
            this.lblEditStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditStatus.Location = new System.Drawing.Point(331, 2);
            this.lblEditStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditStatus.Name = "lblEditStatus";
            this.lblEditStatus.Size = new System.Drawing.Size(57, 23);
            this.lblEditStatus.TabIndex = 15;
            this.lblEditStatus.Text = "Status";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Spaghetti",
            "Garlic",
            "Olive Oil",
            "Red Pepper Flakes",
            "Parsley",
            "Tomato Sauce",
            "Mozzarella",
            "Basil",
            "Eggs",
            "Cheese",
            "Pancetta",
            "Black Pepper",
            "Bread",
            "Rice",
            "Saffron",
            "Chicken",
            "Beef",
            "Onions",
            "Cilantro",
            "Salsa",
            "Flour Tortilla",
            "Beans",
            "Bell Peppers",
            "Soy Sauce",
            "Sugar",
            "Mirin",
            "Shrimp",
            "Cabbage",
            "Tuna",
            "Salmon",
            "Pickled Plum",
            "Nori"});
            this.checkedListBox1.Location = new System.Drawing.Point(31, 178);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(211, 100);
            this.checkedListBox1.TabIndex = 7;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(27, 154);
            this.lblIngredients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(96, 23);
            this.lblIngredients.TabIndex = 6;
            this.lblIngredients.Text = "Ingredients";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(31, 106);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(160, 29);
            this.txtPrice.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(27, 81);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 23);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // cbAddCategory
            // 
            this.cbAddCategory.FormattingEnabled = true;
            this.cbAddCategory.Items.AddRange(new object[] {
            "Italian ",
            "Mexican",
            "Japanese"});
            this.cbAddCategory.Location = new System.Drawing.Point(31, 27);
            this.cbAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbAddCategory.Name = "cbAddCategory";
            this.cbAddCategory.Size = new System.Drawing.Size(160, 29);
            this.cbAddCategory.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(27, 2);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 23);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.panel4.Location = new System.Drawing.Point(379, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 406);
            this.panel4.TabIndex = 11;
            // 
            // pbUploadItem
            // 
            this.pbUploadItem.BackColor = System.Drawing.Color.White;
            this.pbUploadItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUploadItem.Location = new System.Drawing.Point(91, 16);
            this.pbUploadItem.Margin = new System.Windows.Forms.Padding(4);
            this.pbUploadItem.Name = "pbUploadItem";
            this.pbUploadItem.Size = new System.Drawing.Size(206, 192);
            this.pbUploadItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUploadItem.TabIndex = 10;
            this.pbUploadItem.TabStop = false;
            // 
            // btnUploadItem
            // 
            this.btnUploadItem.BackColor = System.Drawing.Color.LightGray;
            this.btnUploadItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnUploadItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnUploadItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadItem.Location = new System.Drawing.Point(57, 258);
            this.btnUploadItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadItem.Name = "btnUploadItem";
            this.btnUploadItem.Size = new System.Drawing.Size(100, 44);
            this.btnUploadItem.TabIndex = 9;
            this.btnUploadItem.Text = "Upload";
            this.btnUploadItem.UseVisualStyleBackColor = false;
            this.btnUploadItem.Click += new System.EventHandler(this.btnUploadItem_Click);
            // 
            // lblDisplayImage
            // 
            this.lblDisplayImage.AutoSize = true;
            this.lblDisplayImage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayImage.Location = new System.Drawing.Point(53, 234);
            this.lblDisplayImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayImage.Name = "lblDisplayImage";
            this.lblDisplayImage.Size = new System.Drawing.Size(118, 23);
            this.lblDisplayImage.TabIndex = 8;
            this.lblDisplayImage.Text = "Display Image";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(57, 352);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(279, 29);
            this.txtItemName.TabIndex = 1;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(56, 327);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(96, 23);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item Name";
            // 
            // frmAddMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddMenuItem";
            this.Text = "frmAddMenuItem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUploadItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddMenuItem;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnUploadItem;
        private System.Windows.Forms.Label lblDisplayImage;
        private System.Windows.Forms.PictureBox pbUploadItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbUnavailable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbAvailable;
        private System.Windows.Forms.Label lblEditStatus;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbAddCategory;
        private System.Windows.Forms.Label lblCategory;
    }
}