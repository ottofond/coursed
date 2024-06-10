using Diary.Forms;
using Diary.items;
using Diary.Items;
using System.Data;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
namespace Diary
{
    public partial class MainForm : Form
    {
        private DateTime currentDate = DateTime.Now;
        private DiaryStorage Storage = new();
        private const string DATA_PATH = "\\cursed\\Diary\\diary.json";
        

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Storage.LoadData(DATA_PATH);
            Storage.ShowData(currentDate, flowLayoutPanel1);
            this.ReductSub();
            NotificationTimer.Start();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Storage.CreateNewNote();
            Storage.ShowData(currentDate, flowLayoutPanel1);
            this.ReductSub();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            currentDate = dateTimePicker.Value;
            Storage.ShowData(currentDate, flowLayoutPanel1);
            this.ReductSub();
        }

        private void Check_Storage_Notifications(object sender, EventArgs e)
        {
            Storage.Notification();
            Storage.CheckForReschlude();
            Storage.ShowData(currentDate, flowLayoutPanel1);
        }
        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Width = (flowLayoutPanel1.Width - 25);
            }
        }
 
  
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Storage.SaveData(DATA_PATH);
            this.Close();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {

            dateTimePicker.Value = dateTimePicker.Value.AddDays(1);
 
            currentDate = dateTimePicker.Value;
            Storage.ShowData(currentDate, flowLayoutPanel1);
            this.ReductSub();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(-1);

            currentDate = dateTimePicker.Value;
            Storage.ShowData(currentDate, flowLayoutPanel1);
            this.ReductSub();
        }
        public void UserControl_DoubleClick(object sender, EventArgs e)
        {
            NoteForRedactSender noteForRedactSender = (NoteForRedactSender)e;
            Storage.Rescledule(noteForRedactSender);
            Storage.ShowData(currentDate, flowLayoutPanel1);
            this.ReductSub();
        }
        private void ReductSub()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is PlanUnit myControl)
                {
                    myControl.UserControlDoubleClicked += UserControl_DoubleClick;
                }
            }
        }
    }
}
