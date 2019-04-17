namespace trpoMarkAnalizerProject
{
    partial class JournalControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.journalGrid = new System.Windows.Forms.DataGridView();
            this.dateJournal = new System.Windows.Forms.DateTimePicker();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.subjectBox = new System.Windows.Forms.ComboBox();
            this.updateJournalButton = new System.Windows.Forms.Button();
            this.idStudentClmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameClmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.journalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // journalGrid
            // 
            this.journalGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.journalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.journalGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStudentClmn,
            this.fullnameClmn});
            this.journalGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.journalGrid.Location = new System.Drawing.Point(0, 56);
            this.journalGrid.Name = "journalGrid";
            this.journalGrid.Size = new System.Drawing.Size(595, 372);
            this.journalGrid.TabIndex = 0;
            // 
            // dateJournal
            // 
            this.dateJournal.Location = new System.Drawing.Point(3, 3);
            this.dateJournal.Name = "dateJournal";
            this.dateJournal.Size = new System.Drawing.Size(203, 20);
            this.dateJournal.TabIndex = 1;
            // 
            // groupBox
            // 
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Location = new System.Drawing.Point(3, 29);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(76, 21);
            this.groupBox.TabIndex = 2;
            // 
            // subjectBox
            // 
            this.subjectBox.FormattingEnabled = true;
            this.subjectBox.Location = new System.Drawing.Point(85, 29);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(121, 21);
            this.subjectBox.TabIndex = 3;
            // 
            // updateJournalButton
            // 
            this.updateJournalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateJournalButton.Location = new System.Drawing.Point(489, 3);
            this.updateJournalButton.Name = "updateJournalButton";
            this.updateJournalButton.Size = new System.Drawing.Size(103, 47);
            this.updateJournalButton.TabIndex = 4;
            this.updateJournalButton.Text = "Зафиксировать Изменения";
            this.updateJournalButton.UseVisualStyleBackColor = true;
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
            // JournalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateJournalButton);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dateJournal);
            this.Controls.Add(this.journalGrid);
            this.Name = "JournalControl";
            this.Size = new System.Drawing.Size(595, 428);
            this.Load += new System.EventHandler(this.JournalControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.journalGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView journalGrid;
        private System.Windows.Forms.DateTimePicker dateJournal;
        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.ComboBox subjectBox;
        private System.Windows.Forms.Button updateJournalButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentClmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameClmn;
    }
}
