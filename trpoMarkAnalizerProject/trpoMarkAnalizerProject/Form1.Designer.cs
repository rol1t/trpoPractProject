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
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updateJournalButton = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.dateJournal = new System.Windows.Forms.DateTimePicker();
            this.journalGrid = new System.Windows.Forms.DataGridView();
            this.idStudentClmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameClmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBox = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(197, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 16);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 450);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.BackgroundImage = global::trpoMarkAnalizerProject.Properties.Resources.kisspng_computer_icons_higher_education_university_of_nort_5b3c15258cd705_8622685015306642295769;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(243, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(71, 85);
            this.panel3.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(215, 20);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(598, 415);
            this.tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.subjectBox);
            this.tabPage1.Controls.Add(this.updateJournalButton);
            this.tabPage1.Controls.Add(this.groupBox);
            this.tabPage1.Controls.Add(this.dateJournal);
            this.tabPage1.Controls.Add(this.journalGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(590, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // updateJournalButton
            // 
            this.updateJournalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateJournalButton.Location = new System.Drawing.Point(481, 3);
            this.updateJournalButton.Name = "updateJournalButton";
            this.updateJournalButton.Size = new System.Drawing.Size(103, 47);
            this.updateJournalButton.TabIndex = 8;
            this.updateJournalButton.Text = "Зафиксировать Изменения";
            this.updateJournalButton.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Location = new System.Drawing.Point(100, 35);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(76, 21);
            this.groupBox.TabIndex = 7;
            // 
            // dateJournal
            // 
            this.dateJournal.Location = new System.Drawing.Point(100, 6);
            this.dateJournal.Name = "dateJournal";
            this.dateJournal.Size = new System.Drawing.Size(203, 20);
            this.dateJournal.TabIndex = 6;
            // 
            // journalGrid
            // 
            this.journalGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.journalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.journalGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStudentClmn,
            this.fullnameClmn});
            this.journalGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.journalGrid.Location = new System.Drawing.Point(3, 62);
            this.journalGrid.Name = "journalGrid";
            this.journalGrid.Size = new System.Drawing.Size(584, 324);
            this.journalGrid.TabIndex = 5;
            // 
            // idStudentClmn
            // 
            this.idStudentClmn.HeaderText = "id";
            this.idStudentClmn.Name = "idStudentClmn";
            this.idStudentClmn.Visible = false;
            // 
            // fullnameClmn
            // 
            this.fullnameClmn.HeaderText = "ФИО";
            this.fullnameClmn.Name = "fullnameClmn";
            // 
            // subjectBox
            // 
            this.subjectBox.FormattingEnabled = true;
            this.subjectBox.Location = new System.Drawing.Point(182, 36);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(121, 21);
            this.subjectBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 447);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.journalGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button updateJournalButton;
        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.DateTimePicker dateJournal;
        private System.Windows.Forms.DataGridView journalGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentClmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameClmn;
        private System.Windows.Forms.ComboBox subjectBox;
    }
}

