namespace inventorymanagementsystem
{
    partial class purchase_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(purchase_report));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_searh = new System.Windows.Forms.Button();
            this.button_searchall = new System.Windows.Forms.Button();
            this.label_total = new System.Windows.Forms.Label();
            this.dateTimePicker_startdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_enddate = new System.Windows.Forms.DateTimePicker();
            this.txt_serchproduct = new System.Windows.Forms.TextBox();
            this.list_product = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "START DATE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "END DATE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_searh
            // 
            this.button_searh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_searh.BackgroundImage")));
            this.button_searh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_searh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searh.Location = new System.Drawing.Point(421, 142);
            this.button_searh.Name = "button_searh";
            this.button_searh.Size = new System.Drawing.Size(104, 30);
            this.button_searh.TabIndex = 3;
            this.button_searh.UseVisualStyleBackColor = true;
            this.button_searh.Click += new System.EventHandler(this.button_searh_Click);
            // 
            // button_searchall
            // 
            this.button_searchall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_searchall.BackgroundImage")));
            this.button_searchall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_searchall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchall.Location = new System.Drawing.Point(421, 172);
            this.button_searchall.Name = "button_searchall";
            this.button_searchall.Size = new System.Drawing.Size(104, 30);
            this.button_searchall.TabIndex = 4;
            this.button_searchall.Text = " ";
            this.button_searchall.UseVisualStyleBackColor = true;
            this.button_searchall.Click += new System.EventHandler(this.button_searchall_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(545, 441);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(17, 17);
            this.label_total.TabIndex = 5;
            this.label_total.Text = "0";
            // 
            // dateTimePicker_startdate
            // 
            this.dateTimePicker_startdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_startdate.Location = new System.Drawing.Point(167, 148);
            this.dateTimePicker_startdate.Name = "dateTimePicker_startdate";
            this.dateTimePicker_startdate.Size = new System.Drawing.Size(248, 24);
            this.dateTimePicker_startdate.TabIndex = 6;
            this.dateTimePicker_startdate.ValueChanged += new System.EventHandler(this.dateTimePicker_startdate_ValueChanged);
            // 
            // dateTimePicker_enddate
            // 
            this.dateTimePicker_enddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_enddate.Location = new System.Drawing.Point(167, 178);
            this.dateTimePicker_enddate.Name = "dateTimePicker_enddate";
            this.dateTimePicker_enddate.Size = new System.Drawing.Size(248, 24);
            this.dateTimePicker_enddate.TabIndex = 7;
            this.dateTimePicker_enddate.ValueChanged += new System.EventHandler(this.dateTimePicker_enddate_ValueChanged);
            // 
            // txt_serchproduct
            // 
            this.txt_serchproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serchproduct.Location = new System.Drawing.Point(531, 142);
            this.txt_serchproduct.Name = "txt_serchproduct";
            this.txt_serchproduct.Size = new System.Drawing.Size(151, 27);
            this.txt_serchproduct.TabIndex = 10;
            this.txt_serchproduct.TextChanged += new System.EventHandler(this.txt_serchproduct_TextChanged);
            this.txt_serchproduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_serchproduct_KeyDown);
            this.txt_serchproduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_serchproduct_KeyUp);
            // 
            // list_product
            // 
            this.list_product.FormattingEnabled = true;
            this.list_product.Location = new System.Drawing.Point(531, 172);
            this.list_product.Name = "list_product";
            this.list_product.Size = new System.Drawing.Size(151, 30);
            this.list_product.TabIndex = 11;
            this.list_product.Visible = false;
            this.list_product.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_product_MouseClick);
            this.list_product.SelectedIndexChanged += new System.EventHandler(this.list_product_SelectedIndexChanged);
            this.list_product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.list_product_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // purchase_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.list_product);
            this.Controls.Add(this.txt_serchproduct);
            this.Controls.Add(this.dateTimePicker_enddate);
            this.Controls.Add(this.dateTimePicker_startdate);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.button_searchall);
            this.Controls.Add(this.button_searh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "purchase_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "purchase_report";
            this.Load += new System.EventHandler(this.purchase_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_searh;
        private System.Windows.Forms.Button button_searchall;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_enddate;
        private System.Windows.Forms.TextBox txt_serchproduct;
        private System.Windows.Forms.ListBox list_product;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}