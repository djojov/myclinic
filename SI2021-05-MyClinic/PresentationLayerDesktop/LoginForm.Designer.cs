
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
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_LoginAs = new System.Windows.Forms.Label();
            this.comboBox_LoginAs = new System.Windows.Forms.ComboBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(143, 219);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(47, 17);
            this.label_Email.TabIndex = 0;
            this.label_Email.Text = "E-mail";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(121, 269);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(69, 17);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(229, 214);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(247, 22);
            this.textBox_Email.TabIndex = 2;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(229, 264);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(247, 22);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // label_LoginAs
            // 
            this.label_LoginAs.AutoSize = true;
            this.label_LoginAs.Location = new System.Drawing.Point(124, 161);
            this.label_LoginAs.Name = "label_LoginAs";
            this.label_LoginAs.Size = new System.Drawing.Size(66, 17);
            this.label_LoginAs.TabIndex = 4;
            this.label_LoginAs.Text = "Login as:";
            // 
            // comboBox_LoginAs
            // 
            this.comboBox_LoginAs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LoginAs.FormattingEnabled = true;
            this.comboBox_LoginAs.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Patient"});
            this.comboBox_LoginAs.Location = new System.Drawing.Point(249, 154);
            this.comboBox_LoginAs.Name = "comboBox_LoginAs";
            this.comboBox_LoginAs.Size = new System.Drawing.Size(227, 24);
            this.comboBox_LoginAs.TabIndex = 5;
            this.comboBox_LoginAs.SelectedIndexChanged += new System.EventHandler(this.comboBox_LoginAs_SelectedIndexChanged);
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(296, 346);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(124, 36);
            this.button_Login.TabIndex = 6;
            this.button_Login.Text = "Log in";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.comboBox_LoginAs);
            this.Controls.Add(this.label_LoginAs);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Email);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
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
    }
}

