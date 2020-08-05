namespace RestaurantManagmentSystemApp
{
    partial class Roles
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
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roleErrorLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.roleTextBox);
            this.leftPanel.Controls.Add(this.roleErrorLabel);
            this.leftPanel.Controls.SetChildIndex(this.roleErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.leftTop, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.roleTextBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            // 
            // roleTextBox
            // 
            this.roleTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleTextBox.Location = new System.Drawing.Point(6, 109);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.Size = new System.Drawing.Size(238, 24);
            this.roleTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Role";
            // 
            // roleErrorLabel
            // 
            this.roleErrorLabel.AutoSize = true;
            this.roleErrorLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleErrorLabel.Location = new System.Drawing.Point(230, 92);
            this.roleErrorLabel.Name = "roleErrorLabel";
            this.roleErrorLabel.Size = new System.Drawing.Size(14, 14);
            this.roleErrorLabel.TabIndex = 4;
            this.roleErrorLabel.Text = "*";
            this.roleErrorLabel.Visible = false;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Roles";
            this.Text = "Roles";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label roleErrorLabel;
    }
}