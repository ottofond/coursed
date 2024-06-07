using Diary.items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Diary.Forms
{
    public partial class RedactingForm : Form
    {
        public Note noteForRedact;
        public RedactingForm(Note noteForRedact)
        {
            InitializeComponent();
            this.noteForRedact = noteForRedact;
            text.Text = noteForRedact.note;
            startTime.Text = noteForRedact.startTime.ToString("HH:mm");
            endTime.Text = noteForRedact.endTime.ToString("HH:mm");
            dateTimePicker1.Value = noteForRedact.startTime.Date;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Ignore;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RedactElement();
        }
        private void RedactElement()
        {
            if
            (DateTime.TryParseExact(startTime.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime start) &&
            DateTime.TryParseExact(endTime.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime end) &&
            end > start)
            {
                DateTime startTime = new(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, start.Hour, start.Minute, 0);

                noteForRedact.note = text.Text;
                noteForRedact.startTime = startTime;
                noteForRedact.endTime = end;
                noteForRedact.notificated = false;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Будь ласка введіть коректні значення часу");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
