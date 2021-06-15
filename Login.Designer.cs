namespace inventorymanagementsystem
{
    partial class Login
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
            this.label5 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Button();
            this.usererror = new System.Windows.Forms.Label();
            this.passerror = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.topright.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.log);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.pass);
            this.leftpanel.Controls.Add(this.label2);
            this.leftpanel.Controls.Add(this.user);
            this.leftpanel.Controls.Add(this.passerror);
            this.leftpanel.Controls.Add(this.usererror);
            this.leftpanel.Size = new System.Drawing.Size(200, 515);
            this.leftpanel.Controls.SetChildIndex(this.usererror, 0);
            this.leftpanel.Controls.SetChildIndex(this.passerror, 0);
            this.leftpanel.Controls.SetChildIndex(this.user, 0);
            this.leftpanel.Controls.SetChildIndex(this.label2, 0);
            this.leftpanel.Controls.SetChildIndex(this.pass, 0);
            this.leftpanel.Controls.SetChildIndex(this.topleft, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.log, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(871, 515);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(6, 264);
            this.pass.MaxLength = 60;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(179, 20);
            this.pass.TabIndex = 9;
            this.pass.Text = "rahul123";
            this.pass.UseSystemPasswordChar = true;
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(6, 213);
            this.user.MaxLength = 60;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(179, 20);
            this.user.TabIndex = 6;
            this.user.Text = "rahoul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.log.FlatAppearance.BorderSize = 0;
            this.log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log.Location = new System.Drawing.Point(9, 305);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(172, 34);
            this.log.TabIndex = 10;
            this.log.Text = "Login";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // usererror
            // 
            this.usererror.AutoSize = true;
            this.usererror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usererror.Location = new System.Drawing.Point(168, 194);
            this.usererror.Name = "usererror";
            this.usererror.Size = new System.Drawing.Size(17, 22);
            this.usererror.TabIndex = 11;
            this.usererror.Text = "*";
            this.usererror.Visible = false;
            // 
            // passerror
            // 
            this.passerror.AutoSize = true;
            this.passerror.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passerror.Location = new System.Drawing.Point(168, 245);
            this.passerror.Name = "passerror";
            this.passerror.Size = new System.Drawing.Size(17, 22);
            this.passerror.TabIndex = 12;
            this.passerror.Text = "*";
            this.passerror.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.log;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 515);
            this.Name = "Login";
            this.Text = "Login";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.topright.ResumeLayout(false);
            this.topright.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Label passerror;
        private System.Windows.Forms.Label usererror;
    }
}