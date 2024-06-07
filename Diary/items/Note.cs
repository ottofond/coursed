using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Diary.items
{
    public class Note : IComparable<Note>
    {
        public DateTime startTime;
        public DateTime endTime;
        public string note;
        public string type;
        public DateTime notification { get ; set; }
        public bool notificated;

        public Note(DateTime start, DateTime end, string note, string type, int notification, bool notificated = false)
        {
            this.type = type;
            this.note = note;
            startTime = start;
            this.notification = start;
            this.notificated = notificated;
            endTime = end;

            switch (notification)
            {
                case 1:
                    this.notification = this.notification.AddMinutes(-10);
                    break;
                case 2:
                    this.notification = this.notification.AddHours(-1);
                    break;
                case 3:
                    this.notification = this.notification.AddDays(-1);
                    break;
                case 4:
                    this.notification = this.notification.AddDays(-7);
                    break;

            }
        }

        [JsonConstructor]
        public Note(DateTime start, DateTime end, string note, string type, DateTime notification, bool notificated = false)
        {
            this.type = type;
            this.note = note;
            startTime = start;
            this.notification = notification;
            this.notificated = notificated;
            endTime = end;
        }

        public virtual void CheckNotification()
        {
            if (!notificated && DateTime.Now >= notification && DateTime.Now < startTime)
            {
                notificated = true;
                MessageBox.Show($"Нагадування: {note}, відбудеться о {startTime}", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public int CompareTo(Note? other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                TimeSpan thisTime = this.startTime.TimeOfDay;
                TimeSpan otherTime = other.startTime.TimeOfDay;
                return thisTime.CompareTo(otherTime);
            }
        }
    }
}
