namespace inventorymanagementsystem
{
    partial class othersample
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.view = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchtx = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.topleft.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.topright.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.panel2);
            this.leftpanel.Size = new System.Drawing.Size(200, 515);
            this.leftpanel.Controls.SetChildIndex(this.topleft, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            // 
            // topleft
            // 
            this.topleft.Controls.Add(this.button1);
            this.topleft.Controls.SetChildIndex(this.button1, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.panel1);
            this.rightpanel.Size = new System.Drawing.Size(871, 515);
            this.rightpanel.Controls.SetChildIndex(this.topright, 0);
            this.rightpanel.Controls.SetChildIndex(this.panel1, 0);
            // 
            // topright
            // 
            this.topright.Controls.Add(this.label2);
            this.topright.Controls.SetChildIndex(this.userlabel, 0);
            this.topright.Controls.SetChildIndex(this.label2, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 52);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.view, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.delete, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.save, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.edit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.add, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(871, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view.FlatAppearance.BorderSize = 0;
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.view.Location = new System.Drawing.Point(583, 3);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(139, 46);
            this.view.TabIndex = 4;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delete.Location = new System.Drawing.Point(438, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(139, 46);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.save.Location = new System.Drawing.Point(293, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(139, 46);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.edit.Location = new System.Drawing.Point(148, 3);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(139, 46);
            this.edit.TabIndex = 1;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add.Location = new System.Drawing.Point(3, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(139, 46);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchtx);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(728, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 46);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchtx
            // 
            this.searchtx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchtx.Location = new System.Drawing.Point(3, 23);
            this.searchtx.Name = "searchtx";
            this.searchtx.Size = new System.Drawing.Size(134, 20);
            this.searchtx.TabIndex = 0;
            this.searchtx.TextChanged += new System.EventHandler(this.searchtx_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 52);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::inventorymanagementsystem.Properties.Resources.back;
            this.button1.Location = new System.Drawing.Point(0, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 100);
            this.label2.TabIndex = 3;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // othersample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 515);
            this.Name = "othersample";
            this.Load += new System.EventHandler(this.othersample_Load);
            this.leftpanel.ResumeLayout(false);
            this.topleft.ResumeLayout(false);
            this.topleft.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.topright.ResumeLayout(false);
            this.topright.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button view;
        public System.Windows.Forms.Button delete;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button edit;
        public System.Windows.Forms.Button add;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox searchtx;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}