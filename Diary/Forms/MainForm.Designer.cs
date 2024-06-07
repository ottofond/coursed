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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker = new DateTimePicker();
            CreateButton = new Button();
            ForwardButton = new Button();
            BackButton = new Button();
            ExitButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            NotificationTimer = new System.Windows.Forms.Timer(components);
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
            dateTimePicker.Location = new Point(575, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(178, 23);
            dateTimePicker.TabIndex = 5;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(12, 33);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(159, 25);
            CreateButton.TabIndex = 1;
            CreateButton.Text = "Створити подію";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // ForwardButton
            // 
            ForwardButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ForwardButton.Location = new Point(668, 446);
            ForwardButton.Name = "ForwardButton";
            ForwardButton.Size = new Size(85, 25);
            ForwardButton.TabIndex = 6;
            ForwardButton.Text = "Вперед";
            ForwardButton.UseVisualStyleBackColor = true;
            ForwardButton.Click += ForwardButton_Click;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BackButton.Location = new Point(577, 446);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(85, 25);
            BackButton.TabIndex = 7;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExitButton.Location = new Point(12, 446);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(159, 25);
            ExitButton.TabIndex = 8;
            ExitButton.Text = "Вийти  з застосунку";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
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
            flowLayoutPanel1.Size = new Size(576, 407);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Resize += flowLayoutPanel1_Resize;
            // 
            // NotificationTimer
            // 
            NotificationTimer.Enabled = true;
            NotificationTimer.Interval = 60000;
            NotificationTimer.Tick += Check_Storage_Notifications;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 482);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ExitButton);
            Controls.Add(BackButton);
            Controls.Add(ForwardButton);
            Controls.Add(CreateButton);
            Controls.Add(dateTimePicker);
            MinimumSize = new Size(504, 298);
            Name = "MainForm";
            Text = "Diary";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker;
        private Button CreateButton;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button ForwardButton;
        private Button BackButton;
        private Button ExitButton;
        public FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer NotificationTimer;
    }
}
