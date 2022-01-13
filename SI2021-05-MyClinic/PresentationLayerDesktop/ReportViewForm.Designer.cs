
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportViewForm));
            this.button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PatientFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PatientPersonalNumber = new System.Windows.Forms.TextBox();
            this.listBox_ReportList = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Reports = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.ForeColor = System.Drawing.Color.White;
            this.button_Close.Location = new System.Drawing.Point(425, 418);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(120, 47);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patient Name:";
            // 
            // textBox_PatientFullName
            // 
            this.textBox_PatientFullName.Location = new System.Drawing.Point(159, 27);
            this.textBox_PatientFullName.Name = "textBox_PatientFullName";
            this.textBox_PatientFullName.ReadOnly = true;
            this.textBox_PatientFullName.Size = new System.Drawing.Size(237, 24);
            this.textBox_PatientFullName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient Personal Number:";
            // 
            // textBox_PatientPersonalNumber
            // 
            this.textBox_PatientPersonalNumber.Location = new System.Drawing.Point(221, 89);
            this.textBox_PatientPersonalNumber.Name = "textBox_PatientPersonalNumber";
            this.textBox_PatientPersonalNumber.ReadOnly = true;
            this.textBox_PatientPersonalNumber.Size = new System.Drawing.Size(175, 24);
            this.textBox_PatientPersonalNumber.TabIndex = 5;
            // 
            // listBox_ReportList
            // 
            this.listBox_ReportList.FormattingEnabled = true;
            this.listBox_ReportList.ItemHeight = 18;
            this.listBox_ReportList.Location = new System.Drawing.Point(26, 168);
            this.listBox_ReportList.Name = "listBox_ReportList";
            this.listBox_ReportList.Size = new System.Drawing.Size(519, 220);
            this.listBox_ReportList.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayerDesktop.Properties.Resources.mcsPNG;
            this.pictureBox1.Location = new System.Drawing.Point(425, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label_Reports
            // 
            this.label_Reports.AutoSize = true;
            this.label_Reports.Location = new System.Drawing.Point(23, 136);
            this.label_Reports.Name = "label_Reports";
            this.label_Reports.Size = new System.Drawing.Size(65, 18);
            this.label_Reports.TabIndex = 8;
            this.label_Reports.Text = "Reports:";
            // 
            // ReportViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 484);
            this.Controls.Add(this.label_Reports);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox_ReportList);
            this.Controls.Add(this.textBox_PatientPersonalNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_PatientFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Close);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report View";
            this.Load += new System.EventHandler(this.ReportViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Reports;
    }
}