namespace inventorymanagementsystem
{
    partial class stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stock));
            this.list_product = new System.Windows.Forms.ListBox();
            this.txt_serchproduct = new System.Windows.Forms.TextBox();
            this.button_searh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_showallproduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // list_product
            // 
            this.list_product.FormattingEnabled = true;
            this.list_product.Location = new System.Drawing.Point(479, 47);
            this.list_product.Name = "list_product";
            this.list_product.Size = new System.Drawing.Size(100, 30);
            this.list_product.TabIndex = 15;
            this.list_product.Visible = false;
            this.list_product.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_product_MouseClick);
            this.list_product.SelectedIndexChanged += new System.EventHandler(this.list_product_SelectedIndexChanged);
            this.list_product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.list_product_KeyDown);
            // 
            // txt_serchproduct
            // 
            this.txt_serchproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serchproduct.Location = new System.Drawing.Point(479, 18);
            this.txt_serchproduct.Name = "txt_serchproduct";
            this.txt_serchproduct.Size = new System.Drawing.Size(100, 29);
            this.txt_serchproduct.TabIndex = 14;
            this.txt_serchproduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_serchproduct_KeyDown);
            this.txt_serchproduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_serchproduct_KeyPress);
            this.txt_serchproduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_serchproduct_KeyUp);
            // 
            // button_searh
            // 
            this.button_searh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_searh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_searh.BackgroundImage")));
            this.button_searh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_searh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searh.Location = new System.Drawing.Point(354, 18);
            this.button_searh.Name = "button_searh";
            this.button_searh.Size = new System.Drawing.Size(119, 32);
            this.button_searh.TabIndex = 12;
            this.button_searh.UseVisualStyleBackColor = false;
            this.button_searh.Click += new System.EventHandler(this.button_searh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(161, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 301);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_showallproduct
            // 
            this.button_showallproduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_showallproduct.BackgroundImage")));
            this.button_showallproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_showallproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showallproduct.Location = new System.Drawing.Point(354, 47);
            this.button_showallproduct.Name = "button_showallproduct";
            this.button_showallproduct.Size = new System.Drawing.Size(119, 32);
            this.button_showallproduct.TabIndex = 18;
            this.button_showallproduct.UseVisualStyleBackColor = true;
            this.button_showallproduct.Click += new System.EventHandler(this.button_showallproduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_showallproduct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.list_product);
            this.Controls.Add(this.txt_serchproduct);
            this.Controls.Add(this.button_searh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_product;
        private System.Windows.Forms.TextBox txt_serchproduct;
        private System.Windows.Forms.Button button_searh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_showallproduct;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}