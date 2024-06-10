using Diary.items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Diary.Forms
{
    public partial class CreatePlan : Form
    {
 
        public Note ResultNote;
 
        public CreatePlan()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.CreateElement();
        }
        private void CreateElement()
        {
            if
            (AreAllComboBoxesFilled() &&
            DateTime.TryParseExact(startTime.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime start) &&
            DateTime.TryParseExact(endTime.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime end) &&
            end > start)
            {
                DateTime startTime = new(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, start.Hour, start.Minute, 0);
                if (Periodicity.SelectedIndex == 0)
                {
                    ResultNote = new Note(startTime, end, text.Text, (string)TypeOfNote.SelectedItem, Notificate.SelectedIndex);
                }
                else
                {
                    ResultNote = new NotePeriodical(startTime, end, text.Text, (string)TypeOfNote.SelectedItem, Periodicity.SelectedIndex, Notificate.SelectedIndex);
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Будь ласка введіть коректні значення часу, та заповніть усі поля");
            }
        }
        private bool AreAllComboBoxesFilled()
        {
            Dictionary <ComboBox, Label> comboBoxLabelPairs = new()
            {
                { Notificate, Notificate_Check },
                { TypeOfNote, TypeOfNote_Check },
                { Periodicity, Periodicity_Check }
            };

            bool all = true;

            foreach (KeyValuePair<ComboBox, Label> pair in comboBoxLabelPairs)
            {
                if (pair.Key.SelectedItem == null)
                {
                    pair.Value.ForeColor = System.Drawing.Color.Red;
                    all = false;
                }
                else
                {
                    pair.Value.ForeColor = System.Drawing.Color.White;
                }
            }
            return all;
        }
    }
}
