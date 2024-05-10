using Diary.items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary.Items
{
    public partial class PlanUnit : UserControl
    {
        public PlanUnit(Note Note)
        {
            InitializeComponent();
        }
        public PlanUnit()
        {
            InitializeComponent();
        }
        // Конструктор с параметрами x и y



        private void PlanUnit_DoubleClick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
