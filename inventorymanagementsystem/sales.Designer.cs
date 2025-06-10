namespace inventorymanagementsystem
{
    partial class sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_units = new System.Windows.Forms.ComboBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label_total = new System.Windows.Forms.Label();
            this.selectdate = new System.Windows.Forms.DateTimePicker();
            this.cmb_bill = new System.Windows.Forms.ComboBox();
            this.list_product = new System.Windows.Forms.ListBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.bttn_add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_totalpayement = new System.Windows.Forms.Label();
            this.bttn_delete = new System.Windows.Forms.Button();
            this.bttn_save = new System.Windows.Forms.Button();
            this.button_saveandprint = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_preiv = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBox_units);
            this.panel1.Controls.Add(this.txt_total);
            this.panel1.Controls.Add(this.label_total);
            this.panel1.Controls.Add(this.selectdate);
            this.panel1.Controls.Add(this.cmb_bill);
            this.panel1.Controls.Add(this.list_product);
            this.panel1.Controls.Add(this.txt_quantity);
            this.panel1.Controls.Add(this.txt_price);
            this.panel1.Controls.Add(this.txt_product);
            this.panel1.Controls.Add(this.txt_contact);
            this.panel1.Controls.Add(this.txt_customername);
            this.panel1.Controls.Add(this.bttn_add);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 139);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(274, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(271, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Unit";
            // 
            // comboBox_units
            // 
            this.comboBox_units.FormattingEnabled = true;
            this.comboBox_units.Items.AddRange(new object[] {
            "Cash",
            "Debit",
            "Easy Paisa"});
            this.comboBox_units.Location = new System.Drawing.Point(323, 44);
            this.comboBox_units.Name = "comboBox_units";
            this.comboBox_units.Size = new System.Drawing.Size(71, 21);
            this.comboBox_units.TabIndex = 19;
            this.comboBox_units.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_units_KeyUp);
            this.comboBox_units.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboBox_units_MouseMove);
            this.comboBox_units.Move += new System.EventHandler(this.comboBox_units_Move);
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(669, 73);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(112, 20);
            this.txt_total.TabIndex = 18;
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(670, 67);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(0, 17);
            this.label_total.TabIndex = 17;
            // 
            // selectdate
            // 
            this.selectdate.CustomFormat = "dd/MM/yyyy";
            this.selectdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selectdate.Location = new System.Drawing.Point(652, 5);
            this.selectdate.Name = "selectdate";
            this.selectdate.Size = new System.Drawing.Size(129, 20);
            this.selectdate.TabIndex = 16;
            // 
            // cmb_bill
            // 
            this.cmb_bill.FormattingEnabled = true;
            this.cmb_bill.Items.AddRange(new object[] {
            "Cash",
            "Debit",
            "Easy Paisa"});
            this.cmb_bill.Location = new System.Drawing.Point(516, 9);
            this.cmb_bill.Name = "cmb_bill";
            this.cmb_bill.Size = new System.Drawing.Size(71, 21);
            this.cmb_bill.TabIndex = 15;
            // 
            // list_product
            // 
            this.list_product.FormattingEnabled = true;
            this.list_product.Location = new System.Drawing.Point(121, 93);
            this.list_product.Name = "list_product";
            this.list_product.Size = new System.Drawing.Size(144, 43);
            this.list_product.TabIndex = 14;
            this.list_product.Visible = false;
            this.list_product.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_product_MouseClick);
            this.list_product.SelectedIndexChanged += new System.EventHandler(this.list_product_SelectedIndexChanged);
            this.list_product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.list_product_KeyDown);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(669, 44);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(112, 20);
            this.txt_quantity.TabIndex = 13;
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            this.txt_quantity.Leave += new System.EventHandler(this.txt_quantity_Leave);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(516, 47);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(74, 20);
            this.txt_price.TabIndex = 12;
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            this.txt_price.Leave += new System.EventHandler(this.txt_price_Leave);
            // 
            // txt_product
            // 
            this.txt_product.Location = new System.Drawing.Point(121, 48);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(144, 20);
            this.txt_product.TabIndex = 11;
            this.txt_product.TextChanged += new System.EventHandler(this.txt_product_TextChanged);
            this.txt_product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_product_KeyDown);
            this.txt_product.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_product_KeyUp);
            this.txt_product.Leave += new System.EventHandler(this.txt_product_Leave);
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(323, 13);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(110, 20);
            this.txt_contact.TabIndex = 9;
            this.txt_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contact_KeyPress);
            // 
            // txt_customername
            // 
            this.txt_customername.Location = new System.Drawing.Point(121, 13);
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(144, 20);
            this.txt_customername.TabIndex = 8;
            this.txt_customername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_customername_KeyPress);
            // 
            // bttn_add
            // 
            this.bttn_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_add.BackgroundImage")));
            this.bttn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttn_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttn_add.FlatAppearance.BorderSize = 2;
            this.bttn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_add.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.bttn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_add.Location = new System.Drawing.Point(669, 99);
            this.bttn_add.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.bttn_add.Name = "bttn_add";
            this.bttn_add.Size = new System.Drawing.Size(112, 28);
            this.bttn_add.TabIndex = 7;
            this.bttn_add.Text = "Add";
            this.bttn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttn_add.UseVisualStyleBackColor = false;
            this.bttn_add.Click += new System.EventHandler(this.bttn_add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(596, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(596, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(596, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bill Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(464, 159);
            this.dataGridView1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(484, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total=";
            // 
            // lbl_totalpayement
            // 
            this.lbl_totalpayement.AutoSize = true;
            this.lbl_totalpayement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalpayement.Location = new System.Drawing.Point(544, 185);
            this.lbl_totalpayement.Name = "lbl_totalpayement";
            this.lbl_totalpayement.Size = new System.Drawing.Size(17, 17);
            this.lbl_totalpayement.TabIndex = 9;
            this.lbl_totalpayement.Text = "0";
            // 
            // bttn_delete
            // 
            this.bttn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_delete.BackgroundImage")));
            this.bttn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_delete.Location = new System.Drawing.Point(487, 205);
            this.bttn_delete.Name = "bttn_delete";
            this.bttn_delete.Size = new System.Drawing.Size(124, 28);
            this.bttn_delete.TabIndex = 10;
            this.bttn_delete.UseVisualStyleBackColor = true;
            this.bttn_delete.Click += new System.EventHandler(this.bttn_delete_Click);
            // 
            // bttn_save
            // 
            this.bttn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_save.BackgroundImage")));
            this.bttn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_save.Location = new System.Drawing.Point(488, 232);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(123, 34);
            this.bttn_save.TabIndex = 11;
            this.bttn_save.UseVisualStyleBackColor = true;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // button_saveandprint
            // 
            this.button_saveandprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_saveandprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_saveandprint.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_saveandprint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_saveandprint.Location = new System.Drawing.Point(488, 311);
            this.button_saveandprint.Name = "button_saveandprint";
            this.button_saveandprint.Size = new System.Drawing.Size(123, 33);
            this.button_saveandprint.TabIndex = 12;
            this.button_saveandprint.Text = "SAVE - PRINT";
            this.button_saveandprint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_saveandprint.UseVisualStyleBackColor = false;
            this.button_saveandprint.Click += new System.EventHandler(this.button_saveandprint_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_preiv
            // 
            this.btn_preiv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_preiv.BackgroundImage")));
            this.btn_preiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_preiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preiv.Location = new System.Drawing.Point(488, 272);
            this.btn_preiv.Name = "btn_preiv";
            this.btn_preiv.Size = new System.Drawing.Size(123, 33);
            this.btn_preiv.TabIndex = 13;
            this.btn_preiv.UseVisualStyleBackColor = true;
            this.btn_preiv.Click += new System.EventHandler(this.btn_preiv_Click);
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_preiv);
            this.Controls.Add(this.button_saveandprint);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.bttn_delete);
            this.Controls.Add(this.lbl_totalpayement);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sales";
            this.Load += new System.EventHandler(this.sales_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sales_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_totalpayement;
        private System.Windows.Forms.Button bttn_delete;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.ComboBox cmb_bill;
        private System.Windows.Forms.ListBox list_product;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button button_saveandprint;
        private System.Windows.Forms.DateTimePicker selectdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_units;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_preiv;
        private System.Windows.Forms.Button bttn_add;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}