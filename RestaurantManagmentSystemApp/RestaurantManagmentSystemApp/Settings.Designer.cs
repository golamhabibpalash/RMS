namespace RestaurantManagmentSystemApp
{
    partial class Settings
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
            this.serverTbox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.databaseTBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.uNameTBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTBox = new System.Windows.Forms.TextBox();
            this.integratedSecuritycheckBox = new System.Windows.Forms.CheckBox();
            this.serverErrorLable = new System.Windows.Forms.Label();
            this.databaseErrorLabel = new System.Windows.Forms.Label();
            this.usernameErrorLable = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.integratedSecuritycheckBox);
            this.leftPanel.Controls.Add(this.saveBtn);
            this.leftPanel.Controls.Add(this.passwordTBox);
            this.leftPanel.Controls.Add(this.uNameTBox);
            this.leftPanel.Controls.Add(this.databaseTBox);
            this.leftPanel.Controls.Add(this.passwordLabel);
            this.leftPanel.Controls.Add(this.usernameLabel);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.serverTbox);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.passwordErrorLabel);
            this.leftPanel.Controls.Add(this.usernameErrorLable);
            this.leftPanel.Controls.Add(this.databaseErrorLabel);
            this.leftPanel.Controls.Add(this.serverErrorLable);
            this.leftPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPanel.Size = new System.Drawing.Size(250, 575);
            this.leftPanel.Controls.SetChildIndex(this.serverErrorLable, 0);
            this.leftPanel.Controls.SetChildIndex(this.databaseErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameErrorLable, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverTbox, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.databaseTBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.uNameTBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordTBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.saveBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.integratedSecuritycheckBox, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(550, 575);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server";
            // 
            // serverTbox
            // 
            this.serverTbox.Location = new System.Drawing.Point(6, 170);
            this.serverTbox.MaxLength = 50;
            this.serverTbox.Name = "serverTbox";
            this.serverTbox.Size = new System.Drawing.Size(241, 22);
            this.serverTbox.TabIndex = 0;
            this.serverTbox.TextChanged += new System.EventHandler(this.sarverTbox_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(0, 347);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(241, 32);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Database";
            // 
            // databaseTBox
            // 
            this.databaseTBox.Location = new System.Drawing.Point(6, 212);
            this.databaseTBox.MaxLength = 50;
            this.databaseTBox.Name = "databaseTBox";
            this.databaseTBox.Size = new System.Drawing.Size(241, 22);
            this.databaseTBox.TabIndex = 1;
            this.databaseTBox.TextChanged += new System.EventHandler(this.databaseTBox_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(3, 237);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(61, 14);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // uNameTBox
            // 
            this.uNameTBox.Location = new System.Drawing.Point(3, 254);
            this.uNameTBox.MaxLength = 50;
            this.uNameTBox.Name = "uNameTBox";
            this.uNameTBox.Size = new System.Drawing.Size(241, 22);
            this.uNameTBox.TabIndex = 2;
            this.uNameTBox.TextChanged += new System.EventHandler(this.uNameTBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(3, 279);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(58, 14);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTBox
            // 
            this.passwordTBox.Location = new System.Drawing.Point(3, 295);
            this.passwordTBox.MaxLength = 50;
            this.passwordTBox.Name = "passwordTBox";
            this.passwordTBox.Size = new System.Drawing.Size(241, 22);
            this.passwordTBox.TabIndex = 3;
            this.passwordTBox.UseSystemPasswordChar = true;
            this.passwordTBox.TextChanged += new System.EventHandler(this.passwordTBox_TextChanged);
            // 
            // integratedSecuritycheckBox
            // 
            this.integratedSecuritycheckBox.AutoSize = true;
            this.integratedSecuritycheckBox.Location = new System.Drawing.Point(6, 323);
            this.integratedSecuritycheckBox.Name = "integratedSecuritycheckBox";
            this.integratedSecuritycheckBox.Size = new System.Drawing.Size(133, 18);
            this.integratedSecuritycheckBox.TabIndex = 4;
            this.integratedSecuritycheckBox.Text = "Integrated Security";
            this.integratedSecuritycheckBox.UseVisualStyleBackColor = true;
            this.integratedSecuritycheckBox.CheckedChanged += new System.EventHandler(this.integratedSecuritycheckBox_CheckedChanged);
            // 
            // serverErrorLable
            // 
            this.serverErrorLable.AutoSize = true;
            this.serverErrorLable.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverErrorLable.ForeColor = System.Drawing.Color.Red;
            this.serverErrorLable.Location = new System.Drawing.Point(226, 153);
            this.serverErrorLable.Name = "serverErrorLable";
            this.serverErrorLable.Size = new System.Drawing.Size(21, 24);
            this.serverErrorLable.TabIndex = 1;
            this.serverErrorLable.Text = "*";
            this.serverErrorLable.Visible = false;
            // 
            // databaseErrorLabel
            // 
            this.databaseErrorLabel.AutoSize = true;
            this.databaseErrorLabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.databaseErrorLabel.Location = new System.Drawing.Point(226, 195);
            this.databaseErrorLabel.Name = "databaseErrorLabel";
            this.databaseErrorLabel.Size = new System.Drawing.Size(21, 24);
            this.databaseErrorLabel.TabIndex = 1;
            this.databaseErrorLabel.Text = "*";
            this.databaseErrorLabel.Visible = false;
            // 
            // usernameErrorLable
            // 
            this.usernameErrorLable.AutoSize = true;
            this.usernameErrorLable.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameErrorLable.ForeColor = System.Drawing.Color.Red;
            this.usernameErrorLable.Location = new System.Drawing.Point(223, 237);
            this.usernameErrorLable.Name = "usernameErrorLable";
            this.usernameErrorLable.Size = new System.Drawing.Size(21, 24);
            this.usernameErrorLable.TabIndex = 1;
            this.usernameErrorLable.Text = "*";
            this.usernameErrorLable.Visible = false;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorLabel.Location = new System.Drawing.Point(223, 279);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(21, 24);
            this.passwordErrorLabel.TabIndex = 1;
            this.passwordErrorLabel.Text = "*";
            this.passwordErrorLabel.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox integratedSecuritycheckBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox passwordTBox;
        private System.Windows.Forms.TextBox uNameTBox;
        private System.Windows.Forms.TextBox databaseTBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverTbox;
        private System.Windows.Forms.Label serverErrorLable;
        private System.Windows.Forms.Label passwordErrorLabel;
        private System.Windows.Forms.Label usernameErrorLable;
        private System.Windows.Forms.Label databaseErrorLabel;
    }
}