
namespace PresentationLayerDesktop
{
    partial class ReportViewForm
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
            this.button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PatientFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PatientPersonalNumber = new System.Windows.Forms.TextBox();
            this.listBox_ReportList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(389, 413);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(107, 42);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;

            this.label1.Location = new System.Drawing.Point(21, 103);

            this.label1.Location = new System.Drawing.Point(21, 53);

            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patient Name:";
            // 
            // textBox_PatientFullName
            // 

            this.textBox_PatientFullName.Location = new System.Drawing.Point(124, 98);

            this.textBox_PatientFullName.Location = new System.Drawing.Point(124, 48);

            this.textBox_PatientFullName.Name = "textBox_PatientFullName";
            this.textBox_PatientFullName.ReadOnly = true;
            this.textBox_PatientFullName.Size = new System.Drawing.Size(211, 22);
            this.textBox_PatientFullName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;

            this.label2.Location = new System.Drawing.Point(21, 132);

            this.label2.Location = new System.Drawing.Point(21, 89);

            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient Personal Number:";
            // 
            // textBox_PatientPersonalNumber
            // 

            this.textBox_PatientPersonalNumber.Location = new System.Drawing.Point(197, 127);

            this.textBox_PatientPersonalNumber.Location = new System.Drawing.Point(197, 86);

            this.textBox_PatientPersonalNumber.Name = "textBox_PatientPersonalNumber";
            this.textBox_PatientPersonalNumber.ReadOnly = true;
            this.textBox_PatientPersonalNumber.Size = new System.Drawing.Size(156, 22);
            this.textBox_PatientPersonalNumber.TabIndex = 5;
            // 
            // listBox_ReportList
            // 
            this.listBox_ReportList.FormattingEnabled = true;
            this.listBox_ReportList.ItemHeight = 16;
            this.listBox_ReportList.Location = new System.Drawing.Point(24, 179);
            this.listBox_ReportList.Name = "listBox_ReportList";
            this.listBox_ReportList.Size = new System.Drawing.Size(472, 196);
            this.listBox_ReportList.TabIndex = 6;
            // 
            // ReportViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 467);
            this.Controls.Add(this.listBox_ReportList);
            this.Controls.Add(this.textBox_PatientPersonalNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_PatientFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Close);
            this.Name = "ReportViewForm";
            this.Text = "Report View";
            this.Load += new System.EventHandler(this.ReportViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PatientFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_PatientPersonalNumber;
        private System.Windows.Forms.ListBox listBox_ReportList;
    }
}