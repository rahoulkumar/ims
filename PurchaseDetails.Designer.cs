namespace inventorymanagementsystem
{
    partial class PurchaseDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grandtotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.detailsgrid = new System.Windows.Forms.DataGridView();
            this.pidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnamegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitygv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perunitpricegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actiongv = new System.Windows.Forms.DataGridViewButtonColumn();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.invoice = new System.Windows.Forms.ComboBox();
            this.leftpanel.SuspendLayout();
            this.topleft.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.topright.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1170, 52);
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
            this.leftpanel.Controls.Add(this.invoice);
            this.leftpanel.Controls.Add(this.date);
            this.leftpanel.Controls.Add(this.label8);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Size = new System.Drawing.Size(200, 749);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.label8, 0);
            this.leftpanel.Controls.SetChildIndex(this.topleft, 0);
            this.leftpanel.Controls.SetChildIndex(this.date, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.invoice, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.detailsgrid);
            this.rightpanel.Controls.Add(this.panel4);
            this.rightpanel.Controls.Add(this.label7);
            this.rightpanel.Size = new System.Drawing.Size(1170, 749);
            this.rightpanel.Controls.SetChildIndex(this.label7, 0);
            this.rightpanel.Controls.SetChildIndex(this.panel4, 0);
            this.rightpanel.Controls.SetChildIndex(this.topright, 0);
            this.rightpanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.detailsgrid, 0);
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
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(376, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(436, 56);
            this.label7.TabIndex = 51;
            this.label7.Text = "Grand Total:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.grandtotal);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1170, 749);
            this.panel4.TabIndex = 53;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1170, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // grandtotal
            // 
            this.grandtotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grandtotal.Location = new System.Drawing.Point(815, 713);
            this.grandtotal.Name = "grandtotal";
            this.grandtotal.Size = new System.Drawing.Size(589, 65);
            this.grandtotal.TabIndex = 1;
            this.grandtotal.Text = "0.00";
            this.grandtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(6, 713);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(806, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "Grand Total:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detailsgrid
            // 
            this.detailsgrid.AllowUserToAddRows = false;
            this.detailsgrid.AllowUserToDeleteRows = false;
            this.detailsgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailsgrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.detailsgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidgv,
            this.productidgv,
            this.productnamegv,
            this.quantitygv,
            this.perunitpricegv,
            this.totalamountgv,
            this.actiongv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailsgrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.detailsgrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsgrid.Location = new System.Drawing.Point(0, 152);
            this.detailsgrid.Name = "detailsgrid";
            this.detailsgrid.ReadOnly = true;
            this.detailsgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detailsgrid.Size = new System.Drawing.Size(1170, 558);
            this.detailsgrid.TabIndex = 54;
            this.detailsgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detailsgrid_CellClick);
            this.detailsgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pidgv
            // 
            this.pidgv.HeaderText = "pid";
            this.pidgv.Name = "pidgv";
            this.pidgv.ReadOnly = true;
            this.pidgv.Visible = false;
            // 
            // productidgv
            // 
            this.productidgv.HeaderText = "Productid";
            this.productidgv.Name = "productidgv";
            this.productidgv.ReadOnly = true;
            this.productidgv.Visible = false;
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
            // totalamountgv
            // 
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
            // date
            // 
            this.date.CustomFormat = "MMMM-yyyy";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(6, 228);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(180, 22);
            this.date.TabIndex = 48;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 51;
            this.label8.Text = "Select Company";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Select Date";
            // 
            // invoice
            // 
            this.invoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.invoice.FormattingEnabled = true;
            this.invoice.Location = new System.Drawing.Point(6, 290);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(179, 24);
            this.invoice.TabIndex = 3;
            this.invoice.SelectedIndexChanged += new System.EventHandler(this.invoice_SelectedIndexChanged);
            // 
            // PurchaseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Name = "PurchaseDetails";
            this.Text = "PurchaseDetails";
            this.Load += new System.EventHandler(this.PurchaseDetails_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.topleft.ResumeLayout(false);
            this.topleft.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.topright.ResumeLayout(false);
            this.topright.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView detailsgrid;
        private System.Windows.Forms.Label grandtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox invoice;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnamegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitygv;
        private System.Windows.Forms.DataGridViewTextBoxColumn perunitpricegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountgv;
        private System.Windows.Forms.DataGridViewButtonColumn actiongv;
    }
}