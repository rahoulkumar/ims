namespace inventorymanagementsystem
{
    partial class Sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barcodes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salesgrid = new System.Windows.Forms.DataGridView();
            this.proidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnamegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitygv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perunitpricegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actiongv = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.grandtotal = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.Button();
            this.payment = new System.Windows.Forms.GroupBox();
            this.checkout = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.TextBox();
            this.amountgiven = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.paymenttype = new System.Windows.Forms.ComboBox();
            this.finaldiscount = new System.Windows.Forms.TextBox();
            this.finalgrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.leftpanel.SuspendLayout();
            this.topleft.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.topright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesgrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.payment.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1170, 52);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            // 
            // searchtx
            // 
            this.searchtx.Size = new System.Drawing.Size(188, 20);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.payment);
            this.leftpanel.Controls.Add(this.panel4);
            this.leftpanel.Size = new System.Drawing.Size(200, 749);
            this.leftpanel.Controls.SetChildIndex(this.topleft, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftpanel.Controls.SetChildIndex(this.payment, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.panel3);
            this.rightpanel.Controls.Add(this.salesgrid);
            this.rightpanel.Size = new System.Drawing.Size(1170, 749);
            this.rightpanel.Controls.SetChildIndex(this.topright, 0);
            this.rightpanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.salesgrid, 0);
            this.rightpanel.Controls.SetChildIndex(this.panel3, 0);
            // 
            // topright
            // 
            this.topright.Size = new System.Drawing.Size(1170, 100);
            // 
            // userlabel
            // 
            this.userlabel.Size = new System.Drawing.Size(0, 19);
            this.userlabel.Text = "";
            // 
            // barcodes
            // 
            this.barcodes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodes.Location = new System.Drawing.Point(7, 9);
            this.barcodes.MaxLength = 60;
            this.barcodes.Name = "barcodes";
            this.barcodes.Size = new System.Drawing.Size(179, 20);
            this.barcodes.TabIndex = 40;
            this.barcodes.Validating += new System.ComponentModel.CancelEventHandler(this.barcodes_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Product Barcode";
            // 
            // salesgrid
            // 
            this.salesgrid.AllowUserToAddRows = false;
            this.salesgrid.AllowUserToDeleteRows = false;
            this.salesgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesgrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.salesgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salesgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proidgv,
            this.productnamegv,
            this.quantitygv,
            this.perunitpricegv,
            this.discountgv,
            this.totalamountgv,
            this.actiongv});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.salesgrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesgrid.Location = new System.Drawing.Point(0, 152);
            this.salesgrid.Name = "salesgrid";
            this.salesgrid.ReadOnly = true;
            this.salesgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesgrid.Size = new System.Drawing.Size(1170, 553);
            this.salesgrid.TabIndex = 3;
            this.salesgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesgrid_CellClick);
            // 
            // proidgv
            // 
            this.proidgv.HeaderText = "Product id";
            this.proidgv.Name = "proidgv";
            this.proidgv.ReadOnly = true;
            this.proidgv.Visible = false;
            // 
            // productnamegv
            // 
            this.productnamegv.HeaderText = "Product Name";
            this.productnamegv.Name = "productnamegv";
            this.productnamegv.ReadOnly = true;
            // 
            // quantitygv
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.quantitygv.DefaultCellStyle = dataGridViewCellStyle1;
            this.quantitygv.HeaderText = "Quantity";
            this.quantitygv.Name = "quantitygv";
            this.quantitygv.ReadOnly = true;
            // 
            // perunitpricegv
            // 
            this.perunitpricegv.HeaderText = "Per Unit Price";
            this.perunitpricegv.Name = "perunitpricegv";
            this.perunitpricegv.ReadOnly = true;
            // 
            // discountgv
            // 
            this.discountgv.HeaderText = "Discount";
            this.discountgv.Name = "discountgv";
            this.discountgv.ReadOnly = true;
            // 
            // totalamountgv
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.totalamountgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.totalamountgv.HeaderText = "Total Amount";
            this.totalamountgv.Name = "totalamountgv";
            this.totalamountgv.ReadOnly = true;
            // 
            // actiongv
            // 
            this.actiongv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.actiongv.HeaderText = "Action";
            this.actiongv.Name = "actiongv";
            this.actiongv.ReadOnly = true;
            this.actiongv.Text = "Delete";
            this.actiongv.UseColumnTextForButtonValue = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.grandtotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 705);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1170, 44);
            this.panel3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(132, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(531, 56);
            this.label7.TabIndex = 51;
            this.label7.Text = "Grand Total:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grandtotal
            // 
            this.grandtotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grandtotal.Location = new System.Drawing.Point(669, 6);
            this.grandtotal.Name = "grandtotal";
            this.grandtotal.Size = new System.Drawing.Size(455, 53);
            this.grandtotal.TabIndex = 52;
            this.grandtotal.Text = "0.00";
            this.grandtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pay
            // 
            this.pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pay.FlatAppearance.BorderSize = 0;
            this.pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay.Location = new System.Drawing.Point(10, 266);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(172, 41);
            this.pay.TabIndex = 11;
            this.pay.Text = "&Pay Amount";
            this.pay.UseVisualStyleBackColor = false;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // payment
            // 
            this.payment.Controls.Add(this.checkout);
            this.payment.Controls.Add(this.change);
            this.payment.Controls.Add(this.amountgiven);
            this.payment.Controls.Add(this.label8);
            this.payment.Controls.Add(this.label9);
            this.payment.Controls.Add(this.paymenttype);
            this.payment.Controls.Add(this.finaldiscount);
            this.payment.Controls.Add(this.finalgrand);
            this.payment.Controls.Add(this.label4);
            this.payment.Controls.Add(this.label5);
            this.payment.Controls.Add(this.label6);
            this.payment.Controls.Add(this.pay);
            this.payment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.payment.Location = new System.Drawing.Point(0, 186);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(200, 563);
            this.payment.TabIndex = 5;
            this.payment.TabStop = false;
            this.payment.Text = "Payment Methods";
            // 
            // checkout
            // 
            this.checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkout.FlatAppearance.BorderSize = 0;
            this.checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkout.Location = new System.Drawing.Point(8, 320);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(172, 47);
            this.checkout.TabIndex = 49;
            this.checkout.Text = "&Check Out";
            this.checkout.UseVisualStyleBackColor = false;
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // change
            // 
            this.change.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(6, 234);
            this.change.MaxLength = 60;
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(179, 20);
            this.change.TabIndex = 45;
            // 
            // amountgiven
            // 
            this.amountgiven.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountgiven.Location = new System.Drawing.Point(6, 192);
            this.amountgiven.MaxLength = 60;
            this.amountgiven.Name = "amountgiven";
            this.amountgiven.Size = new System.Drawing.Size(179, 20);
            this.amountgiven.TabIndex = 46;
            this.amountgiven.TextChanged += new System.EventHandler(this.amountgiven_TextChanged);
            this.amountgiven.Validating += new System.ComponentModel.CancelEventHandler(this.amountgiven_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Change to Give";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "Amount Given";
            // 
            // paymenttype
            // 
            this.paymenttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymenttype.FormattingEnabled = true;
            this.paymenttype.Items.AddRange(new object[] {
            "Cash",
            "Debit Card",
            "Credit Card"});
            this.paymenttype.Location = new System.Drawing.Point(8, 145);
            this.paymenttype.Name = "paymenttype";
            this.paymenttype.Size = new System.Drawing.Size(179, 24);
            this.paymenttype.TabIndex = 15;
            // 
            // finaldiscount
            // 
            this.finaldiscount.Enabled = false;
            this.finaldiscount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finaldiscount.Location = new System.Drawing.Point(7, 95);
            this.finaldiscount.MaxLength = 60;
            this.finaldiscount.Name = "finaldiscount";
            this.finaldiscount.Size = new System.Drawing.Size(179, 20);
            this.finaldiscount.TabIndex = 41;
            // 
            // finalgrand
            // 
            this.finalgrand.Enabled = false;
            this.finalgrand.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalgrand.Location = new System.Drawing.Point(7, 53);
            this.finalgrand.MaxLength = 60;
            this.finalgrand.Name = "finalgrand";
            this.finalgrand.Size = new System.Drawing.Size(179, 20);
            this.finalgrand.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Payment Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Grand Total";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.barcodes);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 34);
            this.panel4.TabIndex = 5;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.leftpanel.ResumeLayout(false);
            this.topleft.ResumeLayout(false);
            this.topleft.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.topright.ResumeLayout(false);
            this.topright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesgrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.payment.ResumeLayout(false);
            this.payment.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox barcodes;
        private System.Windows.Forms.DataGridView salesgrid;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label grandtotal;
        private System.Windows.Forms.GroupBox payment;
        private System.Windows.Forms.TextBox finaldiscount;
        private System.Windows.Forms.TextBox finalgrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox paymenttype;
        private System.Windows.Forms.Button checkout;
        private System.Windows.Forms.TextBox change;
        private System.Windows.Forms.TextBox amountgiven;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn proidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnamegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitygv;
        private System.Windows.Forms.DataGridViewTextBoxColumn perunitpricegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountgv;
        private System.Windows.Forms.DataGridViewButtonColumn actiongv;

    }
}