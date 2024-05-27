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
        private Dictionary<string, Color> color= new Dictionary<string, Color>()
        {
            {"свято", Color.Red },
            {"робота", Color.Gray },
            {"розваги", Color.Yellow },
            {"дозвілля", Color.Blue }
        };

        public PlanUnit(Note Note, int width)
        {
            InitializeComponent();
            this.Width = width - 15;
            textBox2.Text = Note.note;
            startTime.Text = Note.startTime.ToString("HH:mm");
            endTime.Text = Note.endTime.ToString("HH:mm");
            textBox1.BackColor = color[Note.type];
        }

        private void PlanUnit_DoubleClick(object sender, EventArgs e)
        {
            // Your code for double click event
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Your code for label click event
        }
    }
}
