
namespace PresentationLayerDesktop
{
    partial class AdminForm
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
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_CurrentNumberDoctors = new System.Windows.Forms.Label();
            this.textBox_CurrentNumberDoctors = new System.Windows.Forms.TextBox();
            this.label_CurrentNumberPatients = new System.Windows.Forms.Label();
            this.textBox_CurrentNumberPatients = new System.Windows.Forms.TextBox();
            this.button_DoctorManagement = new System.Windows.Forms.Button();
            this.button_LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(37, 103);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(80, 17);
            this.label_FirstName.TabIndex = 0;
            this.label_FirstName.Text = "First Name:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(37, 141);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(80, 17);
            this.label_LastName.TabIndex = 1;
            this.label_LastName.Text = "Last Name:";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(37, 181);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(51, 17);
            this.label_Email.TabIndex = 2;
            this.label_Email.Text = "E-mail:";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(132, 98);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.ReadOnly = true;
            this.textBox_FirstName.Size = new System.Drawing.Size(100, 22);
            this.textBox_FirstName.TabIndex = 3;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(132, 136);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.ReadOnly = true;
            this.textBox_LastName.Size = new System.Drawing.Size(100, 22);
            this.textBox_LastName.TabIndex = 4;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(132, 176);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.ReadOnly = true;
            this.textBox_Email.Size = new System.Drawing.Size(208, 22);
            this.textBox_Email.TabIndex = 5;
            // 
            // label_CurrentNumberDoctors
            // 
            this.label_CurrentNumberDoctors.AutoSize = true;
            this.label_CurrentNumberDoctors.Location = new System.Drawing.Point(37, 308);
            this.label_CurrentNumberDoctors.Name = "label_CurrentNumberDoctors";
            this.label_CurrentNumberDoctors.Size = new System.Drawing.Size(243, 17);
            this.label_CurrentNumberDoctors.TabIndex = 6;
            this.label_CurrentNumberDoctors.Text = "Current number of doctors employed:";
            // 
            // textBox_CurrentNumberDoctors
            // 
            this.textBox_CurrentNumberDoctors.Location = new System.Drawing.Point(300, 303);
            this.textBox_CurrentNumberDoctors.Name = "textBox_CurrentNumberDoctors";
            this.textBox_CurrentNumberDoctors.ReadOnly = true;
            this.textBox_CurrentNumberDoctors.Size = new System.Drawing.Size(100, 22);
            this.textBox_CurrentNumberDoctors.TabIndex = 7;
            // 
            // label_CurrentNumberPatients
            // 
            this.label_CurrentNumberPatients.AutoSize = true;
            this.label_CurrentNumberPatients.Location = new System.Drawing.Point(37, 266);
            this.label_CurrentNumberPatients.Name = "label_CurrentNumberPatients";
            this.label_CurrentNumberPatients.Size = new System.Drawing.Size(181, 17);
            this.label_CurrentNumberPatients.TabIndex = 8;
            this.label_CurrentNumberPatients.Text = "Current number of patients:";
            // 
            // textBox_CurrentNumberPatients
            // 
            this.textBox_CurrentNumberPatients.Location = new System.Drawing.Point(300, 261);
            this.textBox_CurrentNumberPatients.Name = "textBox_CurrentNumberPatients";
            this.textBox_CurrentNumberPatients.ReadOnly = true;
            this.textBox_CurrentNumberPatients.Size = new System.Drawing.Size(100, 22);
            this.textBox_CurrentNumberPatients.TabIndex = 9;
            // 
            // button_DoctorManagement
            // 
            this.button_DoctorManagement.Location = new System.Drawing.Point(40, 400);
            this.button_DoctorManagement.Name = "button_DoctorManagement";
            this.button_DoctorManagement.Size = new System.Drawing.Size(178, 60);
            this.button_DoctorManagement.TabIndex = 10;
            this.button_DoctorManagement.Text = "Doctor Management";
            this.button_DoctorManagement.UseVisualStyleBackColor = true;
            this.button_DoctorManagement.Click += new System.EventHandler(this.button_DoctorManagement_Click);
            // 
            // button_LogOut
            // 
            this.button_LogOut.Location = new System.Drawing.Point(379, 424);
            this.button_LogOut.Name = "button_LogOut";
            this.button_LogOut.Size = new System.Drawing.Size(82, 36);
            this.button_LogOut.TabIndex = 11;
            this.button_LogOut.Text = "Log Out";
            this.button_LogOut.UseVisualStyleBackColor = true;
            this.button_LogOut.Click += new System.EventHandler(this.button_LogOut_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 488);
            this.Controls.Add(this.button_LogOut);
            this.Controls.Add(this.button_DoctorManagement);
            this.Controls.Add(this.textBox_CurrentNumberPatients);
            this.Controls.Add(this.label_CurrentNumberPatients);
            this.Controls.Add(this.textBox_CurrentNumberDoctors);
            this.Controls.Add(this.label_CurrentNumberDoctors);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Name = "AdminForm";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_CurrentNumberDoctors;
        private System.Windows.Forms.TextBox textBox_CurrentNumberDoctors;
        private System.Windows.Forms.Label label_CurrentNumberPatients;
        private System.Windows.Forms.TextBox textBox_CurrentNumberPatients;
        private System.Windows.Forms.Button button_DoctorManagement;
        private System.Windows.Forms.Button button_LogOut;
    }
}