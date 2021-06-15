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
    public partial class othersample : Sample
    {
        public othersample()
        {
            InitializeComponent();
        }

        public virtual void add_Click(object sender, EventArgs e)
        {

        }

        public virtual void edit_Click(object sender, EventArgs e)
        {

        }

        public virtual void save_Click(object sender, EventArgs e)
        {

        }

        public virtual void delete_Click(object sender, EventArgs e)
        {

        }

        public virtual void view_Click(object sender, EventArgs e)
        {

        }

        public virtual void searchtx_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void button1_Click(object sender, EventArgs e)
        {
            Dashboard de = new Dashboard();
            MainClass.showWindow(de, this, mdi.ActiveForm);
        }

        private void othersample_Load(object sender, EventArgs e)
        {
            userlabel.Text = ViewData.emp_name;

        }
    }
}
