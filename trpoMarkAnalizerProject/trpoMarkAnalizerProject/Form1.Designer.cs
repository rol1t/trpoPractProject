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
            this.panel2 = new System.Windows.Forms.Panel();
            this.journalPage = new System.Windows.Forms.Button();
            this.studentPage = new System.Windows.Forms.Button();
            this.subjectPage = new System.Windows.Forms.Button();
            this.teacherPage = new System.Windows.Forms.Button();
            this.documentPage = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.journalControl = new System.Windows.Forms.TabPage();
            this.studentControl = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.subjectBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.sendUpdateBtn = new System.Windows.Forms.Button();
            this.journalGrid = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.journalControl.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.documentPage);
            this.panel2.Controls.Add(this.teacherPage);
            this.panel2.Controls.Add(this.subjectPage);
            this.panel2.Controls.Add(this.studentPage);
            this.panel2.Controls.Add(this.journalPage);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 450);
            this.panel2.TabIndex = 1;
            // 
            // journalPage
            // 
            this.journalPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.journalPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.journalPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.journalPage.Location = new System.Drawing.Point(3, 78);
            this.journalPage.Name = "journalPage";
            this.journalPage.Size = new System.Drawing.Size(205, 46);
            this.journalPage.TabIndex = 0;
            this.journalPage.Text = "Журнал";
            this.journalPage.UseVisualStyleBackColor = true;
            this.journalPage.Click += new System.EventHandler(this.journalPage_Click);
            // 
            // studentPage
            // 
            this.studentPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentPage.Location = new System.Drawing.Point(3, 130);
            this.studentPage.Name = "studentPage";
            this.studentPage.Size = new System.Drawing.Size(205, 46);
            this.studentPage.TabIndex = 1;
            this.studentPage.Text = "Студенты";
            this.studentPage.UseVisualStyleBackColor = true;
            this.studentPage.Click += new System.EventHandler(this.studentPage_Click);
            // 
            // subjectPage
            // 
            this.subjectPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subjectPage.Location = new System.Drawing.Point(3, 182);
            this.subjectPage.Name = "subjectPage";
            this.subjectPage.Size = new System.Drawing.Size(205, 46);
            this.subjectPage.TabIndex = 3;
            this.subjectPage.Text = "Предметы";
            this.subjectPage.UseVisualStyleBackColor = true;
            // 
            // teacherPage
            // 
            this.teacherPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teacherPage.Location = new System.Drawing.Point(3, 234);
            this.teacherPage.Name = "teacherPage";
            this.teacherPage.Size = new System.Drawing.Size(205, 46);
            this.teacherPage.TabIndex = 4;
            this.teacherPage.Text = "Учителя";
            this.teacherPage.UseVisualStyleBackColor = true;
            // 
            // documentPage
            // 
            this.documentPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.documentPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.documentPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.documentPage.Location = new System.Drawing.Point(3, 389);
            this.documentPage.Name = "documentPage";
            this.documentPage.Size = new System.Drawing.Size(205, 46);
            this.documentPage.TabIndex = 5;
            this.documentPage.Text = "Ведомость";
            this.documentPage.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.journalControl);
            this.tabControl.Controls.Add(this.studentControl);
            this.tabControl.Location = new System.Drawing.Point(216, -21);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(616, 488);
            this.tabControl.TabIndex = 2;
            // 
            // journalControl
            // 
            this.journalControl.Controls.Add(this.tabControl1);
            this.journalControl.Location = new System.Drawing.Point(4, 22);
            this.journalControl.Name = "journalControl";
            this.journalControl.Padding = new System.Windows.Forms.Padding(3);
            this.journalControl.Size = new System.Drawing.Size(608, 462);
            this.journalControl.TabIndex = 0;
            this.journalControl.Text = "Журнал";
            this.journalControl.UseVisualStyleBackColor = true;
            // 
            // studentControl
            // 
            this.studentControl.Location = new System.Drawing.Point(4, 22);
            this.studentControl.Name = "studentControl";
            this.studentControl.Padding = new System.Windows.Forms.Padding(3);
            this.studentControl.Size = new System.Drawing.Size(589, 445);
            this.studentControl.TabIndex = 1;
            this.studentControl.Text = "Студенты";
            this.studentControl.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox);
            this.tabPage1.Controls.Add(this.subjectBox);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.sendUpdateBtn);
            this.tabPage1.Controls.Add(this.journalGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Группа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Предмет";
            // 
            // groupBox
            // 
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Location = new System.Drawing.Point(129, 29);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(68, 21);
            this.groupBox.TabIndex = 17;
            // 
            // subjectBox
            // 
            this.subjectBox.FormattingEnabled = true;
            this.subjectBox.Location = new System.Drawing.Point(2, 29);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(121, 21);
            this.subjectBox.TabIndex = 16;
            this.subjectBox.SelectedIndexChanged += new System.EventHandler(this.subjectBox_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // sendUpdateBtn
            // 
            this.sendUpdateBtn.Location = new System.Drawing.Point(478, 29);
            this.sendUpdateBtn.Name = "sendUpdateBtn";
            this.sendUpdateBtn.Size = new System.Drawing.Size(108, 21);
            this.sendUpdateBtn.TabIndex = 14;
            this.sendUpdateBtn.Text = "Фиксировать";
            this.sendUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // journalGrid
            // 
            this.journalGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.journalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.journalGrid.Location = new System.Drawing.Point(2, 56);
            this.journalGrid.Name = "journalGrid";
            this.journalGrid.Size = new System.Drawing.Size(584, 330);
            this.journalGrid.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 447);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.panel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.journalControl.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button documentPage;
        private System.Windows.Forms.Button teacherPage;
        private System.Windows.Forms.Button subjectPage;
        private System.Windows.Forms.Button studentPage;
        private System.Windows.Forms.Button journalPage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage journalControl;
        private System.Windows.Forms.TabPage studentControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.ComboBox subjectBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button sendUpdateBtn;
        private System.Windows.Forms.DataGridView journalGrid;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

