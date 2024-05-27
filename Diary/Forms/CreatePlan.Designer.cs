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
            button1 = new Button();
            button2 = new Button();
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
            PeriodicityBox.SuspendLayout();
            TypeOfNoteBox.SuspendLayout();
            NotificateBox.SuspendLayout();
            SuspendLayout();
            // 
            // text
            // 
            text.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            text.Location = new Point(12, 12);
            text.Multiline = true;
            text.Name = "text";
            text.Size = new Size(673, 386);
            text.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(489, 403);
            button1.Name = "button1";
            button1.Size = new Size(95, 34);
            button1.TabIndex = 2;
            button1.Text = "create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(590, 403);
            button2.Name = "button2";
            button2.Size = new Size(95, 34);
            button2.TabIndex = 3;
            button2.Text = "cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(702, 17);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 5;
            label1.Text = "Час потачку";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(697, 79);
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
            PeriodicityBox.Location = new Point(691, 148);
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
            TypeOfNoteBox.Location = new Point(691, 212);
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
            NotificateBox.Location = new Point(691, 276);
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
            Notificate.Items.AddRange(new object[] { "10 хвилин", "1 годину", "1 день", "1 тиждень" });
            Notificate.Location = new Point(6, 20);
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
            startTime.Location = new Point(702, 35);
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
            endTime.Location = new Point(702, 97);
            endTime.Mask = "00:00";
            endTime.Name = "endTime";
            endTime.Size = new Size(79, 32);
            endTime.TabIndex = 4;
            endTime.ValidatingType = typeof(DateTime);
            // 
            // CreatePlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 441);
            Controls.Add(NotificateBox);
            Controls.Add(TypeOfNoteBox);
            Controls.Add(PeriodicityBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(endTime);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(startTime);
            Controls.Add(text);
            Name = "CreatePlan";
            Text = "CreatePlan";
            Load += CreatePlan_Load;
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
        private Button button1;
        private Button button2;
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
    }
}