using System.Windows.Forms;

namespace Diary.Items
{
    partial class PlanUnit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox = new TextBox();
            startTime = new MaskedTextBox();
            endTime = new MaskedTextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HotTrack;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Dock = DockStyle.Left;
            textBox1.Enabled = false;
            textBox1.ImeMode = ImeMode.Off;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(15, 87);
            textBox1.TabIndex = 0;
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox.Location = new Point(21, 3);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(502, 84);
            textBox.TabIndex = 1;
            textBox.Text = "Замітка";
            textBox.DoubleClick += textBox_DoubleClick;
            // 
            // startTime
            // 
            startTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            startTime.BorderStyle = BorderStyle.None;
            startTime.Enabled = false;
            startTime.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startTime.Location = new Point(529, 13);
            startTime.Mask = "00:00";
            startTime.Name = "startTime";
            startTime.Size = new Size(56, 23);
            startTime.TabIndex = 2;
            startTime.ValidatingType = typeof(DateTime);
            // 
            // endTime
            // 
            endTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            endTime.BorderStyle = BorderStyle.None;
            endTime.Enabled = false;
            endTime.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            endTime.Location = new Point(529, 54);
            endTime.Mask = "00:00";
            endTime.Name = "endTime";
            endTime.ReadOnly = true;
            endTime.Size = new Size(56, 23);
            endTime.TabIndex = 3;
            endTime.ValidatingType = typeof(DateTime);
            // 
            // PlanUnit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImageLayout = ImageLayout.None;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(endTime);
            Controls.Add(startTime);
            Controls.Add(textBox);
            Controls.Add(textBox1);
            Name = "PlanUnit";
            Size = new Size(588, 87);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox;
        private MaskedTextBox startTime;
        private MaskedTextBox endTime;
    }
}
