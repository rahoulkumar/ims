using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventorymanagementsystem
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

       

        private void rightpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            if (system.Checked)
            {
                if (server.Text != "" && database.Text != "")
                {
                    s = "Data Source=" + server.Text + ";Initial Catalog=" + database.Text + ";Integrated Security=true;MultipleActiveResultSets=true;";
                    File.WriteAllText(path + "\\connection", s);
                    DialogResult dr = MessageBox.Show("Are you sure you want to settings of database?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (dr == DialogResult.Yes)
                    {
                        DialogResult res = MessageBox.Show("Settings Saved sucessfully", "Stored", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login log = new Login();
                        MainClass.showWindow(log, this, mdi.ActiveForm);
                    }
                }
                else
                {
                    if (server.Text == "") { serverror.Visible = true; } else { serverror.Visible = false; }
                    if (database.Text == "") { databaserror.Visible = true; } else { databaserror.Visible = false; }
                   



                    if (serverror.Visible || databaserror.Visible)
                    {
                        MainClass.Showmessage("fields with * are mandatory", "Error", "Error");
                    }
                }
            }
            else
            {
                if (server.Text != "" && database.Text != "" && username.Text != "" && password.Text != "")
                {
                    s = "Data Source=" + server.Text + ";Initial Catalog=" + database.Text + ";User ID=" + username.Text + ";Password=" + password.Text + ";MultipleActiveResultSets=true;";
                    File.WriteAllText(path + "\\connection", s);
                    DialogResult dr = MessageBox.Show("Are you sure you want to settings of database?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (dr == DialogResult.Yes)
                    {
                        DialogResult res = MessageBox.Show("Settings Saved Successfully", "Stored", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login log = new Login();
                        MainClass.showWindow(log, this, mdi.ActiveForm);
                    }
                }
                else
                {
                    if (server.Text == "") { serverror.Visible = true; } else { serverror.Visible = false; }
                    if (database.Text == "") { databaserror.Visible = true; } else { databaserror.Visible = false; }
                    if (username.Text == "") { usernameerror.Visible = true; } else { usernameerror.Visible = false; }
                    if (password.Text == "") { passworderror.Visible = true; } else { passworderror.Visible = false; }



                    if (serverror.Visible || databaserror.Visible || usernameerror.Visible || passworderror.Visible)
                    {
                        MainClass.Showmessage("fields with * are mandatory", "Error", "Error");
                    }
                }
            }


        

        }

        

        private void system_CheckedChanged(object sender, EventArgs e)
        {
            if (system.Checked)
            {
                username.Enabled = false;
                password.Enabled = false;
                username.Text = "";
                password.Text = "";
            }
            else
            {
                username.Enabled = true;
                password.Enabled = true;
            }
        
        }
    }
}
