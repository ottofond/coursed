namespace Diary.Forms
{
    partial class CreatePlan
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
            text = new TextBox();
            createButton = new Button();
            backButton = new Button();
            label1 = new Label();
            label2 = new Label();
            Periodicity = new ComboBox();
            PeriodicityBox = new GroupBox();
            Periodicity_Check = new Label();
            TypeOfNoteBox = new GroupBox();
            TypeOfNote = new ComboBox();
            TypeOfNote_Check = new Label();
            NotificateBox = new GroupBox();
            Notificate = new ComboBox();
            Notificate_Check = new Label();
            startTime = new MaskedTextBox();
            endTime = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            PeriodicityBox.SuspendLayout();
            TypeOfNoteBox.SuspendLayout();
            NotificateBox.SuspendLayout();
            SuspendLayout();
            // 
            // text
            // 
            text.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            text.Location = new Point(12, 17);
            text.Multiline = true;
            text.Name = "text";
            text.Size = new Size(488, 469);
            text.TabIndex = 0;
            // 
            // createButton
            // 
            createButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            createButton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createButton.Location = new Point(511, 415);
            createButton.Name = "createButton";
            createButton.Size = new Size(105, 31);
            createButton.TabIndex = 2;
            createButton.Text = "Створити";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backButton.DialogResult = DialogResult.Cancel;
            backButton.Location = new Point(511, 455);
            backButton.Name = "backButton";
            backButton.Size = new Size(105, 31);
            backButton.TabIndex = 3;
            backButton.Text = "Скасувати";
            backButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(521, 43);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 5;
            label1.Text = "Час потачку";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(516, 105);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 6;
            label2.Text = "Час закінчення";
            // 
            // Periodicity
            // 
            Periodicity.BackColor = SystemColors.Window;
            Periodicity.DropDownStyle = ComboBoxStyle.DropDownList;
            Periodicity.FormattingEnabled = true;
            Periodicity.Items.AddRange(new object[] { "один раз", "щодня", "щотижня", "щомісяця", "щороку" });
            Periodicity.Location = new Point(6, 20);
            Periodicity.Name = "Periodicity";
            Periodicity.Size = new Size(94, 23);
            Periodicity.TabIndex = 10;
            // 
            // PeriodicityBox
            // 
            PeriodicityBox.AccessibleName = "";
            PeriodicityBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PeriodicityBox.Controls.Add(Periodicity);
            PeriodicityBox.Controls.Add(Periodicity_Check);
            PeriodicityBox.Location = new Point(511, 180);
            PeriodicityBox.Name = "PeriodicityBox";
            PeriodicityBox.Size = new Size(105, 58);
            PeriodicityBox.TabIndex = 11;
            PeriodicityBox.TabStop = false;
            PeriodicityBox.Text = "Періодичність";
            // 
            // Periodicity_Check
            // 
            Periodicity_Check.AutoSize = true;
            Periodicity_Check.ForeColor = SystemColors.Control;
            Periodicity_Check.Location = new Point(10, 35);
            Periodicity_Check.Name = "Periodicity_Check";
            Periodicity_Check.Size = new Size(87, 15);
            Periodicity_Check.TabIndex = 11;
            Periodicity_Check.Text = "________________";
            // 
            // TypeOfNoteBox
            // 
            TypeOfNoteBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TypeOfNoteBox.Controls.Add(TypeOfNote);
            TypeOfNoteBox.Controls.Add(TypeOfNote_Check);
            TypeOfNoteBox.Location = new Point(511, 244);
            TypeOfNoteBox.Name = "TypeOfNoteBox";
            TypeOfNoteBox.Size = new Size(105, 58);
            TypeOfNoteBox.TabIndex = 12;
            TypeOfNoteBox.TabStop = false;
            TypeOfNoteBox.Text = "Тип події";
            // 
            // TypeOfNote
            // 
            TypeOfNote.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeOfNote.FormattingEnabled = true;
            TypeOfNote.Items.AddRange(new object[] { "свято", "робота", "розваги", "дозвілля" });
            TypeOfNote.Location = new Point(6, 20);
            TypeOfNote.Name = "TypeOfNote";
            TypeOfNote.Size = new Size(94, 23);
            TypeOfNote.TabIndex = 10;
            // 
            // TypeOfNote_Check
            // 
            TypeOfNote_Check.AutoSize = true;
            TypeOfNote_Check.ForeColor = SystemColors.Control;
            TypeOfNote_Check.Location = new Point(10, 35);
            TypeOfNote_Check.Name = "TypeOfNote_Check";
            TypeOfNote_Check.Size = new Size(87, 15);
            TypeOfNote_Check.TabIndex = 12;
            TypeOfNote_Check.Text = "________________";
            // 
            // NotificateBox
            // 
            NotificateBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NotificateBox.Controls.Add(Notificate);
            NotificateBox.Controls.Add(Notificate_Check);
            NotificateBox.Location = new Point(511, 308);
            NotificateBox.Name = "NotificateBox";
            NotificateBox.Size = new Size(105, 58);
            NotificateBox.TabIndex = 13;
            NotificateBox.TabStop = false;
            NotificateBox.Text = "Нагадати за";
            // 
            // Notificate
            // 
            Notificate.DropDownStyle = ComboBoxStyle.DropDownList;
            Notificate.FormattingEnabled = true;
            Notificate.Items.AddRange(new object[] { "не нагадувати", "10 хвилин", "1 годину", "1 день", "1 тиждень" });
            Notificate.Location = new Point(6, 22);
            Notificate.Name = "Notificate";
            Notificate.Size = new Size(94, 23);
            Notificate.TabIndex = 10;
            // 
            // Notificate_Check
            // 
            Notificate_Check.AutoSize = true;
            Notificate_Check.ForeColor = SystemColors.Control;
            Notificate_Check.Location = new Point(10, 35);
            Notificate_Check.Name = "Notificate_Check";
            Notificate_Check.Size = new Size(87, 15);
            Notificate_Check.TabIndex = 12;
            Notificate_Check.Text = "________________";
            // 
            // startTime
            // 
            startTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            startTime.BorderStyle = BorderStyle.None;
            startTime.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startTime.Location = new Point(521, 61);
            startTime.Mask = "00:00";
            startTime.Name = "startTime";
            startTime.Size = new Size(79, 32);
            startTime.TabIndex = 1;
            startTime.ValidatingType = typeof(DateTime);
            // 
            // endTime
            // 
            endTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            endTime.BorderStyle = BorderStyle.None;
            endTime.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            endTime.Location = new Point(521, 123);
            endTime.Mask = "00:00";
            endTime.Name = "endTime";
            endTime.Size = new Size(79, 32);
            endTime.TabIndex = 4;
            endTime.ValidatingType = typeof(DateTime);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(501, 17);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(115, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // CreatePlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 498);
            Controls.Add(dateTimePicker1);
            Controls.Add(NotificateBox);
            Controls.Add(TypeOfNoteBox);
            Controls.Add(PeriodicityBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(endTime);
            Controls.Add(backButton);
            Controls.Add(createButton);
            Controls.Add(startTime);
            Controls.Add(text);
            MinimumSize = new Size(421, 499);
            Name = "CreatePlan";
            Text = "CreatePlan";
            PeriodicityBox.ResumeLayout(false);
            PeriodicityBox.PerformLayout();
            TypeOfNoteBox.ResumeLayout(false);
            TypeOfNoteBox.PerformLayout();
            NotificateBox.ResumeLayout(false);
            NotificateBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text;
        private Button createButton;
        private Button backButton;
        private Label label1;
        private Label label2;
        private ComboBox Periodicity;
        private GroupBox PeriodicityBox;
        private GroupBox TypeOfNoteBox;
        private ComboBox TypeOfNote;
        private GroupBox NotificateBox;
        private ComboBox Notificate;
        private MaskedTextBox startTime;
        private MaskedTextBox endTime;
        private Label Periodicity_Check;
        private Label TypeOfNote_Check;
        private Label Notificate_Check;
        private DateTimePicker dateTimePicker1;
    }
}