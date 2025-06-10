namespace inventorymanagementsystem
{
    partial class sales_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sales_report));
            this.list_product = new System.Windows.Forms.ListBox();
            this.txt_serchproduct = new System.Windows.Forms.TextBox();
            this.button_print = new System.Windows.Forms.Button();
            this.dateTimePicker_enddate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_startdate = new System.Windows.Forms.DateTimePicker();
            this.button_searchall = new System.Windows.Forms.Button();
            this.button_searh = new System.Windows.Forms.Button();
            this.grid_sales = new System.Windows.Forms.DataGridView();
            this.label_total = new System.Windows.Forms.Label();
            this.txtsearchorderno = new System.Windows.Forms.TextBox();
            this.bttn_searchorder = new System.Windows.Forms.Button();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.bttn_preview = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // list_product
            // 
            this.list_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_product.FormattingEnabled = true;
            this.list_product.ItemHeight = 20;
            this.list_product.Location = new System.Drawing.Point(785, 103);
            this.list_product.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.list_product.Name = "list_product";
            this.list_product.Size = new System.Drawing.Size(152, 24);
            this.list_product.TabIndex = 21;
            this.list_product.Visible = false;
            this.list_product.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_product_MouseClick);
            this.list_product.SelectedIndexChanged += new System.EventHandler(this.list_product_SelectedIndexChanged);
            this.list_product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.list_product_KeyDown);
            // 
            // txt_serchproduct
            // 
            this.txt_serchproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serchproduct.Location = new System.Drawing.Point(785, 69);
            this.txt_serchproduct.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_serchproduct.Name = "txt_serchproduct";
            this.txt_serchproduct.Size = new System.Drawing.Size(152, 24);
            this.txt_serchproduct.TabIndex = 20;
            this.txt_serchproduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_serchproduct_KeyDown);
            this.txt_serchproduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_serchproduct_KeyUp);
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_print.BackgroundImage")));
            this.button_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_print.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_print.FlatAppearance.BorderSize = 2;
            this.button_print.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.SystemColors.Info;
            this.button_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_print.Location = new System.Drawing.Point(785, 187);
            this.button_print.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(152, 31);
            this.button_print.TabIndex = 19;
            this.button_print.Text = "Print ";
            this.button_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_print.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // dateTimePicker_enddate
            // 
            this.dateTimePicker_enddate.Location = new System.Drawing.Point(785, 41);
            this.dateTimePicker_enddate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker_enddate.Name = "dateTimePicker_enddate";
            this.dateTimePicker_enddate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker_enddate.TabIndex = 18;
            // 
            // dateTimePicker_startdate
            // 
            this.dateTimePicker_startdate.Location = new System.Drawing.Point(785, 7);
            this.dateTimePicker_startdate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker_startdate.Name = "dateTimePicker_startdate";
            this.dateTimePicker_startdate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker_startdate.TabIndex = 17;
            // 
            // button_searchall
            // 
            this.button_searchall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_searchall.BackgroundImage")));
            this.button_searchall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_searchall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchall.Location = new System.Drawing.Point(938, 69);
            this.button_searchall.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button_searchall.Name = "button_searchall";
            this.button_searchall.Size = new System.Drawing.Size(112, 24);
            this.button_searchall.TabIndex = 16;
            this.button_searchall.UseVisualStyleBackColor = true;
            this.button_searchall.Click += new System.EventHandler(this.button_searchall_Click);
            // 
            // button_searh
            // 
            this.button_searh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_searh.BackgroundImage")));
            this.button_searh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_searh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searh.Location = new System.Drawing.Point(606, 69);
            this.button_searh.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button_searh.Name = "button_searh";
            this.button_searh.Size = new System.Drawing.Size(149, 33);
            this.button_searh.TabIndex = 15;
            this.button_searh.UseVisualStyleBackColor = true;
            this.button_searh.Click += new System.EventHandler(this.button_searh_Click);
            // 
            // grid_sales
            // 
            this.grid_sales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_sales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid_sales.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grid_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sales.Location = new System.Drawing.Point(151, 229);
            this.grid_sales.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grid_sales.Name = "grid_sales";
            this.grid_sales.Size = new System.Drawing.Size(998, 234);
            this.grid_sales.TabIndex = 12;
            this.grid_sales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(835, 521);
            this.label_total.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(0, 17);
            this.label_total.TabIndex = 22;
            // 
            // txtsearchorderno
            // 
            this.txtsearchorderno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchorderno.Location = new System.Drawing.Point(785, 150);
            this.txtsearchorderno.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtsearchorderno.Name = "txtsearchorderno";
            this.txtsearchorderno.Size = new System.Drawing.Size(152, 26);
            this.txtsearchorderno.TabIndex = 24;
            // 
            // bttn_searchorder
            // 
            this.bttn_searchorder.BackColor = System.Drawing.Color.White;
            this.bttn_searchorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_searchorder.BackgroundImage")));
            this.bttn_searchorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttn_searchorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_searchorder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bttn_searchorder.Location = new System.Drawing.Point(938, 147);
            this.bttn_searchorder.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bttn_searchorder.Name = "bttn_searchorder";
            this.bttn_searchorder.Size = new System.Drawing.Size(112, 32);
            this.bttn_searchorder.TabIndex = 23;
            this.bttn_searchorder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bttn_searchorder.UseVisualStyleBackColor = false;
            this.bttn_searchorder.Click += new System.EventHandler(this.bttn_searchorder_Click);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog1";
            this.printPreviewDialog2.Visible = false;
            // 
            // bttn_preview
            // 
            this.bttn_preview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_preview.BackgroundImage")));
            this.bttn_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_preview.Location = new System.Drawing.Point(605, 187);
            this.bttn_preview.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bttn_preview.Name = "bttn_preview";
            this.bttn_preview.Size = new System.Drawing.Size(150, 31);
            this.bttn_preview.TabIndex = 25;
            this.bttn_preview.UseVisualStyleBackColor = true;
            this.bttn_preview.Click += new System.EventHandler(this.bttn_preview_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(612, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(612, 41);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(713, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(713, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Order No";
            // 
            // sales_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1164, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttn_preview);
            this.Controls.Add(this.txtsearchorderno);
            this.Controls.Add(this.bttn_searchorder);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.list_product);
            this.Controls.Add(this.txt_serchproduct);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.dateTimePicker_enddate);
            this.Controls.Add(this.dateTimePicker_startdate);
            this.Controls.Add(this.button_searchall);
            this.Controls.Add(this.button_searh);
            this.Controls.Add(this.grid_sales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "sales_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sales_report";
            this.Load += new System.EventHandler(this.sales_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_product;
        private System.Windows.Forms.TextBox txt_serchproduct;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.DateTimePicker dateTimePicker_enddate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startdate;
        private System.Windows.Forms.Button button_searchall;
        private System.Windows.Forms.Button button_searh;
        private System.Windows.Forms.DataGridView grid_sales;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.TextBox txtsearchorderno;
        private System.Windows.Forms.Button bttn_searchorder;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.Button bttn_preview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}