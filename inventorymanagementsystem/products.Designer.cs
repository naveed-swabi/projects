namespace inventorymanagementsystem
{
    partial class products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(products));
            this.label_addproduct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_addproduct = new System.Windows.Forms.TextBox();
            this.comboBox_unit = new System.Windows.Forms.ComboBox();
            this.button_addproduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_product = new System.Windows.Forms.DataGridView();
            this.panel_update = new System.Windows.Forms.Panel();
            this.comboBox_unit2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_product2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_deleteproduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_searchproduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.list_product = new System.Windows.Forms.ListBox();
            this.txt_serchproduct = new System.Windows.Forms.TextBox();
            this.button_searchall = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            this.panel_update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_addproduct
            // 
            this.label_addproduct.AutoSize = true;
            this.label_addproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addproduct.Location = new System.Drawing.Point(14, 21);
            this.label_addproduct.Name = "label_addproduct";
            this.label_addproduct.Size = new System.Drawing.Size(143, 17);
            this.label_addproduct.TabIndex = 0;
            this.label_addproduct.Text = "Add Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Unit";
            // 
            // textBox_addproduct
            // 
            this.textBox_addproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_addproduct.Location = new System.Drawing.Point(163, 18);
            this.textBox_addproduct.Name = "textBox_addproduct";
            this.textBox_addproduct.Size = new System.Drawing.Size(144, 23);
            this.textBox_addproduct.TabIndex = 2;
            this.textBox_addproduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_addproduct_KeyPress);
            // 
            // comboBox_unit
            // 
            this.comboBox_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_unit.FormattingEnabled = true;
            this.comboBox_unit.Location = new System.Drawing.Point(420, 17);
            this.comboBox_unit.Name = "comboBox_unit";
            this.comboBox_unit.Size = new System.Drawing.Size(144, 24);
            this.comboBox_unit.TabIndex = 3;
            this.comboBox_unit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_addproduct
            // 
            this.button_addproduct.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_addproduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_addproduct.BackgroundImage")));
            this.button_addproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_addproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addproduct.Location = new System.Drawing.Point(570, 14);
            this.button_addproduct.Name = "button_addproduct";
            this.button_addproduct.Size = new System.Drawing.Size(93, 29);
            this.button_addproduct.TabIndex = 4;
            this.button_addproduct.UseVisualStyleBackColor = false;
            this.button_addproduct.Click += new System.EventHandler(this.button_addproduct_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_searchall);
            this.panel1.Controls.Add(this.label_addproduct);
            this.panel1.Controls.Add(this.button_addproduct);
            this.panel1.Controls.Add(this.textBox_addproduct);
            this.panel1.Controls.Add(this.comboBox_unit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(24, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 80);
            this.panel1.TabIndex = 5;
            // 
            // dataGridView_product
            // 
            this.dataGridView_product.AllowUserToAddRows = false;
            this.dataGridView_product.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_product.Location = new System.Drawing.Point(363, 199);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_product.Size = new System.Drawing.Size(416, 150);
            this.dataGridView_product.TabIndex = 5;
            this.dataGridView_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_product_CellClick);
            this.dataGridView_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_product_CellContentClick);
            // 
            // panel_update
            // 
            this.panel_update.Controls.Add(this.comboBox_unit2);
            this.panel_update.Controls.Add(this.label3);
            this.panel_update.Controls.Add(this.textBox_product2);
            this.panel_update.Controls.Add(this.label1);
            this.panel_update.Location = new System.Drawing.Point(24, 199);
            this.panel_update.Name = "panel_update";
            this.panel_update.Size = new System.Drawing.Size(333, 150);
            this.panel_update.TabIndex = 6;
            // 
            // comboBox_unit2
            // 
            this.comboBox_unit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_unit2.FormattingEnabled = true;
            this.comboBox_unit2.Location = new System.Drawing.Point(160, 41);
            this.comboBox_unit2.Name = "comboBox_unit2";
            this.comboBox_unit2.Size = new System.Drawing.Size(144, 24);
            this.comboBox_unit2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Unit";
            // 
            // textBox_product2
            // 
            this.textBox_product2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_product2.Location = new System.Drawing.Point(160, 7);
            this.textBox_product2.Name = "textBox_product2";
            this.textBox_product2.Size = new System.Drawing.Size(144, 23);
            this.textBox_product2.TabIndex = 3;
            this.textBox_product2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_product2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(121, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 28);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_deleteproduct
            // 
            this.button_deleteproduct.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_deleteproduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_deleteproduct.BackgroundImage")));
            this.button_deleteproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_deleteproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteproduct.Location = new System.Drawing.Point(252, 371);
            this.button_deleteproduct.Name = "button_deleteproduct";
            this.button_deleteproduct.Size = new System.Drawing.Size(105, 28);
            this.button_deleteproduct.TabIndex = 9;
            this.button_deleteproduct.UseVisualStyleBackColor = false;
            this.button_deleteproduct.Click += new System.EventHandler(this.button_deleteproduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Product Name";
            // 
            // button_searchproduct
            // 
            this.button_searchproduct.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_searchproduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_searchproduct.BackgroundImage")));
            this.button_searchproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_searchproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchproduct.Location = new System.Drawing.Point(684, 374);
            this.button_searchproduct.Name = "button_searchproduct";
            this.button_searchproduct.Size = new System.Drawing.Size(94, 28);
            this.button_searchproduct.TabIndex = 10;
            this.button_searchproduct.UseVisualStyleBackColor = false;
            this.button_searchproduct.Click += new System.EventHandler(this.button_searchproduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // list_product
            // 
            this.list_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_product.FormattingEnabled = true;
            this.list_product.ItemHeight = 20;
            this.list_product.Location = new System.Drawing.Point(526, 399);
            this.list_product.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.list_product.Name = "list_product";
            this.list_product.Size = new System.Drawing.Size(152, 24);
            this.list_product.TabIndex = 23;
            this.list_product.Visible = false;
            this.list_product.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_product_MouseClick);
            this.list_product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.list_product_KeyDown);
            // 
            // txt_serchproduct
            // 
            this.txt_serchproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serchproduct.Location = new System.Drawing.Point(526, 375);
            this.txt_serchproduct.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_serchproduct.Name = "txt_serchproduct";
            this.txt_serchproduct.Size = new System.Drawing.Size(152, 24);
            this.txt_serchproduct.TabIndex = 22;
            this.txt_serchproduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_serchproduct_KeyDown);
            this.txt_serchproduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_serchproduct_KeyUp);
            // 
            // button_searchall
            // 
            this.button_searchall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_searchall.BackgroundImage")));
            this.button_searchall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_searchall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchall.Location = new System.Drawing.Point(660, 14);
            this.button_searchall.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button_searchall.Name = "button_searchall";
            this.button_searchall.Size = new System.Drawing.Size(94, 29);
            this.button_searchall.TabIndex = 24;
            this.button_searchall.UseVisualStyleBackColor = true;
            this.button_searchall.Click += new System.EventHandler(this.button_searchall_Click);
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_product);
            this.Controls.Add(this.txt_serchproduct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_deleteproduct);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_searchproduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel_update);
            this.Controls.Add(this.dataGridView_product);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "product";
            this.Load += new System.EventHandler(this.product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            this.panel_update.ResumeLayout(false);
            this.panel_update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_addproduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_addproduct;
        private System.Windows.Forms.ComboBox comboBox_unit;
        private System.Windows.Forms.Button button_addproduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_product;
        private System.Windows.Forms.Panel panel_update;
        private System.Windows.Forms.ComboBox comboBox_unit2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_product2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_deleteproduct;
        private System.Windows.Forms.Button button_searchproduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox list_product;
        private System.Windows.Forms.TextBox txt_serchproduct;
        private System.Windows.Forms.Button button_searchall;
    }
}