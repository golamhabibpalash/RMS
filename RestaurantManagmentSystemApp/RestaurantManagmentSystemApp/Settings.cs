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
using System.Xml;
using System.IO;

namespace RestaurantManagmentSystemApp
{
    public partial class Settings : SampleForm
    {
        public Settings()
        {
            InitializeComponent();
        }
        string connection;

        private void sarverTbox_TextChanged(object sender, EventArgs e)
        {
            if (serverTbox.Text == "") { serverErrorLable.Visible = true; } else { serverErrorLable.Visible = false; }
        }

        private void databaseTBox_TextChanged(object sender, EventArgs e)
        {
            if (databaseTBox.Text == "") { databaseErrorLabel.Visible = true; } else { databaseErrorLabel.Visible = false; }
        }

        private void integratedSecuritycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (integratedSecuritycheckBox.Checked)
            {
                uNameTBox.Hide();
                passwordTBox.Hide();
                usernameLabel.Hide();
                passwordLabel.Hide();

                usernameErrorLable.Visible = false;
                passwordErrorLabel.Visible = false;
                uNameTBox.Enabled = false;
                passwordTBox.Enabled = false;
                uNameTBox.Text = "";
                passwordTBox.Text = "";
            }
            else
            {
                uNameTBox.Visible = true;
                usernameLabel.Visible = true;
                passwordLabel.Visible = true;
                passwordTBox.Visible = true;

                uNameTBox.Enabled = true;
                passwordTBox.Enabled = true;
            }
        }

        private void uNameTBox_TextChanged(object sender, EventArgs e)
        {
            if (!integratedSecuritycheckBox.Checked)
            {
                if (uNameTBox.Text == "") { usernameErrorLable.Visible = true; } else { usernameErrorLable.Visible = false; }
            }
        }

        private void passwordTBox_TextChanged(object sender, EventArgs e)
        {
            if (!integratedSecuritycheckBox.Checked)
            {
                if (passwordTBox.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
            }
            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (integratedSecuritycheckBox.Checked)
            {

                if (serverTbox.Text == "") { serverErrorLable.Visible = true; } else { serverErrorLable.Visible = false; }
                if (databaseTBox.Text == "") { databaseErrorLabel.Visible = true; } else { databaseErrorLabel.Visible = false; }
                if (serverErrorLable.Visible || databaseErrorLabel.Visible)
                {
                    MainClass.showMessage("Fields with * are Mandetory","Error");
                }
                else
                {
                    connection = "data source="+serverTbox.Text+";Initial catalog="+databaseTBox.Text+";integrated security=true;multipleactiveresultsets=true;";
                    saveConnection();
                    DialogResult dr = MessageBox.Show("Setting Saved Successfully");
                    if (dr==DialogResult.OK)
                    {
                        Login ls = new Login();
                        MainClass.showWindow(ls,this,MDI.ActiveForm);
                    }
                    
                }
            }
            else
            {
                if (serverTbox.Text == "") { serverErrorLable.Visible = true; } else { serverErrorLable.Visible = false; }
                if (databaseTBox.Text == "") { databaseErrorLabel.Visible = true; } else { databaseErrorLabel.Visible = false; }
                if (uNameTBox.Text == "") { usernameErrorLable.Visible = true; } else { usernameErrorLable.Visible = false; }
                if (passwordTBox.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
                if (serverErrorLable.Visible || databaseErrorLabel.Visible || usernameErrorLable.Visible||passwordErrorLabel.Visible)
                {
                    MainClass.showMessage("Fields with * are Mandetory", "Error");
                }
                else
                {
                    connection = "data source=" + serverTbox.Text + ";Initial catalog=" + databaseTBox.Text +";User ID="+uNameTBox.Text+";Password="+passwordTBox.Text+";multipleactiveresultsets=true;";
                    updateConfigFile(connection);
                    DialogResult dr = MessageBox.Show("Setting Saved Successfully");
                    if (dr == DialogResult.OK)
                    {
                        Login ls = new Login();
                        MainClass.showWindow(ls, this, MDI.ActiveForm);
                    }
                }
            }
        }

        private void saveConnection()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\rms_connect";
            File.WriteAllText(path, connection);
        }

        private void updateConfigFile(string con)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xmlElement in xDoc.DocumentElement)
            {
                if (xmlElement.Name=="connectionStrings")
                {
                    xmlElement.FirstChild.Attributes[2].Value = con;
                }
            }
            xDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
