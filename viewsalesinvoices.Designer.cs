namespace inventorymanagementsystem
{
    partial class viewsalesinvoices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.selectdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Button();
            this.invoicegrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.salesidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usergv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaldiscountgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountgivegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountregv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.topleft.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.topright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicegrid)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.load);
            this.leftpanel.Controls.Add(this.selectdate);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Size = new System.Drawing.Size(200, 515);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.selectdate, 0);
            this.leftpanel.Controls.SetChildIndex(this.load, 0);
            this.leftpanel.Controls.SetChildIndex(this.topleft, 0);
            // 
            // topleft
            // 
            this.topleft.Controls.Add(this.button1);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.invoicegrid);
            this.rightpanel.Size = new System.Drawing.Size(871, 515);
            this.rightpanel.Controls.SetChildIndex(this.topright, 0);
            this.rightpanel.Controls.SetChildIndex(this.invoicegrid, 0);
            // 
            // selectdate
            // 
            this.selectdate.CustomFormat = "dd-MMM-yyyy";
            this.selectdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selectdate.Location = new System.Drawing.Point(6, 139);
            this.selectdate.Name = "selectdate";
            this.selectdate.Size = new System.Drawing.Size(180, 22);
            this.selectdate.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Select Date";
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load.FlatAppearance.BorderSize = 0;
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Location = new System.Drawing.Point(9, 175);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(172, 33);
            this.load.TabIndex = 50;
            this.load.Text = "&Load";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // invoicegrid
            // 
            this.invoicegrid.AllowUserToAddRows = false;
            this.invoicegrid.AllowUserToDeleteRows = false;
            this.invoicegrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoicegrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.invoicegrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invoicegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicegrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesidgv,
            this.useridgv,
            this.usergv,
            this.totalamountgv,
            this.totaldiscountgv,
            this.amountgivegv,
            this.amountregv});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoicegrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.invoicegrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoicegrid.Location = new System.Drawing.Point(0, 100);
            this.invoicegrid.Name = "invoicegrid";
            this.invoicegrid.ReadOnly = true;
            this.invoicegrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoicegrid.Size = new System.Drawing.Size(871, 415);
            this.invoicegrid.TabIndex = 4;
            this.invoicegrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoicegrid_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::inventorymanagementsystem.Properties.Resources.back;
            this.button1.Location = new System.Drawing.Point(8, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 78);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // salesidgv
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.salesidgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.salesidgv.HeaderText = "Sales ID";
            this.salesidgv.Name = "salesidgv";
            this.salesidgv.ReadOnly = true;
            // 
            // useridgv
            // 
            this.useridgv.HeaderText = "User id";
            this.useridgv.Name = "useridgv";
            this.useridgv.ReadOnly = true;
            this.useridgv.Visible = false;
            // 
            // usergv
            // 
            this.usergv.HeaderText = "User";
            this.usergv.Name = "usergv";
            this.usergv.ReadOnly = true;
            // 
            // totalamountgv
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.totalamountgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.totalamountgv.HeaderText = "Total Amount";
            this.totalamountgv.Name = "totalamountgv";
            this.totalamountgv.ReadOnly = true;
            // 
            // totaldiscountgv
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.totaldiscountgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.totaldiscountgv.HeaderText = "Total Discount";
            this.totaldiscountgv.Name = "totaldiscountgv";
            this.totaldiscountgv.ReadOnly = true;
            // 
            // amountgivegv
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.amountgivegv.DefaultCellStyle = dataGridViewCellStyle4;
            this.amountgivegv.HeaderText = "Amount Given";
            this.amountgivegv.Name = "amountgivegv";
            this.amountgivegv.ReadOnly = true;
            // 
            // amountregv
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.amountregv.DefaultCellStyle = dataGridViewCellStyle5;
            this.amountregv.HeaderText = "Amount Returned";
            this.amountregv.Name = "amountregv";
            this.amountregv.ReadOnly = true;
            // 
            // viewsalesinvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 515);
            this.Name = "viewsalesinvoices";
            this.Text = "View Sales Invoices";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.topleft.ResumeLayout(false);
            this.topleft.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.topright.ResumeLayout(false);
            this.topright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicegrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker selectdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.DataGridView invoicegrid;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn usergv;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaldiscountgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountgivegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountregv;
    }
}