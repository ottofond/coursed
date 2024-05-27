using System.Windows.Forms;

namespace Diary
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker = new DateTimePicker();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(150, 100);
            splitContainer1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker.Location = new Point(599, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(178, 23);
            dateTimePicker.TabIndex = 5;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 33);
            button1.Name = "button1";
            button1.Size = new Size(159, 25);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 95);
            button3.Name = "button3";
            button3.Size = new Size(159, 25);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 126);
            button4.Name = "button4";
            button4.Size = new Size(159, 25);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 64);
            button2.Name = "button2";
            button2.Size = new Size(159, 25);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.Location = new Point(692, 408);
            button5.Name = "button5";
            button5.Size = new Size(85, 25);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.Location = new Point(601, 408);
            button6.Name = "button6";
            button6.Size = new Size(85, 25);
            button6.TabIndex = 7;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button7.Location = new Point(12, 408);
            button7.Name = "button7";
            button7.Size = new Size(159, 25);
            button7.TabIndex = 8;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.CausesValidation = false;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(177, 33);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(600, 369);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Resize += flowLayoutPanel1_Resize;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 444);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button5;
        private Button button6;
        private Button button7;
        public FlowLayoutPanel flowLayoutPanel1;
    }
}
