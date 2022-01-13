
namespace PresentationLayerDesktop
{
    partial class InsertReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertReportForm));
            this.label_PatientName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PatientFullName = new System.Windows.Forms.TextBox();
            this.textBox_PatientPersonalNumber = new System.Windows.Forms.TextBox();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Diagnosis = new System.Windows.Forms.Label();
            this.richTextBox_Diagnosis = new System.Windows.Forms.RichTextBox();
            this.button_InsertNewReport = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.textBox_Date = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_PatientName
            // 
            this.label_PatientName.AutoSize = true;
            this.label_PatientName.Location = new System.Drawing.Point(13, 38);
            this.label_PatientName.Name = "label_PatientName";
            this.label_PatientName.Size = new System.Drawing.Size(98, 18);
            this.label_PatientName.TabIndex = 0;
            this.label_PatientName.Text = "Patient name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Personal Number:";
            // 
            // textBox_PatientFullName
            // 
            this.textBox_PatientFullName.Location = new System.Drawing.Point(127, 32);
            this.textBox_PatientFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_PatientFullName.Name = "textBox_PatientFullName";
            this.textBox_PatientFullName.ReadOnly = true;
            this.textBox_PatientFullName.Size = new System.Drawing.Size(274, 24);
            this.textBox_PatientFullName.TabIndex = 2;
            // 
            // textBox_PatientPersonalNumber
            // 
            this.textBox_PatientPersonalNumber.Location = new System.Drawing.Point(211, 67);
            this.textBox_PatientPersonalNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_PatientPersonalNumber.Name = "textBox_PatientPersonalNumber";
            this.textBox_PatientPersonalNumber.ReadOnly = true;
            this.textBox_PatientPersonalNumber.Size = new System.Drawing.Size(176, 24);
            this.textBox_PatientPersonalNumber.TabIndex = 3;
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(13, 143);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(43, 18);
            this.label_Date.TabIndex = 4;
            this.label_Date.Text = "Date:";
            // 
            // label_Diagnosis
            // 
            this.label_Diagnosis.AutoSize = true;
            this.label_Diagnosis.Location = new System.Drawing.Point(13, 179);
            this.label_Diagnosis.Name = "label_Diagnosis";
            this.label_Diagnosis.Size = new System.Drawing.Size(78, 18);
            this.label_Diagnosis.TabIndex = 5;
            this.label_Diagnosis.Text = "Diagnosis:";
            // 
            // richTextBox_Diagnosis
            // 
            this.richTextBox_Diagnosis.Location = new System.Drawing.Point(13, 202);
            this.richTextBox_Diagnosis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox_Diagnosis.Name = "richTextBox_Diagnosis";
            this.richTextBox_Diagnosis.Size = new System.Drawing.Size(437, 202);
            this.richTextBox_Diagnosis.TabIndex = 6;
            this.richTextBox_Diagnosis.Text = "";
            // 
            // button_InsertNewReport
            // 
            this.button_InsertNewReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button_InsertNewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InsertNewReport.ForeColor = System.Drawing.Color.White;
            this.button_InsertNewReport.Location = new System.Drawing.Point(13, 436);
            this.button_InsertNewReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_InsertNewReport.Name = "button_InsertNewReport";
            this.button_InsertNewReport.Size = new System.Drawing.Size(142, 40);
            this.button_InsertNewReport.TabIndex = 7;
            this.button_InsertNewReport.Text = "Insert";
            this.button_InsertNewReport.UseVisualStyleBackColor = false;
            this.button_InsertNewReport.Click += new System.EventHandler(this.button_InsertNewReport_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.ForeColor = System.Drawing.Color.White;
            this.button_Close.Location = new System.Drawing.Point(317, 436);
            this.button_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(133, 40);
            this.button_Close.TabIndex = 8;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // textBox_Date
            // 
            this.textBox_Date.Location = new System.Drawing.Point(92, 137);
            this.textBox_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Date.Name = "textBox_Date";
            this.textBox_Date.ReadOnly = true;
            this.textBox_Date.Size = new System.Drawing.Size(112, 24);
            this.textBox_Date.TabIndex = 9;
            // 
            // InsertReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 496);
            this.Controls.Add(this.textBox_Date);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_InsertNewReport);
            this.Controls.Add(this.richTextBox_Diagnosis);
            this.Controls.Add(this.label_Diagnosis);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.textBox_PatientPersonalNumber);
            this.Controls.Add(this.textBox_PatientFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_PatientName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InsertReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Report";
            this.Load += new System.EventHandler(this.InsertReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PatientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_PatientFullName;
        private System.Windows.Forms.TextBox textBox_PatientPersonalNumber;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Diagnosis;
        private System.Windows.Forms.RichTextBox richTextBox_Diagnosis;
        private System.Windows.Forms.Button button_InsertNewReport;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.TextBox textBox_Date;
    }
}