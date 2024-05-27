using Diary.Forms;
using Diary.items;
using Diary.Items;
using System.Data;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Diary.items;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
namespace Diary
{
    public partial class MainForm : Form
    {
        private DateTime currentDate = DateTime.Now;
        private DiaryStorage ggwp = new();
        private const string DATA_PATH = "\\cursed\\Diary\\diary.json";
        private const string DATA_PATH_PERIODICAL = "\\cursed\\Diary\\diaryPeriodical.json";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ggwp.LoadData(DATA_PATH);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ggwp.ShowData(currentDate, flowLayoutPanel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var create = new CreatePlan(currentDate);
            create.Owner = this;

            if (create.ShowDialog() == DialogResult.OK)
            {
                var result = create.ResultNote;
                if (result is NotePeriodical notePeriodical)
                {
                    ggwp.Add(notePeriodical);
                }
                else
                {
                    ggwp.Add(currentDate, result);
                }
            } 
        }
        private void panel1_Resize(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            currentDate = dateTimePicker.Value;
            ggwp.ShowData(currentDate, flowLayoutPanel1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ggwp.SaveData(DATA_PATH);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ggwp.LoadData(DATA_PATH);
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Width = (flowLayoutPanel1.Width-25);
            }
        }
    }
}
