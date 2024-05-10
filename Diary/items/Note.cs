﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.items
{
    public class Note
    {
        public string date;
        public string note;
        public int locationY;
        public int height;
        public Note(DateTime date, string note, DateTime startTime, DateTime endTime)
        {
            this.note = note;
        }
        public Note(DateTime date, string note, int locationY, int height)
        {
            this.note = note;
            this.date = date.ToString("MM:yyyy");
            this.locationY = locationY;
            this.height = height;
        }
    }
}
