namespace inventorymanagementsystem
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_loginform = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_login);
            this.panel1.Controls.Add(this.textBox_password);
            this.panel1.Controls.Add(this.textBox_username);
            this.panel1.Controls.Add(this.label_password);
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Location = new System.Drawing.Point(306, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 178);
            this.panel1.TabIndex = 1;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_login.BackgroundImage")));
            this.button_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(172, 126);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(106, 31);
            this.button_login.TabIndex = 4;
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(150, 66);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(163, 23);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(150, 15);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(163, 23);
            this.textBox_username.TabIndex = 2;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_password.Location = new System.Drawing.Point(30, 69);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(77, 17);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Password";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_username.Location = new System.Drawing.Point(30, 22);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(88, 17);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "User Name";
            // 
            // label_loginform
            // 
            this.label_loginform.AutoSize = true;
            this.label_loginform.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loginform.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_loginform.Location = new System.Drawing.Point(450, 102);
            this.label_loginform.Name = "label_loginform";
            this.label_loginform.Size = new System.Drawing.Size(160, 31);
            this.label_loginform.TabIndex = 2;
            this.label_loginform.Text = "Login Form";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(454, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_loginform);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_loginform;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

