using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagmentSystemApp
{
    class MainClass
    {
        public static void showWindow(Form openWin, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWin.MdiParent = MDI;
            openWin.Show();
            openWin.WindowState = FormWindowState.Maximized;
        }
        public static void showWindow(Form openWin,Form MDI)
        {

            openWin.MdiParent = MDI;
            openWin.Show();
            openWin.WindowState = FormWindowState.Maximized;
        }
        public static void showMessage(string msg, string type)
        {
            if (type=="success")
            {
                MessageBox.Show(msg,"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (type=="error")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
