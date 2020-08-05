namespace RestaurantManagmentSystemApp
{
    partial class Dashboard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.roleBtn = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.foodCategoriesBtn = new System.Windows.Forms.Button();
            this.foodMenuBtn = new System.Windows.Forms.Button();
            this.floorsBtn = new System.Windows.Forms.Button();
            this.ordersBtn = new System.Windows.Forms.Button();
            this.tableBtn = new System.Windows.Forms.Button();
            this.chairBtn = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.rightPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(250, 450);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Size = new System.Drawing.Size(550, 450);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button16, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button15, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button14, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button12, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chairBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ordersBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.floorsBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.foodMenuBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.foodCategoriesBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.customerBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.userBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.roleBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 405);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // roleBtn
            // 
            this.roleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleBtn.FlatAppearance.BorderSize = 2;
            this.roleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roleBtn.Location = new System.Drawing.Point(3, 3);
            this.roleBtn.Name = "roleBtn";
            this.roleBtn.Size = new System.Drawing.Size(131, 95);
            this.roleBtn.TabIndex = 0;
            this.roleBtn.Text = "Roles";
            this.roleBtn.UseVisualStyleBackColor = true;
            // 
            // userBtn
            // 
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBtn.FlatAppearance.BorderSize = 2;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Location = new System.Drawing.Point(140, 3);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(131, 95);
            this.userBtn.TabIndex = 1;
            this.userBtn.Text = "Users";
            this.userBtn.UseVisualStyleBackColor = true;
            // 
            // customerBtn
            // 
            this.customerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerBtn.FlatAppearance.BorderSize = 2;
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBtn.Location = new System.Drawing.Point(277, 3);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(131, 95);
            this.customerBtn.TabIndex = 2;
            this.customerBtn.Text = "Customers";
            this.customerBtn.UseVisualStyleBackColor = true;
            // 
            // foodCategoriesBtn
            // 
            this.foodCategoriesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodCategoriesBtn.FlatAppearance.BorderSize = 2;
            this.foodCategoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodCategoriesBtn.Location = new System.Drawing.Point(414, 3);
            this.foodCategoriesBtn.Name = "foodCategoriesBtn";
            this.foodCategoriesBtn.Size = new System.Drawing.Size(133, 95);
            this.foodCategoriesBtn.TabIndex = 3;
            this.foodCategoriesBtn.Text = "Food Categories";
            this.foodCategoriesBtn.UseVisualStyleBackColor = true;
            // 
            // foodMenuBtn
            // 
            this.foodMenuBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodMenuBtn.FlatAppearance.BorderSize = 2;
            this.foodMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodMenuBtn.Location = new System.Drawing.Point(3, 104);
            this.foodMenuBtn.Name = "foodMenuBtn";
            this.foodMenuBtn.Size = new System.Drawing.Size(131, 95);
            this.foodMenuBtn.TabIndex = 4;
            this.foodMenuBtn.Text = "Foood Menu";
            this.foodMenuBtn.UseVisualStyleBackColor = true;
            // 
            // floorsBtn
            // 
            this.floorsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floorsBtn.FlatAppearance.BorderSize = 2;
            this.floorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.floorsBtn.Location = new System.Drawing.Point(140, 104);
            this.floorsBtn.Name = "floorsBtn";
            this.floorsBtn.Size = new System.Drawing.Size(131, 95);
            this.floorsBtn.TabIndex = 5;
            this.floorsBtn.Text = "Floors";
            this.floorsBtn.UseVisualStyleBackColor = true;
            // 
            // ordersBtn
            // 
            this.ordersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersBtn.FlatAppearance.BorderSize = 2;
            this.ordersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersBtn.Location = new System.Drawing.Point(277, 104);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(131, 95);
            this.ordersBtn.TabIndex = 6;
            this.ordersBtn.Text = "Orders";
            this.ordersBtn.UseVisualStyleBackColor = true;
            // 
            // tableBtn
            // 
            this.tableBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBtn.FlatAppearance.BorderSize = 2;
            this.tableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableBtn.Location = new System.Drawing.Point(414, 104);
            this.tableBtn.Name = "tableBtn";
            this.tableBtn.Size = new System.Drawing.Size(133, 95);
            this.tableBtn.TabIndex = 7;
            this.tableBtn.Text = "Tables";
            this.tableBtn.UseVisualStyleBackColor = true;
            // 
            // chairBtn
            // 
            this.chairBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chairBtn.FlatAppearance.BorderSize = 2;
            this.chairBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chairBtn.Location = new System.Drawing.Point(3, 205);
            this.chairBtn.Name = "chairBtn";
            this.chairBtn.Size = new System.Drawing.Size(131, 95);
            this.chairBtn.TabIndex = 8;
            this.chairBtn.Text = "Chairss";
            this.chairBtn.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.FlatAppearance.BorderSize = 2;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(140, 205);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(131, 95);
            this.button10.TabIndex = 9;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.FlatAppearance.BorderSize = 2;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(277, 205);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(131, 95);
            this.button11.TabIndex = 10;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.FlatAppearance.BorderSize = 2;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(414, 205);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(133, 95);
            this.button12.TabIndex = 11;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.FlatAppearance.BorderSize = 2;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(3, 306);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(131, 96);
            this.button13.TabIndex = 12;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.FlatAppearance.BorderSize = 2;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(140, 306);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(131, 96);
            this.button14.TabIndex = 13;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.FlatAppearance.BorderSize = 2;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(277, 306);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(131, 96);
            this.button15.TabIndex = 14;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.FlatAppearance.BorderSize = 2;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(414, 306);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(133, 96);
            this.button16.TabIndex = 15;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.rightPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button chairBtn;
        private System.Windows.Forms.Button tableBtn;
        private System.Windows.Forms.Button ordersBtn;
        private System.Windows.Forms.Button floorsBtn;
        private System.Windows.Forms.Button foodMenuBtn;
        private System.Windows.Forms.Button foodCategoriesBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button roleBtn;
    }
}