namespace inventorymanagementsystem
{
    partial class Settings
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.database = new System.Windows.Forms.TextBox();
            this.system = new System.Windows.Forms.CheckBox();
            this.save = new System.Windows.Forms.Button();
            this.databaserror = new System.Windows.Forms.Label();
            this.serverror = new System.Windows.Forms.Label();
            this.passworderror = new System.Windows.Forms.Label();
            this.usernameerror = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.topright.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.save);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.password);
            this.leftpanel.Controls.Add(this.system);
            this.leftpanel.Controls.Add(this.username);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.database);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.server);
            this.leftpanel.Controls.Add(this.label2);
            this.leftpanel.Controls.Add(this.passworderror);
            this.leftpanel.Controls.Add(this.usernameerror);
            this.leftpanel.Controls.Add(this.databaserror);
            this.leftpanel.Controls.Add(this.serverror);
            this.leftpanel.Size = new System.Drawing.Size(200, 515);
            this.leftpanel.Controls.SetChildIndex(this.serverror, 0);
            this.leftpanel.Controls.SetChildIndex(this.databaserror, 0);
            this.leftpanel.Controls.SetChildIndex(this.usernameerror, 0);
            this.leftpanel.Controls.SetChildIndex(this.passworderror, 0);
            this.leftpanel.Controls.SetChildIndex(this.topleft, 0);
            this.leftpanel.Controls.SetChildIndex(this.label2, 0);
            this.leftpanel.Controls.SetChildIndex(this.server, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.database, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.username, 0);
            this.leftpanel.Controls.SetChildIndex(this.system, 0);
            this.leftpanel.Controls.SetChildIndex(this.password, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.save, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(871, 515);
            this.rightpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightpanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Database";
            // 
            // server
            // 
            this.server.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server.Location = new System.Drawing.Point(5, 185);
            this.server.MaxLength = 60;
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(179, 20);
            this.server.TabIndex = 2;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(5, 345);
            this.password.MaxLength = 60;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(179, 20);
            this.password.TabIndex = 11;
            this.password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(5, 290);
            this.username.MaxLength = 60;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(179, 20);
            this.username.TabIndex = 8;
            // 
            // database
            // 
            this.database.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database.Location = new System.Drawing.Point(5, 236);
            this.database.MaxLength = 60;
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(179, 20);
            this.database.TabIndex = 5;
            // 
            // system
            // 
            this.system.AutoSize = true;
            this.system.Location = new System.Drawing.Point(5, 380);
            this.system.Name = "system";
            this.system.Size = new System.Drawing.Size(142, 20);
            this.system.TabIndex = 6;
            this.system.Text = "Integrated System";
            this.system.UseVisualStyleBackColor = true;
            this.system.CheckedChanged += new System.EventHandler(this.system_CheckedChanged);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(9, 414);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(172, 34);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // databaserror
            // 
            this.databaserror.AutoSize = true;
            this.databaserror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaserror.Location = new System.Drawing.Point(167, 221);
            this.databaserror.Name = "databaserror";
            this.databaserror.Size = new System.Drawing.Size(17, 22);
            this.databaserror.TabIndex = 14;
            this.databaserror.Text = "*";
            this.databaserror.Visible = false;
            // 
            // serverror
            // 
            this.serverror.AutoSize = true;
            this.serverror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverror.Location = new System.Drawing.Point(167, 170);
            this.serverror.Name = "serverror";
            this.serverror.Size = new System.Drawing.Size(17, 22);
            this.serverror.TabIndex = 13;
            this.serverror.Text = "*";
            this.serverror.Visible = false;
            // 
            // passworderror
            // 
            this.passworderror.AutoSize = true;
            this.passworderror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passworderror.Location = new System.Drawing.Point(165, 326);
            this.passworderror.Name = "passworderror";
            this.passworderror.Size = new System.Drawing.Size(17, 22);
            this.passworderror.TabIndex = 16;
            this.passworderror.Text = "*";
            this.passworderror.Visible = false;
            // 
            // usernameerror
            // 
            this.usernameerror.AutoSize = true;
            this.usernameerror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameerror.Location = new System.Drawing.Point(165, 275);
            this.usernameerror.Name = "usernameerror";
            this.usernameerror.Size = new System.Drawing.Size(17, 22);
            this.usernameerror.TabIndex = 15;
            this.usernameerror.Text = "*";
            this.usernameerror.Visible = false;
            // 
            // Settings
            // 
            this.AcceptButton = this.save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 515);
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.topright.ResumeLayout(false);
            this.topright.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox system;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox database;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.Label passworderror;
        private System.Windows.Forms.Label usernameerror;
        private System.Windows.Forms.Label databaserror;
        private System.Windows.Forms.Label serverror;
    }
}