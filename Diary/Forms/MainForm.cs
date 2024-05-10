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
        private DateTime currentDate;
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
            var asd = new Note("balaba bama", 2 ,3);
            var sad = new Note("bim bim bam bam", 2, 3);
            var ggwp = new items.Diary();
            ggwp.AddElement(currentDate, asd);
            /*ggwp.AddElement(currentDate, sad);*/

        }
    }
}
