namespace Diary.Forms
{
    partial class RedactingForm
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
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            endTime = new MaskedTextBox();
            startTime = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // text
            // 
            text.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            text.Location = new Point(12, 12);
            text.Multiline = true;
            text.Name = "text";
            text.Size = new Size(181, 343);
            text.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(199, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(147, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(226, 105);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 10;
            label2.Text = "Час закінчення";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(231, 43);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 9;
            label1.Text = "Час потачку";
            // 
            // endTime
            // 
            endTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            endTime.BorderStyle = BorderStyle.None;
            endTime.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            endTime.Location = new Point(231, 123);
            endTime.Mask = "00:00";
            endTime.Name = "endTime";
            endTime.Size = new Size(79, 32);
            endTime.TabIndex = 8;
            endTime.ValidatingType = typeof(DateTime);
            // 
            // startTime
            // 
            startTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            startTime.BorderStyle = BorderStyle.None;
            startTime.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startTime.Location = new Point(231, 61);
            startTime.Mask = "00:00";
            startTime.Name = "startTime";
            startTime.Size = new Size(79, 32);
            startTime.TabIndex = 7;
            startTime.ValidatingType = typeof(DateTime);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(199, 268);
            button1.Name = "button1";
            button1.Size = new Size(147, 25);
            button1.TabIndex = 11;
            button1.Text = "Змінити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Ignore;
            button2.Location = new Point(199, 299);
            button2.Name = "button2";
            button2.Size = new Size(147, 25);
            button2.TabIndex = 12;
            button2.Text = "Повернутися без змін\r\n\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.DialogResult = DialogResult.Abort;
            button3.Location = new Point(199, 330);
            button3.Name = "button3";
            button3.Size = new Size(147, 25);
            button3.TabIndex = 13;
            button3.Text = "Видалити";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // RedactingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 367);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(endTime);
            Controls.Add(startTime);
            Controls.Add(dateTimePicker1);
            Controls.Add(text);
            MinimumSize = new Size(374, 406);
            Name = "RedactingForm";
            Text = "RedactingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private MaskedTextBox endTime;
        private MaskedTextBox startTime;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}