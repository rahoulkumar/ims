namespace inventorymanagementsystem
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.categoryerror = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.expiryerror = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productname = new System.Windows.Forms.TextBox();
            this.brandname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.barcoderror = new System.Windows.Forms.Label();
            this.productnameerror = new System.Windows.Forms.Label();
            this.expirydate = new System.Windows.Forms.DateTimePicker();
            this.categorynames = new System.Windows.Forms.ComboBox();
            this.productsgrids = new System.Windows.Forms.DataGridView();
            this.productidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnamegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandnamegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productbarcodegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirydategv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorygv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.topleft.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.topright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsgrids)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.categorynames);
            this.leftpanel.Controls.Add(this.expirydate);
            this.leftpanel.Controls.Add(this.label8);
            this.leftpanel.Controls.Add(this.label2);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.barcode);
            this.leftpanel.Controls.Add(this.brandname);
            this.leftpanel.Controls.Add(this.productname);
            this.leftpanel.Controls.Add(this.categoryerror);
            this.leftpanel.Controls.Add(this.productnameerror);
            this.leftpanel.Controls.Add(this.expiryerror);
            this.leftpanel.Controls.Add(this.barcoderror);
            this.leftpanel.Controls.SetChildIndex(this.barcoderror, 0);
            this.leftpanel.Controls.SetChildIndex(this.expiryerror, 0);
            this.leftpanel.Controls.SetChildIndex(this.productnameerror, 0);
            this.leftpanel.Controls.SetChildIndex(this.categoryerror, 0);
            this.leftpanel.Controls.SetChildIndex(this.productname, 0);
            this.leftpanel.Controls.SetChildIndex(this.brandname, 0);
            this.leftpanel.Controls.SetChildIndex(this.barcode, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.label2, 0);
            this.leftpanel.Controls.SetChildIndex(this.topleft, 0);
            this.leftpanel.Controls.SetChildIndex(this.label8, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.expirydate, 0);
            this.leftpanel.Controls.SetChildIndex(this.categorynames, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.productsgrids);
            this.rightpanel.Controls.SetChildIndex(this.topright, 0);
            this.rightpanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.productsgrids, 0);
            // 
            // userlabel
            // 
            this.userlabel.Size = new System.Drawing.Size(0, 19);
            this.userlabel.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "Category";
            // 
            // categoryerror
            // 
            this.categoryerror.AutoSize = true;
            this.categoryerror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryerror.Location = new System.Drawing.Point(166, 328);
            this.categoryerror.Name = "categoryerror";
            this.categoryerror.Size = new System.Drawing.Size(17, 22);
            this.categoryerror.TabIndex = 46;
            this.categoryerror.Text = "*";
            this.categoryerror.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Product Expiry Date";
            // 
            // expiryerror
            // 
            this.expiryerror.AutoSize = true;
            this.expiryerror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryerror.Location = new System.Drawing.Point(165, 378);
            this.expiryerror.Name = "expiryerror";
            this.expiryerror.Size = new System.Drawing.Size(17, 22);
            this.expiryerror.TabIndex = 43;
            this.expiryerror.Text = "*";
            this.expiryerror.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Brand Name";
            // 
            // barcode
            // 
            this.barcode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode.Location = new System.Drawing.Point(6, 294);
            this.barcode.MaxLength = 60;
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(179, 20);
            this.barcode.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Product Name";
            // 
            // productname
            // 
            this.productname.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname.Location = new System.Drawing.Point(6, 189);
            this.productname.MaxLength = 60;
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(179, 20);
            this.productname.TabIndex = 2;
            // 
            // brandname
            // 
            this.brandname.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandname.Location = new System.Drawing.Point(6, 240);
            this.brandname.MaxLength = 60;
            this.brandname.Name = "brandname";
            this.brandname.Size = new System.Drawing.Size(179, 20);
            this.brandname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Product Barcode";
            // 
            // barcoderror
            // 
            this.barcoderror.AutoSize = true;
            this.barcoderror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcoderror.Location = new System.Drawing.Point(166, 279);
            this.barcoderror.Name = "barcoderror";
            this.barcoderror.Size = new System.Drawing.Size(17, 22);
            this.barcoderror.TabIndex = 39;
            this.barcoderror.Text = "*";
            this.barcoderror.Visible = false;
            // 
            // productnameerror
            // 
            this.productnameerror.AutoSize = true;
            this.productnameerror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productnameerror.Location = new System.Drawing.Point(168, 174);
            this.productnameerror.Name = "productnameerror";
            this.productnameerror.Size = new System.Drawing.Size(17, 22);
            this.productnameerror.TabIndex = 38;
            this.productnameerror.Text = "*";
            this.productnameerror.Visible = false;
            // 
            // expirydate
            // 
            this.expirydate.CustomFormat = "dd-MMM-yyyy";
            this.expirydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expirydate.Location = new System.Drawing.Point(5, 396);
            this.expirydate.Name = "expirydate";
            this.expirydate.Size = new System.Drawing.Size(180, 22);
            this.expirydate.TabIndex = 17;
            // 
            // categorynames
            // 
            this.categorynames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorynames.FormattingEnabled = true;
            this.categorynames.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.categorynames.Location = new System.Drawing.Point(6, 345);
            this.categorynames.Name = "categorynames";
            this.categorynames.Size = new System.Drawing.Size(179, 24);
            this.categorynames.TabIndex = 14;
            // 
            // productsgrids
            // 
            this.productsgrids.AllowUserToAddRows = false;
            this.productsgrids.AllowUserToDeleteRows = false;
            this.productsgrids.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsgrids.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.productsgrids.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsgrids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsgrids.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidgv,
            this.productnamegv,
            this.brandnamegv,
            this.productbarcodegv,
            this.expirydategv,
            this.categorygv,
            this.catidgv});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsgrids.DefaultCellStyle = dataGridViewCellStyle1;
            this.productsgrids.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsgrids.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productsgrids.Location = new System.Drawing.Point(0, 152);
            this.productsgrids.Name = "productsgrids";
            this.productsgrids.ReadOnly = true;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.productsgrids.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.productsgrids.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.productsgrids.Size = new System.Drawing.Size(871, 301);
            this.productsgrids.TabIndex = 3;
            this.productsgrids.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsgrid_CellClick_1);
            // 
            // productidgv
            // 
            this.productidgv.HeaderText = "productid";
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
            // brandnamegv
            // 
            this.brandnamegv.HeaderText = "Brand Name";
            this.brandnamegv.Name = "brandnamegv";
            this.brandnamegv.ReadOnly = true;
            // 
            // productbarcodegv
            // 
            this.productbarcodegv.HeaderText = "Barcode";
            this.productbarcodegv.Name = "productbarcodegv";
            this.productbarcodegv.ReadOnly = true;
            // 
            // expirydategv
            // 
            this.expirydategv.HeaderText = "Expiry Date";
            this.expirydategv.Name = "expirydategv";
            this.expirydategv.ReadOnly = true;
            // 
            // categorygv
            // 
            this.categorygv.HeaderText = "Category";
            this.categorygv.Name = "categorygv";
            this.categorygv.ReadOnly = true;
            // 
            // catidgv
            // 
            this.catidgv.HeaderText = "Categoryid";
            this.catidgv.Name = "catidgv";
            this.catidgv.ReadOnly = true;
            this.catidgv.Visible = false;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 515);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.topleft.ResumeLayout(false);
            this.topleft.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.topright.ResumeLayout(false);
            this.topright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsgrids)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label categoryerror;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label expiryerror;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox barcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.TextBox brandname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label barcoderror;
        private System.Windows.Forms.Label productnameerror;
        private System.Windows.Forms.DateTimePicker expirydate;
        private System.Windows.Forms.ComboBox categorynames;
        private System.Windows.Forms.DataGridView productsgrids;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnamegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandnamegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn productbarcodegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirydategv;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorygv;
        private System.Windows.Forms.DataGridViewTextBoxColumn catidgv;
    }
}