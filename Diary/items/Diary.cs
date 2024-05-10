using Diary.Items;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.items
{
    public class Diary
    {
        public List<Note> diary = new List<Note>();
      
        public void SaveData(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Note note in diary)
                {
                    writer.WriteLine(note.date);
                    writer.WriteLine(note.locationY);
                    writer.WriteLine(note.height);
                    writer.WriteLine(note.note);
                }
            }
        }
        public void LoadData()
        {

        }
    }
}
