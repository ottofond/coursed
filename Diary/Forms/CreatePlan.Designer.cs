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
            startTime = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            endTime = new MaskedTextBox();
            SuspendLayout();
            // 
            // text
            // 
            text.Location = new Point(12, 12);
            text.Multiline = true;
            text.Name = "text";
            text.Size = new Size(683, 386);
            text.TabIndex = 0;
            // 
            // startTime
            // 
            startTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            startTime.BorderStyle = BorderStyle.None;
            startTime.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startTime.Location = new Point(709, 44);
            startTime.Mask = "00:00";
            startTime.Name = "startTime";
            startTime.Size = new Size(87, 32);
            startTime.TabIndex = 1;
            startTime.ValidatingType = typeof(DateTime);
            // 
            // button1
            // 
            button1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(499, 404);
            button1.Name = "button1";
            button1.Size = new Size(95, 34);
            button1.TabIndex = 2;
            button1.Text = "create";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(600, 404);
            button2.Name = "button2";
            button2.Size = new Size(95, 34);
            button2.TabIndex = 3;
            button2.Text = "cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // endTime
            // 
            endTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            endTime.BorderStyle = BorderStyle.None;
            endTime.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            endTime.Location = new Point(709, 106);
            endTime.Mask = "00:00";
            endTime.Name = "endTime";
            endTime.Size = new Size(87, 32);
            endTime.TabIndex = 4;
            endTime.ValidatingType = typeof(DateTime);
            // 
            // CreatePlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 441);
            Controls.Add(endTime);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(startTime);
            Controls.Add(text);
            Name = "CreatePlan";
            Text = "CreatePlan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text;
        private MaskedTextBox startTime;
        private Button button1;
        private Button button2;
        private MaskedTextBox endTime;
    }
}