using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary.items
{
    public class NotePeriodical : Note
    {
        public int periodicity;
        public NotePeriodical(DateTime start, DateTime end, string note, string type, int periodicity, int notification) : base(start, end, note, type, notification)
        {
            this.periodicity = periodicity;
        }
        [JsonConstructor]
        public NotePeriodical(DateTime start, DateTime end, string note, string type, int periodicity, DateTime notification) : base(start, end, note, type, notification)
        {
            this.periodicity = periodicity;
        }
        public override void CheckNotification()
        {
            if (DateTime.Now >= notification && DateTime.Now < startTime)
            {
                MessageBox.Show($"Нагадування: {note}, відбудеться о {startTime}", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                switch (periodicity)
                {
                    case 1:
                        this.notification = this.notification.AddDays(1);
                        break;
                    case 2:
                        this.notification = this.notification.AddDays(7);
                        break;
                    case 3:
                        this.notification = this.notification.AddMonths(1);
                        break;
                    case 4:
                        this.notification = this.notification.AddYears(1);
                        break;
                }
            }
        }
        public override bool CheckNoteCrossing(DiaryStorage storage) {

            foreach (DateTime date in storage.periodicDiary[this])
            {
                if (storage.diary.Keys.Contains(date.Date))
                {
                    foreach (Note other in storage.diary[date.Date])
                    {
                        if (other.startTime.TimeOfDay < this.endTime.TimeOfDay &&
                            other.endTime.TimeOfDay > this.startTime.TimeOfDay)
                        {
                            return true;
                        }
                    }
                }
                foreach (NotePeriodical other in storage.periodicDiary.Keys)
                {
                    foreach (DateTime otherDate in storage.periodicDiary[other])
                    {
                        if (other.note != this.note &&
                            otherDate.Date == date.Date &&
                            this.endTime.TimeOfDay > other.startTime.TimeOfDay &&
                            this.startTime.TimeOfDay < other.endTime.TimeOfDay)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
