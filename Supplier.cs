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
    public partial class Supplier : othersample
    {
        ViewData s = new ViewData();
        short stat;
        int supid;
        int Edit = 0;//this 0 represent save operation and 1 for update operation//
        public Supplier()
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
            if (companyname.Text == "") { companyerror.Visible = true; } else { companyerror.Visible = false; }
            if (address.Text == "") { addresserror.Visible = true; } else { addresserror.Visible = false; }
            if (contactperson.Text == "") { personerror.Visible = true; } else { personerror.Visible = false; }
            if (contact.Text == "") { personnumbererror.Visible = true; } else { personnumbererror.Visible = false; }
            if (status.SelectedIndex == -1) { statuserror.Visible = true; } else { statuserror.Visible = false; }


            if (companyerror.Visible || addresserror.Visible || personerror.Visible || personnumbererror.Visible || statuserror.Visible)
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
                        i.insertSupplier(companyname.Text, address.Text, contactperson.Text, contact.Text, ntnumber.Text, stat);
                        s.showsupplier(suppliergrid,suppidgv,companygv,addressgv,contactpersongv,contactnumbergv,ntngv,statusgv);
                        MainClass.disable_reset(leftpanel);
                    }
                }
                else if (Edit == 1)//for edit operation mean update
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        u.updateSupplier(supid, companyname.Text, address.Text, contactperson.Text, contact.Text, ntnumber.Text, stat);
                        s.showsupplier(suppliergrid, suppidgv, companygv, addressgv, contactpersongv, contactnumbergv, ntngv, statusgv);
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
                    d.DeleteSupplier(supid, "su_deletesupplier", "@suppid");
                    s.showsupplier(suppliergrid, suppidgv, companygv, addressgv, contactpersongv, contactnumbergv, ntngv, statusgv);
                }
            }
        }

        public override void view_Click(object sender, EventArgs e)
        {
            MainClass.disable(leftpanel);
            s.showsupplier(suppliergrid, suppidgv, companygv, addressgv, contactpersongv, contactnumbergv, ntngv, statusgv);
        }

        public override void searchtx_TextChanged(object sender, EventArgs e)
        {
            if (searchtx.Text != "")
            {
                s.showsupplier(suppliergrid, suppidgv, companygv, addressgv, contactpersongv, contactnumbergv, ntngv, statusgv,searchtx.Text);
            }
            else
            {
                s.showsupplier(suppliergrid, suppidgv, companygv, addressgv, contactpersongv, contactnumbergv, ntngv, statusgv);
            }
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            Dashboard de = new Dashboard();
            MainClass.showWindow(de, this, mdi.ActiveForm);
        }

        private void othersample_Load(object sender, EventArgs e)
        {
            userlabel.Text = ViewData.emp_name;
        }

        private void suppliergrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        if (e.RowIndex != -1)
            {
                Edit = 1;
                DataGridViewRow row = suppliergrid.Rows[e.RowIndex];
                supid = Convert.ToInt32(row.Cells["suppidgv"].Value.ToString());
                companyname.Text = (row.Cells["companygv"].Value.ToString());
                address.Text = (row.Cells["addressgv"].Value.ToString());
                contactperson.Text = (row.Cells["contactpersongv"].Value.ToString());
                contact.Text = (row.Cells["contactnumbergv"].Value.ToString());
                ntnumber.Text = (row.Cells["ntngv"].Value.ToString());
                status.SelectedItem = (row.Cells["statusgv"].Value.ToString());
                MainClass.disable(leftpanel);
            }
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftpanel);
        }
    }

}