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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Width += 10;
            if (pictureBox1.Width >= 300)
            {
                timer1.Stop();
                mdi MD = new mdi();
                MD.Show();
                this.Hide();

            }
        }
    }
}
