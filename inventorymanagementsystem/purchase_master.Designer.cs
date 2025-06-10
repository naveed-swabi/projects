namespace inventorymanagementsystem
{
    partial class purchase_master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(purchase_master));
            this.label_productname = new System.Windows.Forms.Label();
            this.labelquantity = new System.Windows.Forms.Label();
            this.labelprice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_purchasedate = new System.Windows.Forms.Label();
            this.label6_dealername = new System.Windows.Forms.Label();
            this.label_purchasetype = new System.Windows.Forms.Label();
            this.label_expirydate = new System.Windows.Forms.Label();
            this.label_profit = new System.Windows.Forms.Label();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.textBox2_pice = new System.Windows.Forms.TextBox();
            this.textBox_totalprice = new System.Windows.Forms.TextBox();
            this.date_purchase = new System.Windows.Forms.DateTimePicker();
            this.comboBox_dealername = new System.Windows.Forms.ComboBox();
            this.date_expiry = new System.Windows.Forms.DateTimePicker();
            this.textBox_profit = new System.Windows.Forms.TextBox();
            this.label_unit = new System.Windows.Forms.Label();
            this.comboBox_purchasetype = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.list_product = new System.Windows.Forms.ListBox();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_productname
            // 
            this.label_productname.AutoSize = true;
            this.label_productname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productname.Location = new System.Drawing.Point(22, 12);
            this.label_productname.Name = "label_productname";
            this.label_productname.Size = new System.Drawing.Size(110, 17);
            this.label_productname.TabIndex = 0;
            this.label_productname.Text = "Product Name";
            // 
            // labelquantity
            // 
            this.labelquantity.AutoSize = true;
            this.labelquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelquantity.Location = new System.Drawing.Point(17, 126);
            this.labelquantity.Name = "labelquantity";
            this.labelquantity.Size = new System.Drawing.Size(130, 17);
            this.labelquantity.TabIndex = 1;
            this.labelquantity.Text = "Product Quantity";
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprice.Location = new System.Drawing.Point(17, 155);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(106, 17);
            this.labelprice.TabIndex = 2;
            this.labelprice.Text = "Product Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Price";
            // 
            // label_purchasedate
            // 
            this.label_purchasedate.AutoSize = true;
            this.label_purchasedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_purchasedate.Location = new System.Drawing.Point(22, 219);
            this.label_purchasedate.Name = "label_purchasedate";
            this.label_purchasedate.Size = new System.Drawing.Size(115, 17);
            this.label_purchasedate.TabIndex = 4;
            this.label_purchasedate.Text = "Purchase Date";
            this.label_purchasedate.Click += new System.EventHandler(this.label_purchasedate_Click);
            // 
            // label6_dealername
            // 
            this.label6_dealername.AutoSize = true;
            this.label6_dealername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_dealername.Location = new System.Drawing.Point(22, 255);
            this.label6_dealername.Name = "label6_dealername";
            this.label6_dealername.Size = new System.Drawing.Size(102, 17);
            this.label6_dealername.TabIndex = 5;
            this.label6_dealername.Text = "Dealer Name";
            // 
            // label_purchasetype
            // 
            this.label_purchasetype.AutoSize = true;
            this.label_purchasetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_purchasetype.Location = new System.Drawing.Point(20, 285);
            this.label_purchasetype.Name = "label_purchasetype";
            this.label_purchasetype.Size = new System.Drawing.Size(117, 17);
            this.label_purchasetype.TabIndex = 6;
            this.label_purchasetype.Text = "Purchase Type";
            // 
            // label_expirydate
            // 
            this.label_expirydate.AutoSize = true;
            this.label_expirydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_expirydate.Location = new System.Drawing.Point(20, 335);
            this.label_expirydate.Name = "label_expirydate";
            this.label_expirydate.Size = new System.Drawing.Size(91, 17);
            this.label_expirydate.TabIndex = 7;
            this.label_expirydate.Text = "Expiry Date";
            // 
            // label_profit
            // 
            this.label_profit.AutoSize = true;
            this.label_profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profit.Location = new System.Drawing.Point(22, 365);
            this.label_profit.Name = "label_profit";
            this.label_profit.Size = new System.Drawing.Size(65, 17);
            this.label_profit.TabIndex = 8;
            this.label_profit.Text = "Profit %";
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_quantity.Location = new System.Drawing.Point(150, 123);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(169, 23);
            this.textBox_quantity.TabIndex = 11;
            this.textBox_quantity.TabIndexChanged += new System.EventHandler(this.textBox_quantity_TabIndexChanged);
            this.textBox_quantity.TextChanged += new System.EventHandler(this.textBox_quantity_TextChanged);
            this.textBox_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_quantity_KeyPress);
            this.textBox_quantity.Leave += new System.EventHandler(this.textBox_quantity_Leave);
            // 
            // textBox2_pice
            // 
            this.textBox2_pice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_pice.Location = new System.Drawing.Point(150, 155);
            this.textBox2_pice.Name = "textBox2_pice";
            this.textBox2_pice.Size = new System.Drawing.Size(169, 23);
            this.textBox2_pice.TabIndex = 12;
            this.textBox2_pice.TextChanged += new System.EventHandler(this.textBox2_pice_TextChanged);
            this.textBox2_pice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_pice_KeyPress);
            this.textBox2_pice.Leave += new System.EventHandler(this.textBox2_pice_Leave);
            // 
            // textBox_totalprice
            // 
            this.textBox_totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_totalprice.Location = new System.Drawing.Point(150, 184);
            this.textBox_totalprice.Name = "textBox_totalprice";
            this.textBox_totalprice.ReadOnly = true;
            this.textBox_totalprice.Size = new System.Drawing.Size(169, 23);
            this.textBox_totalprice.TabIndex = 19;
            this.textBox_totalprice.TextChanged += new System.EventHandler(this.textBox_totalprice_TextChanged);
            // 
            // date_purchase
            // 
            this.date_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_purchase.Location = new System.Drawing.Point(150, 214);
            this.date_purchase.Name = "date_purchase";
            this.date_purchase.Size = new System.Drawing.Size(169, 23);
            this.date_purchase.TabIndex = 14;
            // 
            // comboBox_dealername
            // 
            this.comboBox_dealername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_dealername.FormattingEnabled = true;
            this.comboBox_dealername.Location = new System.Drawing.Point(150, 248);
            this.comboBox_dealername.Name = "comboBox_dealername";
            this.comboBox_dealername.Size = new System.Drawing.Size(169, 24);
            this.comboBox_dealername.TabIndex = 15;
            // 
            // date_expiry
            // 
            this.date_expiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_expiry.Location = new System.Drawing.Point(150, 329);
            this.date_expiry.Name = "date_expiry";
            this.date_expiry.Size = new System.Drawing.Size(169, 23);
            this.date_expiry.TabIndex = 17;
            // 
            // textBox_profit
            // 
            this.textBox_profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_profit.Location = new System.Drawing.Point(150, 359);
            this.textBox_profit.Name = "textBox_profit";
            this.textBox_profit.Size = new System.Drawing.Size(169, 23);
            this.textBox_profit.TabIndex = 18;
            this.textBox_profit.TextChanged += new System.EventHandler(this.textBox_profit_TextChanged);
            this.textBox_profit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_profit_KeyPress);
            // 
            // label_unit
            // 
            this.label_unit.AutoSize = true;
            this.label_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_unit.Location = new System.Drawing.Point(325, 18);
            this.label_unit.Name = "label_unit";
            this.label_unit.Size = new System.Drawing.Size(37, 17);
            this.label_unit.TabIndex = 19;
            this.label_unit.Text = "Unit";
            // 
            // comboBox_purchasetype
            // 
            this.comboBox_purchasetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_purchasetype.FormattingEnabled = true;
            this.comboBox_purchasetype.Items.AddRange(new object[] {
            "Cash",
            "Debit"});
            this.comboBox_purchasetype.Location = new System.Drawing.Point(150, 282);
            this.comboBox_purchasetype.Name = "comboBox_purchasetype";
            this.comboBox_purchasetype.Size = new System.Drawing.Size(169, 24);
            this.comboBox_purchasetype.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(150, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 31);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_product
            // 
            this.list_product.FormattingEnabled = true;
            this.list_product.Location = new System.Drawing.Point(150, 41);
            this.list_product.Name = "list_product";
            this.list_product.Size = new System.Drawing.Size(169, 43);
            this.list_product.TabIndex = 22;
            this.list_product.Visible = false;
            this.list_product.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_product_MouseClick);
            this.list_product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.list_product_KeyDown);
            // 
            // txt_product
            // 
            this.txt_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product.Location = new System.Drawing.Point(150, 12);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(169, 23);
            this.txt_product.TabIndex = 23;
            this.txt_product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_product_KeyDown);
            this.txt_product.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_product_KeyUp);
            this.txt_product.Leave += new System.EventHandler(this.txt_product_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(449, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // purchase_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.list_product);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_purchasetype);
            this.Controls.Add(this.label_unit);
            this.Controls.Add(this.textBox_profit);
            this.Controls.Add(this.date_expiry);
            this.Controls.Add(this.comboBox_dealername);
            this.Controls.Add(this.date_purchase);
            this.Controls.Add(this.textBox_totalprice);
            this.Controls.Add(this.textBox2_pice);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.label_profit);
            this.Controls.Add(this.label_expirydate);
            this.Controls.Add(this.label_purchasetype);
            this.Controls.Add(this.label6_dealername);
            this.Controls.Add(this.label_purchasedate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelprice);
            this.Controls.Add(this.labelquantity);
            this.Controls.Add(this.label_productname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "purchase_master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "purchase_master";
            this.Load += new System.EventHandler(this.purchase_master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_productname;
        private System.Windows.Forms.Label labelquantity;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_purchasedate;
        private System.Windows.Forms.Label label6_dealername;
        private System.Windows.Forms.Label label_purchasetype;
        private System.Windows.Forms.Label label_expirydate;
        private System.Windows.Forms.Label label_profit;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.TextBox textBox2_pice;
        private System.Windows.Forms.TextBox textBox_totalprice;
        private System.Windows.Forms.DateTimePicker date_purchase;
        private System.Windows.Forms.ComboBox comboBox_dealername;
        private System.Windows.Forms.DateTimePicker date_expiry;
        private System.Windows.Forms.TextBox textBox_profit;
        private System.Windows.Forms.Label label_unit;
        private System.Windows.Forms.ComboBox comboBox_purchasetype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox list_product;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}