using Diary.items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary.Forms
{
    public partial class RescheduleForm : Form
    {
        public RescheduleForm(Note note, int cause = 0)
        {
            InitializeComponent();
            if (cause == 0)
            {
                label1.Text = "Ваша подія минула";
            }
            else if (cause == 1)
            {
                label1.Text = "Ваша подія перетинаеєтся з іншою";
            }
            textBox1.Text = note.note;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.Abort;
        }
    }
}
