namespace inventorymanagementsystem
{
    partial class Dashboard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.purchasesupplier = new System.Windows.Forms.Button();
            this.supplier = new System.Windows.Forms.Button();
            this.productpricing = new System.Windows.Forms.Button();
            this.salesreturn = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.Button();
            this.sales = new System.Windows.Forms.Button();
            this.stocks = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.topleft.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.topright.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(200, 515);
            // 
            // topleft
            // 
            this.topleft.Controls.Add(this.logout);
            this.topleft.Controls.SetChildIndex(this.logout, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.tableLayoutPanel1);
            this.rightpanel.Size = new System.Drawing.Size(871, 515);
            this.rightpanel.Controls.SetChildIndex(this.topright, 0);
            this.rightpanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // topright
            // 
            this.topright.Controls.Add(this.label2);
            this.topright.Controls.SetChildIndex(this.userlabel, 0);
            this.topright.Controls.SetChildIndex(this.label2, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.purchasesupplier, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.supplier, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.productpricing, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.salesreturn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.category, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.sales, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.stocks, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.products, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.users, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(871, 258);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // purchasesupplier
            // 
            this.purchasesupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchasesupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchasesupplier.FlatAppearance.BorderSize = 2;
            this.purchasesupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchasesupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasesupplier.Image = global::inventorymanagementsystem.Properties.Resources.purchase;
            this.purchasesupplier.Location = new System.Drawing.Point(525, 132);
            this.purchasesupplier.Name = "purchasesupplier";
            this.purchasesupplier.Size = new System.Drawing.Size(168, 123);
            this.purchasesupplier.TabIndex = 8;
            this.purchasesupplier.Text = "Purchase Supplier";
            this.purchasesupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.purchasesupplier.UseVisualStyleBackColor = true;
            this.purchasesupplier.Click += new System.EventHandler(this.purchasesupplier_Click);
            // 
            // supplier
            // 
            this.supplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplier.FlatAppearance.BorderSize = 2;
            this.supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier.Image = global::inventorymanagementsystem.Properties.Resources.supplier;
            this.supplier.Location = new System.Drawing.Point(351, 132);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(168, 123);
            this.supplier.TabIndex = 7;
            this.supplier.Text = "Supplier";
            this.supplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.supplier.UseVisualStyleBackColor = true;
            this.supplier.Click += new System.EventHandler(this.supplier_Click);
            // 
            // productpricing
            // 
            this.productpricing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productpricing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productpricing.FlatAppearance.BorderSize = 2;
            this.productpricing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productpricing.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productpricing.Image = global::inventorymanagementsystem.Properties.Resources.pricing;
            this.productpricing.Location = new System.Drawing.Point(177, 132);
            this.productpricing.Name = "productpricing";
            this.productpricing.Size = new System.Drawing.Size(168, 123);
            this.productpricing.TabIndex = 6;
            this.productpricing.Text = "Product Pricing";
            this.productpricing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productpricing.UseVisualStyleBackColor = true;
            this.productpricing.Click += new System.EventHandler(this.productpricing_Click);
            // 
            // salesreturn
            // 
            this.salesreturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesreturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesreturn.FlatAppearance.BorderSize = 2;
            this.salesreturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesreturn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesreturn.Image = global::inventorymanagementsystem.Properties.Resources._return;
            this.salesreturn.Location = new System.Drawing.Point(3, 132);
            this.salesreturn.Name = "salesreturn";
            this.salesreturn.Size = new System.Drawing.Size(168, 123);
            this.salesreturn.TabIndex = 5;
            this.salesreturn.Text = "Sales Return";
            this.salesreturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salesreturn.UseVisualStyleBackColor = true;
            this.salesreturn.Click += new System.EventHandler(this.salesreturn_Click);
            // 
            // category
            // 
            this.category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.category.FlatAppearance.BorderSize = 2;
            this.category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Image = global::inventorymanagementsystem.Properties.Resources.category;
            this.category.Location = new System.Drawing.Point(699, 3);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(169, 123);
            this.category.TabIndex = 4;
            this.category.Text = "Category";
            this.category.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.category.UseVisualStyleBackColor = true;
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // sales
            // 
            this.sales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sales.FlatAppearance.BorderSize = 2;
            this.sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sales.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales.Image = global::inventorymanagementsystem.Properties.Resources.salesupdate;
            this.sales.Location = new System.Drawing.Point(525, 3);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(168, 123);
            this.sales.TabIndex = 3;
            this.sales.Text = "Sales";
            this.sales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sales.UseVisualStyleBackColor = true;
            this.sales.Click += new System.EventHandler(this.sales_Click);
            // 
            // stocks
            // 
            this.stocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stocks.FlatAppearance.BorderSize = 2;
            this.stocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stocks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocks.Image = global::inventorymanagementsystem.Properties.Resources.stocks;
            this.stocks.Location = new System.Drawing.Point(351, 3);
            this.stocks.Name = "stocks";
            this.stocks.Size = new System.Drawing.Size(168, 123);
            this.stocks.TabIndex = 2;
            this.stocks.Text = "Stocks";
            this.stocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stocks.UseVisualStyleBackColor = true;
            this.stocks.Click += new System.EventHandler(this.stocks_Click);
            // 
            // products
            // 
            this.products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.products.FlatAppearance.BorderSize = 2;
            this.products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products.Image = global::inventorymanagementsystem.Properties.Resources.products;
            this.products.Location = new System.Drawing.Point(177, 3);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(168, 123);
            this.products.TabIndex = 1;
            this.products.Text = "Products";
            this.products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.products.UseVisualStyleBackColor = true;
            this.products.Click += new System.EventHandler(this.products_Click);
            // 
            // users
            // 
            this.users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.users.FlatAppearance.BorderSize = 2;
            this.users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.users.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users.Image = global::inventorymanagementsystem.Properties.Resources.user;
            this.users.Location = new System.Drawing.Point(3, 3);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(168, 123);
            this.users.TabIndex = 0;
            this.users.Text = "Users";
            this.users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.users.UseVisualStyleBackColor = true;
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Image = global::inventorymanagementsystem.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(23, 41);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(79, 44);
            this.logout.TabIndex = 3;
            this.logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 100);
            this.label2.TabIndex = 4;
            this.label2.Text = "To Dashboard";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 515);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.leftpanel.ResumeLayout(false);
            this.topleft.ResumeLayout(false);
            this.topleft.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.topright.ResumeLayout(false);
            this.topright.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button purchasesupplier;
        private System.Windows.Forms.Button supplier;
        private System.Windows.Forms.Button productpricing;
        private System.Windows.Forms.Button salesreturn;
        private System.Windows.Forms.Button category;
        private System.Windows.Forms.Button sales;
        private System.Windows.Forms.Button stocks;
        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Button users;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label2;
    }
}