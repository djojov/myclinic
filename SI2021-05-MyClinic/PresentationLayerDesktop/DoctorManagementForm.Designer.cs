
namespace PresentationLayerDesktop
{
    partial class DoctorManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorManagementForm));
            this.dataGridView_DoctorList = new System.Windows.Forms.DataGridView();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_PersonalNumber = new System.Windows.Forms.Label();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.label_DateEmployed = new System.Windows.Forms.Label();
            this.label_Specialization = new System.Windows.Forms.Label();
            this.label_Department = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_PersonalNumber = new System.Windows.Forms.TextBox();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_DateEmployed = new System.Windows.Forms.TextBox();
            this.textBox_Specialization = new System.Windows.Forms.TextBox();
            this.textBox_Department = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_InsertNewDoctor = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DoctorList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_DoctorList
            // 
            this.dataGridView_DoctorList.AllowUserToAddRows = false;
            this.dataGridView_DoctorList.AllowUserToDeleteRows = false;
            this.dataGridView_DoctorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DoctorList.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_DoctorList.Name = "dataGridView_DoctorList";
            this.dataGridView_DoctorList.ReadOnly = true;
            this.dataGridView_DoctorList.RowHeadersWidth = 51;
            this.dataGridView_DoctorList.RowTemplate.Height = 24;
            this.dataGridView_DoctorList.Size = new System.Drawing.Size(1525, 441);
            this.dataGridView_DoctorList.TabIndex = 0;
            this.dataGridView_DoctorList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DoctorList_CellClick);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(28, 495);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(23, 18);
            this.label_Id.TabIndex = 1;
            this.label_Id.Text = "Id:";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.Location = new System.Drawing.Point(28, 526);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(54, 18);
            this.label_Status.TabIndex = 2;
            this.label_Status.Text = "Status:";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FirstName.Location = new System.Drawing.Point(28, 557);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(85, 18);
            this.label_FirstName.TabIndex = 3;
            this.label_FirstName.Text = "First Name:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LastName.Location = new System.Drawing.Point(28, 584);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(84, 18);
            this.label_LastName.TabIndex = 4;
            this.label_LastName.Text = "Last Name:";
            // 
            // label_PersonalNumber
            // 
            this.label_PersonalNumber.AutoSize = true;
            this.label_PersonalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PersonalNumber.Location = new System.Drawing.Point(28, 616);
            this.label_PersonalNumber.Name = "label_PersonalNumber";
            this.label_PersonalNumber.Size = new System.Drawing.Size(128, 18);
            this.label_PersonalNumber.TabIndex = 5;
            this.label_PersonalNumber.Text = "Personal Number:";
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PhoneNumber.Location = new System.Drawing.Point(671, 485);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(112, 18);
            this.label_PhoneNumber.TabIndex = 6;
            this.label_PhoneNumber.Text = "Phone Number:";
            // 
            // label_DateEmployed
            // 
            this.label_DateEmployed.AutoSize = true;
            this.label_DateEmployed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateEmployed.Location = new System.Drawing.Point(670, 519);
            this.label_DateEmployed.Name = "label_DateEmployed";
            this.label_DateEmployed.Size = new System.Drawing.Size(113, 18);
            this.label_DateEmployed.TabIndex = 7;
            this.label_DateEmployed.Text = "Date Employed:";
            // 
            // label_Specialization
            // 
            this.label_Specialization.AutoSize = true;
            this.label_Specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Specialization.Location = new System.Drawing.Point(670, 549);
            this.label_Specialization.Name = "label_Specialization";
            this.label_Specialization.Size = new System.Drawing.Size(103, 18);
            this.label_Specialization.TabIndex = 8;
            this.label_Specialization.Text = "Specialization:";
            // 
            // label_Department
            // 
            this.label_Department.AutoSize = true;
            this.label_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Department.Location = new System.Drawing.Point(671, 577);
            this.label_Department.Name = "label_Department";
            this.label_Department.Size = new System.Drawing.Size(89, 18);
            this.label_Department.TabIndex = 9;
            this.label_Department.Text = "Department:";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(670, 605);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(54, 18);
            this.label_Email.TabIndex = 10;
            this.label_Email.Text = "E-mail:";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(210, 492);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(205, 22);
            this.textBox_Id.TabIndex = 11;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(210, 552);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(205, 22);
            this.textBox_FirstName.TabIndex = 13;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(210, 580);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(205, 22);
            this.textBox_LastName.TabIndex = 14;
            // 
            // textBox_PersonalNumber
            // 
            this.textBox_PersonalNumber.Location = new System.Drawing.Point(210, 611);
            this.textBox_PersonalNumber.Name = "textBox_PersonalNumber";
            this.textBox_PersonalNumber.ReadOnly = true;
            this.textBox_PersonalNumber.Size = new System.Drawing.Size(205, 22);
            this.textBox_PersonalNumber.TabIndex = 15;
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(807, 481);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(205, 22);
            this.textBox_PhoneNumber.TabIndex = 16;
            // 
            // textBox_DateEmployed
            // 
            this.textBox_DateEmployed.Location = new System.Drawing.Point(807, 514);
            this.textBox_DateEmployed.Name = "textBox_DateEmployed";
            this.textBox_DateEmployed.ReadOnly = true;
            this.textBox_DateEmployed.Size = new System.Drawing.Size(205, 22);
            this.textBox_DateEmployed.TabIndex = 17;
            // 
            // textBox_Specialization
            // 
            this.textBox_Specialization.Location = new System.Drawing.Point(807, 546);
            this.textBox_Specialization.Name = "textBox_Specialization";
            this.textBox_Specialization.Size = new System.Drawing.Size(205, 22);
            this.textBox_Specialization.TabIndex = 18;
            // 
            // textBox_Department
            // 
            this.textBox_Department.Location = new System.Drawing.Point(807, 574);
            this.textBox_Department.Name = "textBox_Department";
            this.textBox_Department.Size = new System.Drawing.Size(205, 22);
            this.textBox_Department.TabIndex = 19;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(807, 602);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(205, 22);
            this.textBox_Email.TabIndex = 20;
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBox_Status.Location = new System.Drawing.Point(210, 519);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(205, 24);
            this.comboBox_Status.TabIndex = 21;
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ForeColor = System.Drawing.Color.White;
            this.button_Update.Location = new System.Drawing.Point(1364, 477);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(137, 46);
            this.button_Update.TabIndex = 22;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_InsertNewDoctor
            // 
            this.button_InsertNewDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button_InsertNewDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InsertNewDoctor.ForeColor = System.Drawing.Color.White;
            this.button_InsertNewDoctor.Location = new System.Drawing.Point(1364, 529);
            this.button_InsertNewDoctor.Name = "button_InsertNewDoctor";
            this.button_InsertNewDoctor.Size = new System.Drawing.Size(137, 54);
            this.button_InsertNewDoctor.TabIndex = 23;
            this.button_InsertNewDoctor.Text = "Insert New Doctor";
            this.button_InsertNewDoctor.UseVisualStyleBackColor = false;
            this.button_InsertNewDoctor.Click += new System.EventHandler(this.button_InsertNewDoctor_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.ForeColor = System.Drawing.Color.White;
            this.button_Close.Location = new System.Drawing.Point(1364, 587);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(137, 46);
            this.button_Close.TabIndex = 24;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // DoctorManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 644);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_InsertNewDoctor);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Department);
            this.Controls.Add(this.textBox_Specialization);
            this.Controls.Add(this.textBox_DateEmployed);
            this.Controls.Add(this.textBox_PhoneNumber);
            this.Controls.Add(this.textBox_PersonalNumber);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Department);
            this.Controls.Add(this.label_Specialization);
            this.Controls.Add(this.label_DateEmployed);
            this.Controls.Add(this.label_PhoneNumber);
            this.Controls.Add(this.label_PersonalNumber);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.dataGridView_DoctorList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Management";
            this.Load += new System.EventHandler(this.DoctorManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DoctorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_DoctorList;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_PersonalNumber;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.Label label_DateEmployed;
        private System.Windows.Forms.Label label_Specialization;
        private System.Windows.Forms.Label label_Department;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_PersonalNumber;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_DateEmployed;
        private System.Windows.Forms.TextBox textBox_Specialization;
        private System.Windows.Forms.TextBox textBox_Department;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_InsertNewDoctor;
        private System.Windows.Forms.Button button_Close;
    }
}