
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
            this.label_PatientName.Location = new System.Drawing.Point(12, 20);
            this.label_PatientName.Name = "label_PatientName";
            this.label_PatientName.Size = new System.Drawing.Size(95, 17);
            this.label_PatientName.TabIndex = 0;
            this.label_PatientName.Text = "Patient name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Personal Number:";
            // 
            // textBox_PatientFullName
            // 
            this.textBox_PatientFullName.Location = new System.Drawing.Point(143, 15);
            this.textBox_PatientFullName.Name = "textBox_PatientFullName";
            this.textBox_PatientFullName.ReadOnly = true;
            this.textBox_PatientFullName.Size = new System.Drawing.Size(214, 22);
            this.textBox_PatientFullName.TabIndex = 2;
            // 
            // textBox_PatientPersonalNumber
            // 
            this.textBox_PatientPersonalNumber.Location = new System.Drawing.Point(200, 47);
            this.textBox_PatientPersonalNumber.Name = "textBox_PatientPersonalNumber";
            this.textBox_PatientPersonalNumber.ReadOnly = true;
            this.textBox_PatientPersonalNumber.Size = new System.Drawing.Size(157, 22);
            this.textBox_PatientPersonalNumber.TabIndex = 3;
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(12, 141);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(42, 17);
            this.label_Date.TabIndex = 4;
            this.label_Date.Text = "Date:";
            // 
            // label_Diagnosis
            // 
            this.label_Diagnosis.AutoSize = true;
            this.label_Diagnosis.Location = new System.Drawing.Point(12, 176);
            this.label_Diagnosis.Name = "label_Diagnosis";
            this.label_Diagnosis.Size = new System.Drawing.Size(74, 17);
            this.label_Diagnosis.TabIndex = 5;
            this.label_Diagnosis.Text = "Diagnosis:";
            // 
            // richTextBox_Diagnosis
            // 
            this.richTextBox_Diagnosis.Location = new System.Drawing.Point(15, 206);
            this.richTextBox_Diagnosis.Name = "richTextBox_Diagnosis";
            this.richTextBox_Diagnosis.Size = new System.Drawing.Size(342, 167);
            this.richTextBox_Diagnosis.TabIndex = 6;
            this.richTextBox_Diagnosis.Text = "";
            // 
            // button_InsertNewReport
            // 
            this.button_InsertNewReport.Location = new System.Drawing.Point(15, 398);
            this.button_InsertNewReport.Name = "button_InsertNewReport";
            this.button_InsertNewReport.Size = new System.Drawing.Size(126, 36);
            this.button_InsertNewReport.TabIndex = 7;
            this.button_InsertNewReport.Text = "Insert";
            this.button_InsertNewReport.UseVisualStyleBackColor = true;
            this.button_InsertNewReport.Click += new System.EventHandler(this.button_InsertNewReport_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(239, 398);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(118, 36);
            this.button_Close.TabIndex = 8;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // textBox_Date
            // 
            this.textBox_Date.Location = new System.Drawing.Point(82, 136);
            this.textBox_Date.Name = "textBox_Date";
            this.textBox_Date.ReadOnly = true;
            this.textBox_Date.Size = new System.Drawing.Size(100, 22);
            this.textBox_Date.TabIndex = 9;
            // 
            // InsertReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 455);
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
            this.Name = "InsertReportForm";
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