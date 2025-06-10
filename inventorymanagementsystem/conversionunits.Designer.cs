namespace inventorymanagementsystem
{
    partial class conversionunits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conversionunits));
            this.conversionFactorTextBox = new System.Windows.Forms.TextBox();
            this.toUnitComboBox = new System.Windows.Forms.ComboBox();
            this.fromUnitComboBox = new System.Windows.Forms.ComboBox();
            this.addConversionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelproduct = new System.Windows.Forms.Label();
            this.txt_serchproduct = new System.Windows.Forms.TextBox();
            this.list_product = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // conversionFactorTextBox
            // 
            this.conversionFactorTextBox.Location = new System.Drawing.Point(310, 153);
            this.conversionFactorTextBox.Name = "conversionFactorTextBox";
            this.conversionFactorTextBox.Size = new System.Drawing.Size(121, 20);
            this.conversionFactorTextBox.TabIndex = 1;
            // 
            // toUnitComboBox
            // 
            this.toUnitComboBox.FormattingEnabled = true;
            this.toUnitComboBox.Location = new System.Drawing.Point(310, 126);
            this.toUnitComboBox.Name = "toUnitComboBox";
            this.toUnitComboBox.Size = new System.Drawing.Size(121, 21);
            this.toUnitComboBox.TabIndex = 3;
            // 
            // fromUnitComboBox
            // 
            this.fromUnitComboBox.FormattingEnabled = true;
            this.fromUnitComboBox.Location = new System.Drawing.Point(310, 99);
            this.fromUnitComboBox.Name = "fromUnitComboBox";
            this.fromUnitComboBox.Size = new System.Drawing.Size(121, 21);
            this.fromUnitComboBox.TabIndex = 4;
            // 
            // addConversionButton
            // 
            this.addConversionButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.addConversionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addConversionButton.BackgroundImage")));
            this.addConversionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addConversionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addConversionButton.Location = new System.Drawing.Point(308, 179);
            this.addConversionButton.Name = "addConversionButton";
            this.addConversionButton.Size = new System.Drawing.Size(123, 28);
            this.addConversionButton.TabIndex = 5;
            this.addConversionButton.UseVisualStyleBackColor = false;
            this.addConversionButton.Click += new System.EventHandler(this.addConversionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = " From";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Equal ";
            // 
            // labelproduct
            // 
            this.labelproduct.AutoSize = true;
            this.labelproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproduct.Location = new System.Drawing.Point(235, 38);
            this.labelproduct.Name = "labelproduct";
            this.labelproduct.Size = new System.Drawing.Size(64, 17);
            this.labelproduct.TabIndex = 9;
            this.labelproduct.Text = "Product";
            // 
            // txt_serchproduct
            // 
            this.txt_serchproduct.Location = new System.Drawing.Point(308, 37);
            this.txt_serchproduct.Name = "txt_serchproduct";
            this.txt_serchproduct.Size = new System.Drawing.Size(121, 20);
            this.txt_serchproduct.TabIndex = 1;
            this.txt_serchproduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_serchproduct_KeyDown);
            this.txt_serchproduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_serchproduct_KeyUp);
            // 
            // list_product
            // 
            this.list_product.FormattingEnabled = true;
            this.list_product.Location = new System.Drawing.Point(310, 63);
            this.list_product.Name = "list_product";
            this.list_product.Size = new System.Drawing.Size(121, 30);
            this.list_product.TabIndex = 22;
            this.list_product.Visible = false;
            this.list_product.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_product_MouseClick);
            this.list_product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.list_product_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(813, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // conversionunits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.list_product);
            this.Controls.Add(this.txt_serchproduct);
            this.Controls.Add(this.labelproduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addConversionButton);
            this.Controls.Add(this.fromUnitComboBox);
            this.Controls.Add(this.toUnitComboBox);
            this.Controls.Add(this.conversionFactorTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "conversionunits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "conversionunits";
            this.Load += new System.EventHandler(this.conversionunits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox conversionFactorTextBox;
        private System.Windows.Forms.ComboBox toUnitComboBox;
        private System.Windows.Forms.ComboBox fromUnitComboBox;
        private System.Windows.Forms.Button addConversionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelproduct;
        private System.Windows.Forms.TextBox txt_serchproduct;
        private System.Windows.Forms.ListBox list_product;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}