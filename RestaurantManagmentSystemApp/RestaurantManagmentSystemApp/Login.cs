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
    public partial class Login : SampleForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            MainClass.showWindow(db, this, MDI.ActiveForm);
        }
    }
}
