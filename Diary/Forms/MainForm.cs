using Diary.Forms;
using Diary.items;
using Diary.Items;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diary
{
    public partial class MainForm : Form
    {
        private DateTime currentDate = DateTime.Now;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            PlanUnit unit = new();
            panel1.Controls.Add(unit);
            unit.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var create = new CreatePlan(currentDate);
            create.ShowDialog();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            currentDate = dateTimePicker1.Value.Date;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Note asd = new Note(currentDate,"balabama bama",100,100);
            Note sad = new Note(currentDate, "bim bim bam bam", 122, 3322);
            var ggwp = new items.Diary();
            ggwp.diary.Add(asd);
            ggwp.diary.Add(sad);
            ggwp.SaveData("\\cursed\\Diary\\diary.txt");
        }
    }
}
