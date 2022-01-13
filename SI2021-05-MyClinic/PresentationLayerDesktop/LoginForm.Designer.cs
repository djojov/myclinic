
namespace PresentationLayerDesktop
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_LoginAs = new System.Windows.Forms.Label();
            this.comboBox_LoginAs = new System.Windows.Forms.ComboBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(49, 214);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(69, 20);
            this.label_Email.TabIndex = 0;
            this.label_Email.Text = "E-mail:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(49, 264);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(97, 20);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password:";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(162, 212);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(247, 22);
            this.textBox_Email.TabIndex = 2;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(162, 262);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(247, 22);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // label_LoginAs
            // 
            this.label_LoginAs.AutoSize = true;
            this.label_LoginAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LoginAs.Location = new System.Drawing.Point(49, 172);
            this.label_LoginAs.Name = "label_LoginAs";
            this.label_LoginAs.Size = new System.Drawing.Size(87, 20);
            this.label_LoginAs.TabIndex = 4;
            this.label_LoginAs.Text = "Login as:";
            // 
            // comboBox_LoginAs
            // 
            this.comboBox_LoginAs.BackColor = System.Drawing.Color.White;
            this.comboBox_LoginAs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LoginAs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.comboBox_LoginAs.FormattingEnabled = true;
            this.comboBox_LoginAs.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Patient"});
            this.comboBox_LoginAs.Location = new System.Drawing.Point(162, 168);
            this.comboBox_LoginAs.Name = "comboBox_LoginAs";
            this.comboBox_LoginAs.Size = new System.Drawing.Size(247, 24);
            this.comboBox_LoginAs.TabIndex = 5;
            this.comboBox_LoginAs.SelectedIndexChanged += new System.EventHandler(this.comboBox_LoginAs_SelectedIndexChanged);
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.Location = new System.Drawing.Point(187, 309);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(141, 59);
            this.button_Login.TabIndex = 6;
            this.button_Login.Text = "Log in";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayerDesktop.Properties.Resources.mcsPNG;
            this.pictureBox1.Location = new System.Drawing.Point(187, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.comboBox_LoginAs);
            this.Controls.Add(this.label_LoginAs);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Email);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_LoginAs;
        private System.Windows.Forms.ComboBox comboBox_LoginAs;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

