namespace inventorymanagementsystem
{
    partial class Productpricing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.pricegrid = new System.Windows.Forms.DataGridView();
            this.selectgv = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.proidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnamegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingpricegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitmargingv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.ComboBox();
            this.leftpanel.SuspendLayout();
            this.topleft.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.topright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricegrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.category);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.topleft, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.category, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.pricegrid);
            this.rightpanel.Controls.SetChildIndex(this.topright, 0);
            this.rightpanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.pricegrid, 0);
            // 
            // userlabel
            // 
            this.userlabel.Size = new System.Drawing.Size(0, 19);
            this.userlabel.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Category Name";
            // 
            // pricegrid
            // 
            this.pricegrid.AllowUserToAddRows = false;
            this.pricegrid.AllowUserToDeleteRows = false;
            this.pricegrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pricegrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pricegrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pricegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pricegrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectgv,
            this.proidgv,
            this.productnamegv,
            this.buyingpricegv,
            this.discountgv,
            this.profitmargingv,
            this.finalgv});
            this.pricegrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pricegrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.pricegrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pricegrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pricegrid.Location = new System.Drawing.Point(0, 152);
            this.pricegrid.Name = "pricegrid";
            this.pricegrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.pricegrid.Size = new System.Drawing.Size(871, 363);
            this.pricegrid.TabIndex = 4;
            this.pricegrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.pricegrid_CellEndEdit);
            this.pricegrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.pricegrid_DataError);
            // 
            // selectgv
            // 
            this.selectgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.selectgv.FalseValue = "0";
            this.selectgv.HeaderText = "";
            this.selectgv.Name = "selectgv";
            this.selectgv.TrueValue = "1";
            this.selectgv.Width = 5;
            // 
            // proidgv
            // 
            this.proidgv.HeaderText = "Productid";
            this.proidgv.Name = "proidgv";
            this.proidgv.Visible = false;
            // 
            // productnamegv
            // 
            this.productnamegv.HeaderText = "Product Name";
            this.productnamegv.Name = "productnamegv";
            // 
            // buyingpricegv
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.buyingpricegv.DefaultCellStyle = dataGridViewCellStyle1;
            this.buyingpricegv.HeaderText = "Buying Price";
            this.buyingpricegv.Name = "buyingpricegv";
            // 
            // discountgv
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.discountgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.discountgv.HeaderText = "Discount %";
            this.discountgv.Name = "discountgv";
            // 
            // profitmargingv
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.profitmargingv.DefaultCellStyle = dataGridViewCellStyle3;
            this.profitmargingv.HeaderText = "Profit Margin %";
            this.profitmargingv.Name = "profitmargingv";
            // 
            // finalgv
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.finalgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.finalgv.HeaderText = "Final Selling Price";
            this.finalgv.Name = "finalgv";
            // 
            // category
            // 
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(6, 196);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(179, 24);
            this.category.TabIndex = 36;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // Productpricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 515);
            this.Name = "Productpricing";
            this.Text = "Productpricing";
            this.Load += new System.EventHandler(this.Productpricing_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.topleft.ResumeLayout(false);
            this.topleft.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.topright.ResumeLayout(false);
            this.topright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricegrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView pricegrid;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn proidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnamegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingpricegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitmargingv;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalgv;
    }
}