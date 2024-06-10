using Diary.Forms;
using Diary.items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary.Items
{
    public partial class PlanUnit : UserControl
    {
        public Note redactBuff;
        public event EventHandler UserControlDoubleClicked;
        private Dictionary<string, Color> color = new Dictionary<string, Color>()
        {
            {"свято", Color.Red },
            {"робота", Color.Gray },
            {"розваги", Color.Yellow },
            {"дозвілля", Color.Blue }
        };

        public PlanUnit(Note Note, int width)
        {
            InitializeComponent();
            redactBuff = Note;
            this.Width = width - 15;
            textBox.Text = Note.note;
            startTime.Text = Note.startTime.ToString("HH:mm");
            endTime.Text = Note.endTime.ToString("HH:mm");
            textBox1.BackColor = color[Note.type];

        }
        private void textBox_DoubleClick(object sender, EventArgs e)
        {
            UserControlDoubleClicked?.Invoke(this, new NoteForRedactSender(redactBuff));
        }
    }
}
