using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.items
{
    public class NotePeriodical : Note
    {
        /*public bool daily, weekly, monthly, annually;*/
        public int periodicity;
        public NotePeriodical(DateTime start, DateTime end, string note, string type, int periodicity) : base(start, end, note, type)
        {
            /*switch (periodicity)
            {
                case 1:
                    daily = true;
                    break;
                case 2:
                    weekly = true;
                    break;
                case 3:
                    monthly = true;
                    break;
                case 4:
                    annually = true;
                    break;
            }*/
            this.periodicity = periodicity;
        }
    }
}
