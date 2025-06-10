namespace inventorymanagementsystem
{
    partial class units
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(units));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_addunit = new System.Windows.Forms.TextBox();
            this.button_addunit = new System.Windows.Forms.Button();
            this.button_deletunit = new System.Windows.Forms.Button();
            this.dataGridViewunits = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewunits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(223, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit";
            // 
            // textBox_addunit
            // 
            this.textBox_addunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_addunit.Location = new System.Drawing.Point(266, 282);
            this.textBox_addunit.Name = "textBox_addunit";
            this.textBox_addunit.Size = new System.Drawing.Size(120, 23);
            this.textBox_addunit.TabIndex = 1;
            // 
            // button_addunit
            // 
            this.button_addunit.BackColor = System.Drawing.Color.PaleGreen;
            this.button_addunit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_addunit.BackgroundImage")));
            this.button_addunit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_addunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addunit.ForeColor = System.Drawing.Color.Brown;
            this.button_addunit.Location = new System.Drawing.Point(408, 282);
            this.button_addunit.Name = "button_addunit";
            this.button_addunit.Size = new System.Drawing.Size(101, 28);
            this.button_addunit.TabIndex = 2;
            this.button_addunit.Text = "Add ";
            this.button_addunit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_addunit.UseCompatibleTextRendering = true;
            this.button_addunit.UseVisualStyleBackColor = false;
            this.button_addunit.Click += new System.EventHandler(this.button_addunit_Click);
            // 
            // button_deletunit
            // 
            this.button_deletunit.BackColor = System.Drawing.Color.Transparent;
            this.button_deletunit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_deletunit.BackgroundImage")));
            this.button_deletunit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_deletunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deletunit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_deletunit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_deletunit.Location = new System.Drawing.Point(534, 282);
            this.button_deletunit.Name = "button_deletunit";
            this.button_deletunit.Size = new System.Drawing.Size(102, 28);
            this.button_deletunit.TabIndex = 4;
            this.button_deletunit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_deletunit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_deletunit.UseVisualStyleBackColor = false;
            this.button_deletunit.Click += new System.EventHandler(this.button_deletunit_Click);
            // 
            // dataGridViewunits
            // 
            this.dataGridViewunits.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewunits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewunits.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewunits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewunits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewunits.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewunits.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewunits.Location = new System.Drawing.Point(218, 1);
            this.dataGridViewunits.MultiSelect = false;
            this.dataGridViewunits.Name = "dataGridViewunits";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewunits.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewunits.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewunits.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dataGridViewunits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewunits.Size = new System.Drawing.Size(418, 275);
            this.dataGridViewunits.TabIndex = 17;
            this.dataGridViewunits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewunits_CellClick);
            // 
            // units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewunits);
            this.Controls.Add(this.button_deletunit);
            this.Controls.Add(this.button_addunit);
            this.Controls.Add(this.textBox_addunit);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "units";
            this.Text = "units";
            this.Load += new System.EventHandler(this.units_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewunits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_addunit;
        private System.Windows.Forms.Button button_addunit;
        private System.Windows.Forms.Button button_deletunit;
        private System.Windows.Forms.DataGridView dataGridViewunits;
    }
}