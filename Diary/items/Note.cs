using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Diary.items
{
    public class Note : IComparable<Note>
    {
        public DateTime startTime;
        public DateTime endTime;
        public string note;
        public string type;
         

        public Note(DateTime start, DateTime end, string note, string type)
        {
            this.type = type;
            this.note = note;
             
            startTime = new DateTime(1, 1, 1, start.Hour, start.Minute, 0); 
            endTime = new DateTime(1, 1, 1, end.Hour, end.Minute, 0);
        }
        public int CompareTo(Note? other)
        {
            if (other == null)
            {
                return 1;
            }
            else if ((int)this.startTime.Hour > (int)other.startTime.Hour)
            {
                return 1;
            }
            else if ((int)this.startTime.Hour < (int)other.startTime.Hour)
            {
                return -1;
            }
            else  
            {
                if((int)this.startTime.Minute > (int)other.startTime.Minute)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }        
            }
        }
    }
}
