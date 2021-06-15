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
    public partial class Users : othersample
    {
        ViewData v = new ViewData();
        short stat;
        int userid;
        int Edit = 0;//this 0 represent save operation and 1 for update operation//
        
        public Users()
        {
            InitializeComponent();
        }
        public override void add_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftpanel);
            Edit = 0;
        }

        public override void edit_Click(object sender, EventArgs e)
        {
            Edit = 1;
            MainClass.enable(leftpanel);
        }

        public override void save_Click(object sender, EventArgs e)
        {
            if (name.Text == "") { nameerror.Visible = true; } else { nameerror.Visible = false; }
            if (gender.Text == "") { gendererror.Visible = true; } else { gendererror.Visible = false; }
            if (usernames.Text == "") { usernamerror.Visible = true; } else { usernamerror.Visible = false; }
            if (email.Text == "") { emailerror.Visible = true; } else { emailerror.Visible = false; }
            if (password.Text == "") { passworderror.Visible = true; } else { passworderror.Visible = false; }
            if (phone.Text == "") { phoneerror.Visible = true; } else { phoneerror.Visible = false; }
            if (status.SelectedIndex==-1) { statuserror.Visible = true; } else { statuserror.Visible = false; }


            if (nameerror.Visible || gendererror.Visible || usernamerror.Visible || emailerror.Visible || passworderror.Visible || phoneerror.Visible || statuserror.Visible)
            {
                MainClass.Showmessage("fields with * are mandatory", "Error", "Error");
            }
            else
            {
                if (status.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (status.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (Edit == 0)//for save operation
                {
                    
                    DialogResult dr = MessageBox.Show("Are you sure you want to insert data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Insertion i = new Insertion();
                        i.insertUsers(name.Text, gender.Text, usernames.Text, email.Text, password.Text, phone.Text, stat);
                        v.showusers(dataGridView1, useridgv, namegv, usernamegv, gendergv, emailgv, passwordgv, phonegv, statusgv);
                        MainClass.disable_reset(leftpanel);
                    }
                }
                else if (Edit == 1)//for edit operation mean update
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        u.updateUsers(userid, name.Text, gender.Text, usernames.Text, email.Text, password.Text, phone.Text, stat);
                        v.showusers(dataGridView1, useridgv, namegv, usernamegv, gendergv, emailgv, passwordgv, phonegv, statusgv);
                        MainClass.disable_reset(leftpanel);
                    }

                }

            }
        }
        

        public override void delete_Click(object sender, EventArgs e)
        {
            
            if (Edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.DeleteUsers(userid, "us_deletepeople", "@id");
                    v.showusers(dataGridView1, useridgv, namegv, usernamegv, gendergv, emailgv, passwordgv, phonegv, statusgv);
                }
            }
        }

        public override void view_Click(object sender, EventArgs e)
        {
             MainClass.disable(leftpanel);
            v.showusers(dataGridView1, useridgv, namegv, usernamegv, gendergv, emailgv, passwordgv, phonegv, statusgv);
        }

        public override void searchtx_TextChanged(object sender, EventArgs e)
        {
            if (searchtx.Text != "")
            {
                v.showusers(dataGridView1, useridgv, namegv, usernamegv, gendergv, emailgv, passwordgv, phonegv, statusgv,searchtx.Text);
            }
            else
            {
                v.showusers(dataGridView1, useridgv, namegv, usernamegv, gendergv, emailgv, passwordgv, phonegv, statusgv);
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftpanel);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              if (e.RowIndex != -1)
            {
                Edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userid = Convert.ToInt32(row.Cells["useridgv"].Value.ToString());
                name.Text = (row.Cells["namegv"].Value.ToString());
                usernames.Text = (row.Cells["usernamegv"].Value.ToString());
                gender.Text = (row.Cells["gendergv"].Value.ToString());
                email.Text = (row.Cells["emailgv"].Value.ToString());
                password.Text = (row.Cells["passwordgv"].Value.ToString());
                phone.Text = (row.Cells["phonegv"].Value.ToString());
                status.SelectedItem = (row.Cells["statusgv"].Value.ToString());
                MainClass.disable(leftpanel);
            }
        }
        }
    }

