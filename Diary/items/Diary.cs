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
        public Dictionary<string, List<Note>> diary = null;
      
        public void AddElement(DateTime currentDay, Note note)
        {
            string currentDate = currentDay.ToString("MM:yyyy"); 

            if (diary == null || !diary.ContainsKey(currentDate))
            {
                diary.Add(currentDate, new List<Note>()); 
            }

            diary[currentDate].Add(note); 
        }
       
        public void LoadData()
        {

        }
        public void SaveData(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {

                foreach (var day in diary)
                {
                    writer.WriteLine(day.Key + " ");

                    foreach (var note in day.Value)
                    {
                        writer.Write(note + ", ");
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}
