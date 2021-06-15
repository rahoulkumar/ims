namespace inventorymanagementsystem
{
    partial class Stocks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stocksfrid = new System.Windows.Forms.DataGridView();
            this.proidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnamegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bpgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirygv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorygv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitygv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.topleft.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.topright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksfrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.stocksfrid);
            this.rightpanel.Controls.SetChildIndex(this.topright, 0);
            this.rightpanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.stocksfrid, 0);
            // 
            // userlabel
            // 
            this.userlabel.Size = new System.Drawing.Size(0, 19);
            this.userlabel.Text = "";
            // 
            // stocksfrid
            // 
            this.stocksfrid.AllowUserToAddRows = false;
            this.stocksfrid.AllowUserToDeleteRows = false;
            this.stocksfrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stocksfrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.stocksfrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stocksfrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stocksfrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proidgv,
            this.productnamegv,
            this.barcodegv,
            this.bpgv,
            this.spgv,
            this.expirygv,
            this.categorygv,
            this.quantitygv,
            this.totalamountgv,
            this.statusgv});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stocksfrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.stocksfrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stocksfrid.Location = new System.Drawing.Point(0, 152);
            this.stocksfrid.Name = "stocksfrid";
            this.stocksfrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stocksfrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.stocksfrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stocksfrid.Size = new System.Drawing.Size(871, 363);
            this.stocksfrid.TabIndex = 3;
            // 
            // proidgv
            // 
            this.proidgv.HeaderText = "Proid";
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
            // barcodegv
            // 
            this.barcodegv.HeaderText = "Barcode";
            this.barcodegv.Name = "barcodegv";
            this.barcodegv.ReadOnly = true;
            // 
            // bpgv
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.bpgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.bpgv.HeaderText = "Buying Price";
            this.bpgv.Name = "bpgv";
            this.bpgv.ReadOnly = true;
            // 
            // spgv
            // 
            this.spgv.HeaderText = "Selling Price";
            this.spgv.Name = "spgv";
            this.spgv.ReadOnly = true;
            // 
            // expirygv
            // 
            this.expirygv.HeaderText = "Expiry Date";
            this.expirygv.Name = "expirygv";
            this.expirygv.ReadOnly = true;
            // 
            // categorygv
            // 
            this.categorygv.HeaderText = "Category Name";
            this.categorygv.Name = "categorygv";
            this.categorygv.ReadOnly = true;
            // 
            // quantitygv
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.quantitygv.DefaultCellStyle = dataGridViewCellStyle2;
            this.quantitygv.HeaderText = "Quantity";
            this.quantitygv.Name = "quantitygv";
            this.quantitygv.ReadOnly = true;
            // 
            // totalamountgv
            // 
            this.totalamountgv.HeaderText = "Total Amount";
            this.totalamountgv.Name = "totalamountgv";
            this.totalamountgv.ReadOnly = true;
            // 
            // statusgv
            // 
            this.statusgv.HeaderText = "Status";
            this.statusgv.Name = "statusgv";
            this.statusgv.ReadOnly = true;
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 515);
            this.Name = "Stocks";
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.Stocks_Load);
            this.leftpanel.ResumeLayout(false);
            this.topleft.ResumeLayout(false);
            this.topleft.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.topright.ResumeLayout(false);
            this.topright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksfrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stocksfrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn proidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnamegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn bpgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn spgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirygv;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorygv;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitygv;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusgv;
    }
}