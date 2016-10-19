namespace ADO_Gruppuppgift
{
    partial class Form1
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
            this.lboShow = new System.Windows.Forms.ListBox();
            this.lboCategories = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.tbxProduct = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxNewProductName = new System.Windows.Forms.TextBox();
            this.tbxNewCategoryID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.tbxNewPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lboShow
            // 
            this.lboShow.FormattingEnabled = true;
            this.lboShow.ItemHeight = 16;
            this.lboShow.Location = new System.Drawing.Point(486, 17);
            this.lboShow.Name = "lboShow";
            this.lboShow.Size = new System.Drawing.Size(234, 500);
            this.lboShow.TabIndex = 0;
            // 
            // lboCategories
            // 
            this.lboCategories.FormattingEnabled = true;
            this.lboCategories.ItemHeight = 16;
            this.lboCategories.Location = new System.Drawing.Point(239, 17);
            this.lboCategories.Name = "lboCategories";
            this.lboCategories.Size = new System.Drawing.Size(241, 500);
            this.lboCategories.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 42);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Uppdatera";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(4, 180);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(104, 42);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Visa";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // tbxProduct
            // 
            this.tbxProduct.Location = new System.Drawing.Point(12, 67);
            this.tbxProduct.Name = "tbxProduct";
            this.tbxProduct.Size = new System.Drawing.Size(214, 22);
            this.tbxProduct.TabIndex = 5;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(12, 141);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(214, 22);
            this.tbxPrice.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Unit price";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(4, 475);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 42);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Skapa";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(122, 475);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 42);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Ta bort";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxNewProductName
            // 
            this.tbxNewProductName.Location = new System.Drawing.Point(12, 342);
            this.tbxNewProductName.Name = "tbxNewProductName";
            this.tbxNewProductName.Size = new System.Drawing.Size(214, 22);
            this.tbxNewProductName.TabIndex = 11;
            // 
            // tbxNewCategoryID
            // 
            this.tbxNewCategoryID.Location = new System.Drawing.Point(12, 432);
            this.tbxNewCategoryID.Name = "tbxNewCategoryID";
            this.tbxNewCategoryID.Size = new System.Drawing.Size(214, 22);
            this.tbxNewCategoryID.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "New product name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Category ID (1-8)";
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Location = new System.Drawing.Point(12, 367);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(40, 17);
            this.lblNewPrice.TabIndex = 16;
            this.lblNewPrice.Text = "Price";
            // 
            // tbxNewPrice
            // 
            this.tbxNewPrice.Location = new System.Drawing.Point(12, 387);
            this.tbxNewPrice.Name = "tbxNewPrice";
            this.tbxNewPrice.Size = new System.Drawing.Size(214, 22);
            this.tbxNewPrice.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 529);
            this.Controls.Add(this.lblNewPrice);
            this.Controls.Add(this.tbxNewPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxNewCategoryID);
            this.Controls.Add(this.tbxNewProductName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxProduct);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lboCategories);
            this.Controls.Add(this.lboShow);
            this.Name = "Form1";
            this.Text = "Northwind form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboShow;
        private System.Windows.Forms.ListBox lboCategories;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox tbxProduct;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxNewProductName;
        private System.Windows.Forms.TextBox tbxNewCategoryID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNewPrice;
        private System.Windows.Forms.TextBox tbxNewPrice;
    }
}

