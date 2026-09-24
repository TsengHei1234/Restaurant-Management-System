namespace C__Group_Assignment
{
    partial class frmPersonalInfo
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
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.lblUpdateProfile = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.lblSecurityAnswer = new System.Windows.Forms.Label();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateProfile);
            this.panel1.Controls.Add(this.txtSecurityAnswer);
            this.panel1.Controls.Add(this.lblSecurityAnswer);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 528);
            this.panel1.TabIndex = 13;
            // 
            // pnlCategory
            // 
            this.pnlCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategory.Controls.Add(this.lblUpdateProfile);
            this.pnlCategory.Controls.Add(this.pnlInfo);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(973, 100);
            this.pnlCategory.TabIndex = 12;
            // 
            // lblUpdateProfile
            // 
            this.lblUpdateProfile.AutoSize = true;
            this.lblUpdateProfile.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateProfile.Location = new System.Drawing.Point(39, 33);
            this.lblUpdateProfile.Name = "lblUpdateProfile";
            this.lblUpdateProfile.Size = new System.Drawing.Size(205, 37);
            this.lblUpdateProfile.TabIndex = 16;
            this.lblUpdateProfile.Text = "Update Profile";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(16, 56);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(139, 13);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time: 21/5/2024 | 11.59PM";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(15, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Welcome Back";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(182, 126);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 21);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(186, 161);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(238, 29);
            this.txtUsername.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(186, 266);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 29);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(182, 233);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 21);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Edit Personal Information";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(535, 161);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(238, 29);
            this.txtPassword.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(531, 126);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 21);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityAnswer.Location = new System.Drawing.Point(535, 267);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(238, 29);
            this.txtSecurityAnswer.TabIndex = 12;
            // 
            // lblSecurityAnswer
            // 
            this.lblSecurityAnswer.AutoSize = true;
            this.lblSecurityAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityAnswer.Location = new System.Drawing.Point(531, 233);
            this.lblSecurityAnswer.Name = "lblSecurityAnswer";
            this.lblSecurityAnswer.Size = new System.Drawing.Size(132, 21);
            this.lblSecurityAnswer.TabIndex = 11;
            this.lblSecurityAnswer.Text = "Security Answer:";
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.btnUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProfile.Location = new System.Drawing.Point(379, 383);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(186, 36);
            this.btnUpdateProfile.TabIndex = 13;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click_1);
            // 
            // frmPersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonalInfo";
            this.Text = "frmPersonalInfo";
            this.Load += new System.EventHandler(this.frmPersonalInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Label lblUpdateProfile;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSecurityAnswer;
        private System.Windows.Forms.Label lblSecurityAnswer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnUpdateProfile;
    }
}