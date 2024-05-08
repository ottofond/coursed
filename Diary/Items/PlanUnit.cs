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
        private int locationX;
        private int locationY;

        public PlanUnit()
        {
            InitializeComponent();
        }

        // Конструктор с параметрами x и y
        public PlanUnit(int x, int y)
        {
            locationX = x;
            locationY = y;
            InitializeComponent();
        }
    }
}
