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
    public partial class Dashboard : Sample
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void users_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            MainClass.showWindow(us, this, mdi.ActiveForm);
        }

        private void products_Click(object sender, EventArgs e)
        {
            Products pr = new Products();
            MainClass.showWindow(pr, this, mdi.ActiveForm);
        }

        private void category_Click(object sender, EventArgs e)
        {
            Category ca = new Category();
            MainClass.showWindow(ca, this, mdi.ActiveForm);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            userlabel.Text = ViewData.emp_name;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            MainClass.showWindow(log, this, mdi.ActiveForm);
        }

        private void supplier_Click(object sender, EventArgs e)
        {
            Supplier log = new Supplier();
            MainClass.showWindow(log, this, mdi.ActiveForm);
        }

        private void purchasesupplier_Click(object sender, EventArgs e)
        {
            PurchaseSupplier ps = new PurchaseSupplier();
            MainClass.showWindow(ps, this, mdi.ActiveForm);
        }

        private void stocks_Click(object sender, EventArgs e)
        {
            Stocks st = new Stocks();
            MainClass.showWindow(st, this, mdi.ActiveForm);
        }

        private void sales_Click(object sender, EventArgs e)
        {
            Sales st = new Sales();
            MainClass.showWindow(st, this, mdi.ActiveForm);
        }

        private void productpricing_Click(object sender, EventArgs e)
        {
            Productpricing st = new Productpricing();
            MainClass.showWindow(st, this, mdi.ActiveForm);
        }

        private void salesreturn_Click(object sender, EventArgs e)
        {
            SalesReturn st = new SalesReturn();
            MainClass.showWindow(st, this, mdi.ActiveForm);
        }
    }
}
