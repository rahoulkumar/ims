namespace inventorymanagementsystem
{
    partial class Sample
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
            this.leftpanel = new System.Windows.Forms.Panel();
            this.topleft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.topright = new System.Windows.Forms.Panel();
            this.userlabel = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.topleft.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.topright.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.leftpanel.Controls.Add(this.topleft);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftpanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(200, 492);
            this.leftpanel.TabIndex = 0;
            // 
            // topleft
            // 
            this.topleft.Controls.Add(this.label1);
            this.topleft.Dock = System.Windows.Forms.DockStyle.Top;
            this.topleft.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topleft.Location = new System.Drawing.Point(0, 0);
            this.topleft.Name = "topleft";
            this.topleft.Size = new System.Drawing.Size(200, 100);
            this.topleft.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(121, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.topright);
            this.rightpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightpanel.Location = new System.Drawing.Point(200, 0);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(871, 492);
            this.rightpanel.TabIndex = 1;
            // 
            // topright
            // 
            this.topright.Controls.Add(this.userlabel);
            this.topright.Dock = System.Windows.Forms.DockStyle.Top;
            this.topright.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topright.Location = new System.Drawing.Point(0, 0);
            this.topright.Name = "topright";
            this.topright.Size = new System.Drawing.Size(871, 100);
            this.topright.TabIndex = 1;
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.userlabel.Location = new System.Drawing.Point(6, 41);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(45, 19);
            this.userlabel.TabIndex = 1;
            this.userlabel.Text = "User";
            this.userlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 492);
            this.ControlBox = false;
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.leftpanel);
            this.Name = "Sample";
            this.leftpanel.ResumeLayout(false);
            this.topleft.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.topright.ResumeLayout(false);
            this.topright.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel leftpanel;
        public System.Windows.Forms.Panel topleft;
        public System.Windows.Forms.Panel rightpanel;
        public System.Windows.Forms.Panel topright;
        public System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Label label1;
    }
}