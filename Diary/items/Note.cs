using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.items
{
    public class Note
    {
        public string note;
        public int locationY;
        public int height;
        public Note(DateTime date, string note, DateTime startTime, DateTime endTime)
        {
            this.note = note;
        }
    }
}
