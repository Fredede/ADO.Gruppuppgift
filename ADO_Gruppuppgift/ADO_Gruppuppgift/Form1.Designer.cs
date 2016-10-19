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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.tbxProduct = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btnUpdate.Location = new System.Drawing.Point(12, 475);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 42);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Uppdatera";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(122, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 42);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 416);
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
            this.label1.Location = new System.Drawing.Point(12, 44);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 529);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxProduct);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox tbxProduct;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

