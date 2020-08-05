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
    public partial class Dashboard : SampleForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void roleBtn_Click(object sender, EventArgs e)
        {
            Roles db = new Roles();
            MainClass.showWindow(db, this, MDI.ActiveForm);
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            Users db = new Users();
            MainClass.showWindow(db, this, MDI.ActiveForm);
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            Customers db = new Customers();
            MainClass.showWindow(db, this, MDI.ActiveForm);
        }
    }
}
