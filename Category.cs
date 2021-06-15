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
    public partial class Category : othersample
    {
        ViewData vc = new ViewData();
        short stat;
        int catid;
        int Edit = 0;//this 0 represent save operation and 1 for update operation//
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftpanel);
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
            if (categoryname.Text == "") { categoryerror.Visible = true; } else { categoryerror.Visible = false; }
            if (categorystatus.SelectedIndex == -1) { categorystatuserror.Visible = true; } else { categorystatuserror.Visible = false; }


            if (categoryerror.Visible || categorystatuserror.Visible)
            {
                MainClass.Showmessage("fields with * are mandatory", "Error", "Error");
            }
            else
            {
                if (categorystatus.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (categorystatus.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (Edit == 0)//for save operation
                {

                    DialogResult dr = MessageBox.Show("Are you sure you want to insert data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Insertion ic = new Insertion();
                        ic.insertCategory(categoryname.Text,stat);
                        vc.showCategory(categorygrid, catidgv, categorynamegv, catstatusgv);
                        MainClass.disable_reset(leftpanel);
                    }
                }
                else if (Edit == 1)//for edit operation mean update
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation uc = new Updation();
                        uc.updateCategory(catid, categoryname.Text, stat);
                        vc.showCategory(categorygrid, catidgv, categorynamegv, catstatusgv);
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
                    Deletion dc = new Deletion();
                    dc.DeleteCategory(catid, "ca_deletecategory", "@id");
                    vc.showCategory(categorygrid, catidgv, categorynamegv, catstatusgv);
                }
            }
        }

        public override void view_Click(object sender, EventArgs e)
        {
            MainClass.disable(leftpanel);
            vc.showCategory(categorygrid, catidgv, categorynamegv, catstatusgv);
        }

        public override void searchtx_TextChanged(object sender, EventArgs e)
        {
            if (searchtx.Text != "")
            {
                vc.showCategory(categorygrid, catidgv, categorynamegv, catstatusgv,searchtx.Text);
            }
            else
            {
                vc.showCategory(categorygrid, catidgv, categorynamegv, catstatusgv);
            }
        }

        private void categorygrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Edit = 1;
                DataGridViewRow row = categorygrid.Rows[e.RowIndex];
                catid = Convert.ToInt32(row.Cells["catidgv"].Value.ToString());
                categoryname.Text = (row.Cells["categorynamegv"].Value.ToString());
                categorystatus.SelectedItem = (row.Cells["catstatusgv"].Value.ToString());
                MainClass.disable(leftpanel);
            }
        }
        }

        
    }

