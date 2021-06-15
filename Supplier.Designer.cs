namespace inventorymanagementsystem
{
    partial class Supplier
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
            this.label5 = new System.Windows.Forms.Label();
            this.contactperson = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.companyname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.personnumbererror = new System.Windows.Forms.Label();
            this.personerror = new System.Windows.Forms.Label();
            this.addresserror = new System.Windows.Forms.Label();
            this.companyerror = new System.Windows.Forms.Label();
            this.ntnumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.statuserror = new System.Windows.Forms.Label();
            this.suppliergrid = new System.Windows.Forms.DataGridView();
            this.suppidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companygv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactpersongv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnumbergv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntngv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.TextBox();
            this.leftpanel.SuspendLayout();
            this.topleft.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.topright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliergrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(944, 52);
            // 
            // searchtx
            // 
            this.searchtx.Size = new System.Drawing.Size(147, 20);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.contact);
            this.leftpanel.Controls.Add(this.status);
            this.leftpanel.Controls.Add(this.label10);
            this.leftpanel.Controls.Add(this.statuserror);
            this.leftpanel.Controls.Add(this.ntnumber);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.contactperson);
            this.leftpanel.Controls.Add(this.label2);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.address);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.companyname);
            this.leftpanel.Controls.Add(this.companyerror);
            this.leftpanel.Controls.Add(this.addresserror);
            this.leftpanel.Controls.Add(this.personerror);
            this.leftpanel.Controls.Add(this.personnumbererror);
            this.leftpanel.Size = new System.Drawing.Size(200, 550);
            this.leftpanel.Controls.SetChildIndex(this.personnumbererror, 0);
            this.leftpanel.Controls.SetChildIndex(this.personerror, 0);
            this.leftpanel.Controls.SetChildIndex(this.addresserror, 0);
            this.leftpanel.Controls.SetChildIndex(this.companyerror, 0);
            this.leftpanel.Controls.SetChildIndex(this.companyname, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.address, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.label2, 0);
            this.leftpanel.Controls.SetChildIndex(this.contactperson, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.ntnumber, 0);
            this.leftpanel.Controls.SetChildIndex(this.topleft, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.statuserror, 0);
            this.leftpanel.Controls.SetChildIndex(this.label10, 0);
            this.leftpanel.Controls.SetChildIndex(this.status, 0);
            this.leftpanel.Controls.SetChildIndex(this.contact, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.suppliergrid);
            this.rightpanel.Size = new System.Drawing.Size(944, 550);
            this.rightpanel.Controls.SetChildIndex(this.topright, 0);
            this.rightpanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.suppliergrid, 0);
            // 
            // topright
            // 
            this.topright.Size = new System.Drawing.Size(944, 100);
            // 
            // userlabel
            // 
            this.userlabel.Size = new System.Drawing.Size(0, 19);
            this.userlabel.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Address";
            // 
            // contactperson
            // 
            this.contactperson.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactperson.Location = new System.Drawing.Point(6, 328);
            this.contactperson.MaxLength = 60;
            this.contactperson.Name = "contactperson";
            this.contactperson.Size = new System.Drawing.Size(179, 20);
            this.contactperson.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Contact # (0XXX-XXXXXXX)";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(6, 274);
            this.address.MaxLength = 60;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(179, 20);
            this.address.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Contact Person";
            // 
            // companyname
            // 
            this.companyname.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyname.Location = new System.Drawing.Point(6, 223);
            this.companyname.MaxLength = 60;
            this.companyname.Name = "companyname";
            this.companyname.Size = new System.Drawing.Size(179, 20);
            this.companyname.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Company Name";
            // 
            // personnumbererror
            // 
            this.personnumbererror.AutoSize = true;
            this.personnumbererror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personnumbererror.Location = new System.Drawing.Point(166, 364);
            this.personnumbererror.Name = "personnumbererror";
            this.personnumbererror.Size = new System.Drawing.Size(17, 22);
            this.personnumbererror.TabIndex = 28;
            this.personnumbererror.Text = "*";
            this.personnumbererror.Visible = false;
            // 
            // personerror
            // 
            this.personerror.AutoSize = true;
            this.personerror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personerror.Location = new System.Drawing.Point(166, 313);
            this.personerror.Name = "personerror";
            this.personerror.Size = new System.Drawing.Size(17, 22);
            this.personerror.TabIndex = 27;
            this.personerror.Text = "*";
            this.personerror.Visible = false;
            // 
            // addresserror
            // 
            this.addresserror.AutoSize = true;
            this.addresserror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresserror.Location = new System.Drawing.Point(168, 259);
            this.addresserror.Name = "addresserror";
            this.addresserror.Size = new System.Drawing.Size(17, 22);
            this.addresserror.TabIndex = 26;
            this.addresserror.Text = "*";
            this.addresserror.Visible = false;
            // 
            // companyerror
            // 
            this.companyerror.AutoSize = true;
            this.companyerror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyerror.Location = new System.Drawing.Point(168, 208);
            this.companyerror.Name = "companyerror";
            this.companyerror.Size = new System.Drawing.Size(17, 22);
            this.companyerror.TabIndex = 25;
            this.companyerror.Text = "*";
            this.companyerror.Visible = false;
            // 
            // ntnumber
            // 
            this.ntnumber.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntnumber.Location = new System.Drawing.Point(6, 436);
            this.ntnumber.MaxLength = 60;
            this.ntnumber.Name = "ntnumber";
            this.ntnumber.Size = new System.Drawing.Size(179, 20);
            this.ntnumber.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "NTN #";
            // 
            // status
            // 
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.status.Location = new System.Drawing.Point(6, 485);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(179, 24);
            this.status.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 466);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Status";
            // 
            // statuserror
            // 
            this.statuserror.AutoSize = true;
            this.statuserror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuserror.Location = new System.Drawing.Point(165, 468);
            this.statuserror.Name = "statuserror";
            this.statuserror.Size = new System.Drawing.Size(17, 22);
            this.statuserror.TabIndex = 31;
            this.statuserror.Text = "*";
            this.statuserror.Visible = false;
            // 
            // suppliergrid
            // 
            this.suppliergrid.AllowUserToAddRows = false;
            this.suppliergrid.AllowUserToDeleteRows = false;
            this.suppliergrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliergrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suppliergrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suppliergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliergrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.suppidgv,
            this.companygv,
            this.addressgv,
            this.contactpersongv,
            this.contactnumbergv,
            this.statusgv,
            this.ntngv});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.suppliergrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.suppliergrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliergrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.suppliergrid.Location = new System.Drawing.Point(0, 152);
            this.suppliergrid.Name = "suppliergrid";
            this.suppliergrid.ReadOnly = true;
            this.suppliergrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.suppliergrid.Size = new System.Drawing.Size(944, 398);
            this.suppliergrid.TabIndex = 3;
            this.suppliergrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliergrid_CellClick);
            // 
            // suppidgv
            // 
            this.suppidgv.HeaderText = "Suppid";
            this.suppidgv.Name = "suppidgv";
            this.suppidgv.ReadOnly = true;
            this.suppidgv.Visible = false;
            // 
            // companygv
            // 
            this.companygv.HeaderText = "Company";
            this.companygv.Name = "companygv";
            this.companygv.ReadOnly = true;
            // 
            // addressgv
            // 
            this.addressgv.HeaderText = "Address";
            this.addressgv.Name = "addressgv";
            this.addressgv.ReadOnly = true;
            // 
            // contactpersongv
            // 
            this.contactpersongv.HeaderText = "Contact Person";
            this.contactpersongv.Name = "contactpersongv";
            this.contactpersongv.ReadOnly = true;
            // 
            // contactnumbergv
            // 
            this.contactnumbergv.HeaderText = "Contact Number";
            this.contactnumbergv.Name = "contactnumbergv";
            this.contactnumbergv.ReadOnly = true;
            // 
            // statusgv
            // 
            this.statusgv.HeaderText = "Status";
            this.statusgv.Name = "statusgv";
            this.statusgv.ReadOnly = true;
            // 
            // ntngv
            // 
            this.ntngv.HeaderText = "Ntn";
            this.ntngv.Name = "ntngv";
            this.ntngv.ReadOnly = true;
            this.ntngv.Visible = false;
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(6, 383);
            this.contact.MaxLength = 60;
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(179, 20);
            this.contact.TabIndex = 34;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 550);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.topleft.ResumeLayout(false);
            this.topleft.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.topright.ResumeLayout(false);
            this.topright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliergrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contactperson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox companyname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label personnumbererror;
        private System.Windows.Forms.Label personerror;
        private System.Windows.Forms.Label addresserror;
        private System.Windows.Forms.Label companyerror;
        private System.Windows.Forms.TextBox ntnumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label statuserror;
        private System.Windows.Forms.DataGridView suppliergrid;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn companygv;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactpersongv;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnumbergv;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntngv;
    }
}