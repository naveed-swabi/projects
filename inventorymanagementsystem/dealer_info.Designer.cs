namespace inventorymanagementsystem
{
    partial class dealer_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dealer_info));
            this.label_dealername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.textBox_company = new System.Windows.Forms.TextBox();
            this.textBox_dealername = new System.Windows.Forms.TextBox();
            this.label_city = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_contact = new System.Windows.Forms.Label();
            this.label_company = new System.Windows.Forms.Label();
            this.button_deletedealer = new System.Windows.Forms.Button();
            this.button_updatedealer = new System.Windows.Forms.Button();
            this.button_adddealer = new System.Windows.Forms.Button();
            this.dataGridView_dealer = new System.Windows.Forms.DataGridView();
            this.button_searchdealer = new System.Windows.Forms.Button();
            this.textBox_searchdealer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_dealername
            // 
            this.label_dealername.AutoSize = true;
            this.label_dealername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dealername.Location = new System.Drawing.Point(18, 17);
            this.label_dealername.Name = "label_dealername";
            this.label_dealername.Size = new System.Drawing.Size(102, 17);
            this.label_dealername.TabIndex = 0;
            this.label_dealername.Text = "Dealer Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_city);
            this.panel1.Controls.Add(this.textBox_address);
            this.panel1.Controls.Add(this.textBox_contact);
            this.panel1.Controls.Add(this.textBox_company);
            this.panel1.Controls.Add(this.textBox_dealername);
            this.panel1.Controls.Add(this.label_city);
            this.panel1.Controls.Add(this.label_address);
            this.panel1.Controls.Add(this.label_contact);
            this.panel1.Controls.Add(this.label_company);
            this.panel1.Controls.Add(this.label_dealername);
            this.panel1.Location = new System.Drawing.Point(12, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 210);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox_city
            // 
            this.textBox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_city.Location = new System.Drawing.Point(120, 169);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(123, 23);
            this.textBox_city.TabIndex = 10;
            this.textBox_city.TextChanged += new System.EventHandler(this.textBox_city_TextChanged);
            this.textBox_city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_city_KeyPress);
            // 
            // textBox_address
            // 
            this.textBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(120, 134);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(123, 23);
            this.textBox_address.TabIndex = 9;
            this.textBox_address.TextChanged += new System.EventHandler(this.textBox_address_TextChanged);
            // 
            // textBox_contact
            // 
            this.textBox_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contact.Location = new System.Drawing.Point(120, 95);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(123, 23);
            this.textBox_contact.TabIndex = 8;
            this.textBox_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_contact_KeyPress);
            // 
            // textBox_company
            // 
            this.textBox_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_company.Location = new System.Drawing.Point(120, 60);
            this.textBox_company.Name = "textBox_company";
            this.textBox_company.Size = new System.Drawing.Size(123, 23);
            this.textBox_company.TabIndex = 7;
            this.textBox_company.TextChanged += new System.EventHandler(this.textBox_company_TextChanged);
            this.textBox_company.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_company_KeyPress);
            // 
            // textBox_dealername
            // 
            this.textBox_dealername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dealername.Location = new System.Drawing.Point(120, 14);
            this.textBox_dealername.Name = "textBox_dealername";
            this.textBox_dealername.Size = new System.Drawing.Size(123, 23);
            this.textBox_dealername.TabIndex = 6;
            this.textBox_dealername.TextChanged += new System.EventHandler(this.textBox_dealername_TextChanged);
            this.textBox_dealername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_dealername_KeyPress);
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_city.Location = new System.Drawing.Point(18, 175);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(35, 17);
            this.label_city.TabIndex = 4;
            this.label_city.Text = "City";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.Location = new System.Drawing.Point(18, 137);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(67, 17);
            this.label_address.TabIndex = 3;
            this.label_address.Text = "Address";
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contact.Location = new System.Drawing.Point(18, 95);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(63, 17);
            this.label_contact.TabIndex = 2;
            this.label_contact.Text = "Contact";
            // 
            // label_company
            // 
            this.label_company.AutoSize = true;
            this.label_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_company.Location = new System.Drawing.Point(18, 60);
            this.label_company.Name = "label_company";
            this.label_company.Size = new System.Drawing.Size(74, 17);
            this.label_company.TabIndex = 1;
            this.label_company.Text = "Company";
            // 
            // button_deletedealer
            // 
            this.button_deletedealer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_deletedealer.BackgroundImage")));
            this.button_deletedealer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_deletedealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deletedealer.Location = new System.Drawing.Point(207, 327);
            this.button_deletedealer.Name = "button_deletedealer";
            this.button_deletedealer.Size = new System.Drawing.Size(83, 29);
            this.button_deletedealer.TabIndex = 17;
            this.button_deletedealer.UseVisualStyleBackColor = true;
            this.button_deletedealer.Click += new System.EventHandler(this.button_deletedealer_Click);
            // 
            // button_updatedealer
            // 
            this.button_updatedealer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_updatedealer.BackgroundImage")));
            this.button_updatedealer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_updatedealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updatedealer.Location = new System.Drawing.Point(109, 326);
            this.button_updatedealer.Name = "button_updatedealer";
            this.button_updatedealer.Size = new System.Drawing.Size(92, 29);
            this.button_updatedealer.TabIndex = 13;
            this.button_updatedealer.UseVisualStyleBackColor = true;
            this.button_updatedealer.Click += new System.EventHandler(this.button_updatedealer_Click);
            // 
            // button_adddealer
            // 
            this.button_adddealer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_adddealer.BackgroundImage")));
            this.button_adddealer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_adddealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adddealer.Location = new System.Drawing.Point(12, 327);
            this.button_adddealer.Name = "button_adddealer";
            this.button_adddealer.Size = new System.Drawing.Size(81, 28);
            this.button_adddealer.TabIndex = 12;
            this.button_adddealer.UseVisualStyleBackColor = true;
            this.button_adddealer.Click += new System.EventHandler(this.button_adddealer_Click);
            // 
            // dataGridView_dealer
            // 
            this.dataGridView_dealer.AllowUserToAddRows = false;
            this.dataGridView_dealer.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView_dealer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dealer.Location = new System.Drawing.Point(261, 13);
            this.dataGridView_dealer.Name = "dataGridView_dealer";
            this.dataGridView_dealer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_dealer.Size = new System.Drawing.Size(509, 298);
            this.dataGridView_dealer.TabIndex = 13;
            this.dataGridView_dealer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_dealer_CellClick);
            // 
            // button_searchdealer
            // 
            this.button_searchdealer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_searchdealer.BackgroundImage")));
            this.button_searchdealer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_searchdealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchdealer.Location = new System.Drawing.Point(582, 326);
            this.button_searchdealer.Name = "button_searchdealer";
            this.button_searchdealer.Size = new System.Drawing.Size(86, 29);
            this.button_searchdealer.TabIndex = 16;
            this.button_searchdealer.UseVisualStyleBackColor = true;
            this.button_searchdealer.Click += new System.EventHandler(this.button_searchdealer_Click);
            // 
            // textBox_searchdealer
            // 
            this.textBox_searchdealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_searchdealer.Location = new System.Drawing.Point(404, 329);
            this.textBox_searchdealer.Name = "textBox_searchdealer";
            this.textBox_searchdealer.Size = new System.Drawing.Size(172, 23);
            this.textBox_searchdealer.TabIndex = 15;
            this.textBox_searchdealer.TextChanged += new System.EventHandler(this.textBox_searchdealer_TextChanged);
            this.textBox_searchdealer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_searchdealer_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dealer Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // dealer_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_searchdealer);
            this.Controls.Add(this.button_deletedealer);
            this.Controls.Add(this.textBox_searchdealer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_updatedealer);
            this.Controls.Add(this.button_adddealer);
            this.Controls.Add(this.dataGridView_dealer);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dealer_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dealer_info";
            this.Load += new System.EventHandler(this.dealer_info_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_dealername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_company;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.Button button_adddealer;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.TextBox textBox_company;
        private System.Windows.Forms.TextBox textBox_dealername;
        private System.Windows.Forms.DataGridView dataGridView_dealer;
        private System.Windows.Forms.Button button_updatedealer;
        private System.Windows.Forms.TextBox textBox_searchdealer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_searchdealer;
        private System.Windows.Forms.Button button_deletedealer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}