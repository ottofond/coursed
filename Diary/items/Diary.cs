using Diary.Items;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diary.Forms;
using Newtonsoft.Json;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
namespace Diary.items
{
    public class DiaryStorage
    {
        public Dictionary<DateTime, List<Note>> diary = new();
        public Dictionary<NotePeriodical, List<DateTime>> periodicDiary = new();
        public readonly DateTime borderDate = new DateTime(2030, 1, 1);
        public void Add(DateTime currentDate, Note note)
        {
            if (diary.ContainsKey(currentDate.Date))
            {
                diary[currentDate.Date].Add(note);
            }
            else
            {
                diary[currentDate.Date] = new List<Note> { note };
            }
        }
        public void Add(NotePeriodical note)
        {
            DateTime currentDate = DateTime.Now.Date;
            periodicDiary[note] = new List<DateTime> {};
            while (currentDate < borderDate)
            {
                periodicDiary[note].Add(currentDate.Date);
                switch (note.periodicity)
                {
                    case 1:
                        currentDate = currentDate.AddDays(1);
                        continue;
                    case 2:
                        currentDate = currentDate.AddDays(7);
                        continue;
                    case 3:
                        currentDate = currentDate.AddMonths(1);
                        continue;
                    case 4:
                        currentDate = currentDate.AddYears(1);
                        continue;
                }   
            }
        }
        public void SaveData(string path)
        {
            var periodicDiaryList = periodicDiary.Select(entry => new
            {
                Note = entry.Key,
                Dates = entry.Value
            }).ToList();

            var dataToSave = new
            {
                Diary = diary,
                PeriodicDiary = periodicDiaryList
            };

            string json = JsonConvert.SerializeObject(dataToSave, Formatting.Indented);
            File.WriteAllText(path, json);
        }
        public void LoadData(string path)
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (!string.IsNullOrEmpty(json))
                {
                    JObject data = JObject.Parse(json);

                    if (data["Diary"] != null)
                    {
                        diary = data["Diary"].ToObject<Dictionary<DateTime, List<Note>>>();
                    }

                    if (data["PeriodicDiary"] != null)
                    {
                        var periodicDiaryList = data["PeriodicDiary"].ToObject<List<PeriodicDiaryEntry>>();
                        periodicDiary = periodicDiaryList.ToDictionary(
                            entry => entry.Note,
                            entry => entry.Dates
                        );
                    }
                }
            }
        }

        public class PeriodicDiaryEntry
        {
            public NotePeriodical Note { get; set; }
            public List<DateTime> Dates { get; set; }
        }
        public void ShowData(DateTime datetime, FlowLayoutPanel panel)
        {
            panel.Controls.Clear();
            List<Note> ElementsToShow = new List<Note>();
            if (diary.TryGetValue(datetime.Date, out List<Note> notes))
            {
                foreach (Note note in notes)
                {
                    ElementsToShow.Add(note);

                }
            }
            foreach (var entry in periodicDiary)
            {
                NotePeriodical note = entry.Key;
                List<DateTime> periodicList = entry.Value;

                if (periodicList.Contains(datetime.Date))
                {
                    ElementsToShow.Add(note);
                }
            }
            ElementsToShow.Sort();
            foreach (Note item in ElementsToShow)
            {
                panel.Controls.Add(new PlanUnit(item, (panel.Width - 10)));
            }
            if(ElementsToShow.Count == 0) 
            {
                Label noDataLabel = new Label { Text = "No notes found for this date."};
                panel.Controls.Add(noDataLabel);
            }
        }
        public void CheckDate()
        {

        }
    }
}
