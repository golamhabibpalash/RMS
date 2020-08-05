using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace RestaurantManagmentSystemApp
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.ConnectionStrings["con"].ConnectionString=="")
            {
                Settings obj = new Settings();
                MainClass.showWindow(obj,this);
            }

            else
            {
                Login ls = new Login();
                MainClass.showWindow(ls, MDI.ActiveForm);
            }
            
        }
    }
}
