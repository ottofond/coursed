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

        private DateTime currentDate;
        public Note ResultNote;
        public CreatePlan(DateTime currentDate)
        {
            InitializeComponent();
            this.currentDate = currentDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if
            (DateTime.TryParseExact(startTime.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime start) &&
            DateTime.TryParseExact(endTime.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime end) &&
            end > start && AreAllComboBoxesFilled())
            {
                if(Periodicity.SelectedIndex == 0)
                {
                    ResultNote = new Note(start, end, text.Text, (string)TypeOfNote.SelectedItem);
                }
                else
                {
                    ResultNote = new NotePeriodical(start, end, text.Text, (string)TypeOfNote.SelectedItem, Periodicity.SelectedIndex);
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid time in HH:mm format.");
            }
        }

        private void CreatePlan_Load(object sender, EventArgs e)
        {

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
