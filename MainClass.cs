using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace inventorymanagementsystem
{
    class MainClass
    {
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string s = File.ReadAllText(path + "\\connection");
        public static SqlConnection con = new SqlConnection(s);

        public static DialogResult Showmessage(string msg, string heading, string type)
        {
            if (type == "Success")
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void showWindow(Form openWin, Form clsWin, Form mdiwin)
        {
            clsWin.Close();
            openWin.MdiParent = mdiwin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
        public static void showWindow(Form openWin, Form mdiwin)
        {

            openWin.MdiParent = mdiwin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
        public static void disable_reset(Panel E)
        {
            foreach (Control i in E.Controls)
            {
                if (i is TextBox)
                {
                    TextBox tex = (TextBox)i;
                    tex.Enabled = false;
                    tex.Text = "";
                }
                if (i is ComboBox)
                {
                    ComboBox com = (ComboBox)i;
                    com.Enabled = false;
                    com.SelectedIndex = -1;
                }
                if (i is RadioButton)
                {
                    RadioButton rad = (RadioButton)i;
                    rad.Enabled = false;
                    rad.Checked = false;
                }
                if (i is CheckBox)
                {
                    CheckBox che = (CheckBox)i;
                    che.Enabled = false;
                    che.Checked = false;
                }
                if (i is DateTimePicker)
                {
                    DateTimePicker che = (DateTimePicker)i;
                    che.Enabled = false;
                    che.Value = DateTime.Now;

                }
            }

        }
        public static void disable(Panel E)
        {
            foreach (Control i in E.Controls)
            {
                if (i is TextBox)
                {
                    TextBox tex = (TextBox)i;
                    tex.Enabled = false;

                }
                if (i is ComboBox)
                {
                    ComboBox com = (ComboBox)i;
                    com.Enabled = false;

                }
                if (i is RadioButton)
                {
                    RadioButton rad = (RadioButton)i;
                    rad.Enabled = false;

                }
                if (i is CheckBox)
                {
                    CheckBox che = (CheckBox)i;
                    che.Enabled = false;

                }
                if (i is DateTimePicker)
                {
                    DateTimePicker che = (DateTimePicker)i;
                    che.Enabled = false;

                }
            }

        }
        public static void reset(Panel E)
        {
            foreach (Control i in E.Controls)
            {
                if (i is TextBox)
                {
                    TextBox tex = (TextBox)i;

                    tex.Text = "";
                }
                if (i is ComboBox)
                {
                    ComboBox com = (ComboBox)i;

                    com.SelectedIndex = -1;
                }
                if (i is RadioButton)
                {
                    RadioButton rad = (RadioButton)i;

                    rad.Checked = false;
                }
                if (i is CheckBox)
                {
                    CheckBox che = (CheckBox)i;

                    che.Checked = false;
                }
                if (i is DateTimePicker)
                {
                    DateTimePicker che = (DateTimePicker)i;
                    che.Value = DateTime.Now;

                }
            }

        }
        public static void enable_reset(Panel E)
        {
            foreach (Control i in E.Controls)
            {
                if (i is TextBox)
                {
                    TextBox tex = (TextBox)i;
                    tex.Enabled = true;
                    tex.Text = "";
                }
                if (i is ComboBox)
                {
                    ComboBox com = (ComboBox)i;
                    com.Enabled = true;
                    com.SelectedIndex = -1;
                }
                if (i is RadioButton)
                {
                    RadioButton rad = (RadioButton)i;
                    rad.Enabled = true;
                    rad.Checked = false;
                }
                if (i is CheckBox)
                {
                    CheckBox che = (CheckBox)i;
                    che.Enabled = true;
                    che.Checked = false;
                }
                if (i is DateTimePicker)
                {
                    DateTimePicker che = (DateTimePicker)i;
                    che.Enabled = true;
                    che.Value = DateTime.Now;

                }
            }

        }

        public static void enable(Panel E)
        {
            foreach (Control i in E.Controls)
            {
                if (i is TextBox)
                {
                    TextBox tex = (TextBox)i;
                    tex.Enabled = true;

                }
                if (i is ComboBox)
                {
                    ComboBox com = (ComboBox)i;
                    com.Enabled = true;

                }
                if (i is RadioButton)
                {
                    RadioButton rad = (RadioButton)i;
                    rad.Enabled = true;

                }
                if (i is CheckBox)
                {
                    CheckBox che = (CheckBox)i;
                    che.Enabled = true;

                }
                if (i is DateTimePicker)
                {
                    DateTimePicker che = (DateTimePicker)i;
                    che.Enabled = true;


                }
            }

        }
        public static void enable_reset(GroupBox gb)
        {
            foreach (Control i in gb.Controls)
            {
                if (i is TextBox)
                {
                    TextBox tex = (TextBox)i;
                    tex.Enabled = true;
                    tex.Text = "";
                }
                if (i is ComboBox)
                {
                    ComboBox com = (ComboBox)i;
                    com.Enabled = true;
                    com.SelectedIndex = -1;
                }
                if (i is RadioButton)
                {
                    RadioButton rad = (RadioButton)i;
                    rad.Enabled = true;
                    rad.Checked = false;
                }
                if (i is CheckBox)
                {
                    CheckBox che = (CheckBox)i;
                    che.Enabled = true;
                    che.Checked = false;
                }
                if (i is DateTimePicker)
                {
                    DateTimePicker che = (DateTimePicker)i;
                    che.Enabled = true;
                    che.Value = DateTime.Now;

                }
            }

        }
    }
}
