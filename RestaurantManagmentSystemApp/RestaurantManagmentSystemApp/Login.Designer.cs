namespace RestaurantManagmentSystemApp
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.uNameTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.loginBtn);
            this.leftPanel.Controls.Add(this.passwordTBox);
            this.leftPanel.Controls.Add(this.uNameTBox);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPanel.Size = new System.Drawing.Size(250, 505);
            this.leftPanel.Controls.SetChildIndex(this.leftTop, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.uNameTBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordTBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.loginBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(550, 505);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // uNameTBox
            // 
            this.uNameTBox.Location = new System.Drawing.Point(15, 173);
            this.uNameTBox.Name = "uNameTBox";
            this.uNameTBox.Size = new System.Drawing.Size(232, 22);
            this.uNameTBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // passwordTBox
            // 
            this.passwordTBox.Location = new System.Drawing.Point(15, 215);
            this.passwordTBox.Name = "passwordTBox";
            this.passwordTBox.Size = new System.Drawing.Size(232, 22);
            this.passwordTBox.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.FlatAppearance.BorderSize = 2;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Location = new System.Drawing.Point(15, 244);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(229, 28);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Name = "Login";
            this.Text = "Login";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox uNameTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginBtn;
    }
}