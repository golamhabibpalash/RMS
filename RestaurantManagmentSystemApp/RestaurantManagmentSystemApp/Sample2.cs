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
    public partial class Sample2 :SampleForm
    {
        public Sample2()
        {
            InitializeComponent();
        }

        private void backPicBox_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            MainClass.showWindow(db,MDI.ActiveForm);
        }
    }
}
