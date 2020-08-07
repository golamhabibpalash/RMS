using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagmentSystemApp
{
    public partial class Roles : Sample2
    {
        public Roles()
        {
            InitializeComponent();
        }

        int edit = 0;
        private void roleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (roleTextBox.Text == "") { roleErrorLabel.Visible = true; } else { roleErrorLabel.Visible = false; }
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void ssearchGroupBox_Enter(object sender, EventArgs e)
        {

        }

        public override void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
