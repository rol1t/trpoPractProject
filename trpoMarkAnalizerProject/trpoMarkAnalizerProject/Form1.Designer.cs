namespace trpoMarkAnalizerProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.journalPanel = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.subjectBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.sendUpdateBtn = new System.Windows.Forms.Button();
            this.journalGrid = new System.Windows.Forms.DataGridView();
            this.journalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(296, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 25);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 692);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // journalPanel
            // 
            this.journalPanel.Controls.Add(this.groupBox);
            this.journalPanel.Controls.Add(this.subjectBox);
            this.journalPanel.Controls.Add(this.dateTimePicker1);
            this.journalPanel.Controls.Add(this.sendUpdateBtn);
            this.journalPanel.Controls.Add(this.journalGrid);
            this.journalPanel.Location = new System.Drawing.Point(324, 32);
            this.journalPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.journalPanel.Name = "journalPanel";
            this.journalPanel.Size = new System.Drawing.Size(896, 637);
            this.journalPanel.TabIndex = 2;
            this.journalPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.journalPanel_Paint);
            // 
            // groupBox
            // 
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Location = new System.Drawing.Point(196, 146);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(100, 28);
            this.groupBox.TabIndex = 4;
            // 
            // subjectBox
            // 
            this.subjectBox.FormattingEnabled = true;
            this.subjectBox.Location = new System.Drawing.Point(6, 146);
            this.subjectBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(180, 28);
            this.subjectBox.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 106);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // sendUpdateBtn
            // 
            this.sendUpdateBtn.Location = new System.Drawing.Point(771, 94);
            this.sendUpdateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendUpdateBtn.Name = "sendUpdateBtn";
            this.sendUpdateBtn.Size = new System.Drawing.Size(124, 85);
            this.sendUpdateBtn.TabIndex = 1;
            this.sendUpdateBtn.Text = "button1";
            this.sendUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // journalGrid
            // 
            this.journalGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.journalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.journalGrid.Location = new System.Drawing.Point(6, 188);
            this.journalGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.journalGrid.Name = "journalGrid";
            this.journalGrid.Size = new System.Drawing.Size(885, 445);
            this.journalGrid.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 688);
            this.Controls.Add(this.journalPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.journalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.journalGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel journalPanel;
        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.ComboBox subjectBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button sendUpdateBtn;
        private System.Windows.Forms.DataGridView journalGrid;
    }
}

