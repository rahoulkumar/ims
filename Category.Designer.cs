namespace inventorymanagementsystem
{
    partial class Category
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
            this.categorystatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.categoryname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.categoryerror = new System.Windows.Forms.Label();
            this.categorystatuserror = new System.Windows.Forms.Label();
            this.categorygrid = new System.Windows.Forms.DataGridView();
            this.catidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorynamegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catstatusgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.topright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorygrid)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.categorystatus);
            this.leftpanel.Controls.Add(this.label10);
            this.leftpanel.Controls.Add(this.categoryname);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.Add(this.categorystatuserror);
            this.leftpanel.Controls.Add(this.categoryerror);
            this.leftpanel.Controls.SetChildIndex(this.categoryerror, 0);
            this.leftpanel.Controls.SetChildIndex(this.categorystatuserror, 0);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.categoryname, 0);
            this.leftpanel.Controls.SetChildIndex(this.topleft, 0);
            this.leftpanel.Controls.SetChildIndex(this.label10, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.categorystatus, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.categorygrid);
            this.rightpanel.Controls.SetChildIndex(this.topright, 0);
            this.rightpanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.categorygrid, 0);
            // 
            // userlabel
            // 
            this.userlabel.Size = new System.Drawing.Size(0, 19);
            this.userlabel.Text = "";
            // 
            // categorystatus
            // 
            this.categorystatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorystatus.FormattingEnabled = true;
            this.categorystatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.categorystatus.Location = new System.Drawing.Point(7, 295);
            this.categorystatus.Name = "categorystatus";
            this.categorystatus.Size = new System.Drawing.Size(179, 24);
            this.categorystatus.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Category Status";
            // 
            // categoryname
            // 
            this.categoryname.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryname.Location = new System.Drawing.Point(7, 244);
            this.categoryname.MaxLength = 60;
            this.categoryname.Name = "categoryname";
            this.categoryname.Size = new System.Drawing.Size(179, 20);
            this.categoryname.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Category Name";
            // 
            // categoryerror
            // 
            this.categoryerror.AutoSize = true;
            this.categoryerror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryerror.Location = new System.Drawing.Point(166, 226);
            this.categoryerror.Name = "categoryerror";
            this.categoryerror.Size = new System.Drawing.Size(17, 22);
            this.categoryerror.TabIndex = 33;
            this.categoryerror.Text = "*";
            this.categoryerror.Visible = false;
            // 
            // categorystatuserror
            // 
            this.categorystatuserror.AutoSize = true;
            this.categorystatuserror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorystatuserror.Location = new System.Drawing.Point(166, 278);
            this.categorystatuserror.Name = "categorystatuserror";
            this.categorystatuserror.Size = new System.Drawing.Size(17, 22);
            this.categorystatuserror.TabIndex = 30;
            this.categorystatuserror.Text = "*";
            this.categorystatuserror.Visible = false;
            // 
            // categorygrid
            // 
            this.categorygrid.AllowUserToAddRows = false;
            this.categorygrid.AllowUserToDeleteRows = false;
            this.categorygrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categorygrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.categorygrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categorygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categorygrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catidgv,
            this.categorynamegv,
            this.catstatusgv});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categorygrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.categorygrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categorygrid.GridColor = System.Drawing.Color.Black;
            this.categorygrid.Location = new System.Drawing.Point(0, 152);
            this.categorygrid.Name = "categorygrid";
            this.categorygrid.ReadOnly = true;
            this.categorygrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categorygrid.Size = new System.Drawing.Size(871, 363);
            this.categorygrid.TabIndex = 3;
            this.categorygrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categorygrid_CellClick);
            // 
            // catidgv
            // 
            this.catidgv.HeaderText = "Catid";
            this.catidgv.Name = "catidgv";
            this.catidgv.ReadOnly = true;
            this.catidgv.Visible = false;
            // 
            // categorynamegv
            // 
            this.categorynamegv.HeaderText = "Category Name";
            this.categorynamegv.Name = "categorynamegv";
            this.categorynamegv.ReadOnly = true;
            // 
            // catstatusgv
            // 
            this.catstatusgv.HeaderText = "Category Status";
            this.catstatusgv.Name = "catstatusgv";
            this.catstatusgv.ReadOnly = true;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 515);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.topright.ResumeLayout(false);
            this.topright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorygrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox categorystatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox categoryname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label categoryerror;
        private System.Windows.Forms.Label categorystatuserror;
        private System.Windows.Forms.DataGridView categorygrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn catidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorynamegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn catstatusgv;
    }
}