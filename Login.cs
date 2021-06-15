using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventorymanagementsystem
{
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, EventArgs e)
        {
            //if (user.Text == "") { usererror.Visible = true; } else { usererror.Visible = false; }
            //if (pass.Text == "") { passerror.Visible = true; } else { passerror.Visible = false; }
            //if (usererror.Visible || passerror.Visible)
            //{
            //    MainClass.Showmessage("fields with * are mandatory", "Error", "Error");
            //}
            //else
            //{
            //    if (user.Text != "" && pass.Text != "")
            //    {
            //        if (ViewData.getuser(user.Text, pass.Text))
            //        {
            //            MainClass.Showmessage("Login Successfully", "Success", "Success");
                        Dashboard de = new Dashboard();
                        MainClass.showWindow(de, this, mdi.ActiveForm);
            //        }
            //    }
            //}
        }
    }
}