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

namespace Diary.Forms
{
    public partial class CreatePlan : Form
    {
        private DateTime currentDate;
        public CreatePlan(DateTime currentDate)
        {
            InitializeComponent();
            this.currentDate = currentDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string timeText = startTime.Text;
            
            if (DateTime.TryParse(timeText,out DateTime timeValue))
            {
                
                this.Text = "Время: " + timeValue.ToString();
            }
            else
            {

                this.Text = "Некорректный формат времени.";
            }
        }
    }
}
