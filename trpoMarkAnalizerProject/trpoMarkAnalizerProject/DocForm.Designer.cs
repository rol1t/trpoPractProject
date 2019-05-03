namespace trpoMarkAnalizerProject
{
    partial class DocForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.avrgMarkBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.missBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.wordRb = new System.Windows.Forms.RadioButton();
            this.excelRb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(13, 35);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // avrgMarkBtn
            // 
            this.avrgMarkBtn.Location = new System.Drawing.Point(12, 61);
            this.avrgMarkBtn.Name = "avrgMarkBtn";
            this.avrgMarkBtn.Size = new System.Drawing.Size(110, 37);
            this.avrgMarkBtn.TabIndex = 1;
            this.avrgMarkBtn.Text = "Ведомость о среднем балле";
            this.avrgMarkBtn.UseVisualStyleBackColor = true;
            this.avrgMarkBtn.Click += new System.EventHandler(this.AvrgMarkBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата начала периода*";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // missBtn
            // 
            this.missBtn.Location = new System.Drawing.Point(169, 61);
            this.missBtn.Name = "missBtn";
            this.missBtn.Size = new System.Drawing.Size(95, 37);
            this.missBtn.TabIndex = 3;
            this.missBtn.Text = "Ведомость пропусков";
            this.missBtn.UseVisualStyleBackColor = true;
            this.missBtn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(72, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Ведомости составляются от даты начала периода + 30 дней после этого";
            // 
            // groupBox
            // 
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Location = new System.Drawing.Point(169, 35);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(95, 21);
            this.groupBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Группа";
            // 
            // wordRb
            // 
            this.wordRb.AutoSize = true;
            this.wordRb.Location = new System.Drawing.Point(15, 105);
            this.wordRb.Name = "wordRb";
            this.wordRb.Size = new System.Drawing.Size(51, 17);
            this.wordRb.TabIndex = 7;
            this.wordRb.TabStop = true;
            this.wordRb.Text = "Word";
            this.wordRb.UseVisualStyleBackColor = true;
            this.wordRb.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // excelRb
            // 
            this.excelRb.AutoSize = true;
            this.excelRb.Location = new System.Drawing.Point(15, 129);
            this.excelRb.Name = "excelRb";
            this.excelRb.Size = new System.Drawing.Size(51, 17);
            this.excelRb.TabIndex = 8;
            this.excelRb.TabStop = true;
            this.excelRb.Text = "Excel";
            this.excelRb.UseVisualStyleBackColor = true;
            // 
            // DocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 157);
            this.Controls.Add(this.excelRb);
            this.Controls.Add(this.wordRb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.missBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avrgMarkBtn);
            this.Controls.Add(this.dateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DocForm";
            this.Text = "Составление ведомости";
            this.Load += new System.EventHandler(this.DocForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button avrgMarkBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button missBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton wordRb;
        private System.Windows.Forms.RadioButton excelRb;
    }
}