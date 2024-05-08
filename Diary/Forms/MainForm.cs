using Diary.Forms;
using Diary.Items;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
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
            var create = new CreatePlan();
            create.ShowDialog();
        }
    }
}
