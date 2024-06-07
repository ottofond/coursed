using Diary.Forms;
using Diary.Items;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
namespace Diary.items
{
    public class DiaryStorage
    {
        public Dictionary<DateTime, List<Note>> diary = new();
        public Dictionary<NotePeriodical, List<DateTime>> periodicDiary = new();
        public readonly DateTime borderDate = DateTime.Now.AddYears(7);

        public void Add(Note note)
        {
            if (note is NotePeriodical periodical)
            {
                this.AddNotePeriocical(periodical);
            }
            else
            {
                this.AddNote(note);
            }
        }

        private void AddNote(Note note)
        {
            if (diary.ContainsKey(note.startTime.Date))
            {
                diary[note.startTime.Date].Add(note);
            }
            else
            {
                diary[note.startTime.Date] = new List<Note> { note };
            }
        }

        private void AddNotePeriocical(NotePeriodical note)
        {
            DateTime currentDate = note.startTime;
            periodicDiary[note] = new List<DateTime> { };
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
        public bool CheckForCrossing(Note note) 
        {
             
            if (note is NotePeriodical periodicalToCheck)
            {
                foreach (DateTime date in periodicDiary[periodicalToCheck])
                {
                    if (diary.Keys.Contains(date.Date))
                    {
                        foreach (Note other in diary[date.Date])
                        {
                            if (other.startTime.TimeOfDay < periodicalToCheck.endTime.TimeOfDay &&
                                other.endTime.TimeOfDay > periodicalToCheck.startTime.TimeOfDay)
                            {
                                return true;
                            }
                        }
                    }
                    foreach (NotePeriodical other in periodicDiary.Keys)
                    {
                        foreach(DateTime otherDate in periodicDiary[other])
                        {
                            if (other.note != periodicalToCheck.note &&
                                otherDate.Date==date.Date &&
                                periodicalToCheck.endTime.TimeOfDay > other.startTime.TimeOfDay &&
                                periodicalToCheck.startTime.TimeOfDay< other.endTime.TimeOfDay)
                            {
                                return true ;
                            }
                        }
                    }
                }
            }
            else if(note is Note noteToCheck)
            {
                if (diary.Keys.Contains(note.startTime.Date))
                {
                    foreach (Note other in diary[note.startTime.Date])
                    {
                        if (other.note != noteToCheck.note &&
                            noteToCheck.startTime < other.endTime && 
                            noteToCheck.endTime.TimeOfDay > other.startTime.TimeOfDay)
                        {
                            return true;
                        }

                    }
                }

                foreach (var other in periodicDiary.Keys)
                {
                    foreach (DateTime otherDate in periodicDiary[other])
                    {
                        if (noteToCheck.startTime.Date == otherDate.Date &&
                           noteToCheck.endTime.TimeOfDay > other.startTime.TimeOfDay &&
                           noteToCheck.startTime.TimeOfDay < other.endTime.TimeOfDay
                           )
                        {
                             
                            return true;
                        }
                    }
                }
                return false;
            }
            return false;
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
                if (entry.Value.Contains(datetime.Date))
                {
                    ElementsToShow.Add(entry.Key);
                }
            }

            if (ElementsToShow.Count == 0)
            {
                Label noDataLabel = new Label { Text = "Жодних подій" };
                panel.Controls.Add(noDataLabel);
            }
            else
            {
                ElementsToShow.Sort();
                foreach (Note item in ElementsToShow)
                {
                    PlanUnit unitToShow = new PlanUnit(item, (panel.Width - 10));
                    panel.Controls.Add(unitToShow);

                }
            }
        }
        public void Notification()
        {
            foreach (var day in diary.Values)
            {
                foreach (Note note in day)
                {
                    note.CheckNotification();
                }
            }

            foreach (Note note in periodicDiary.Keys)
            {
                note.CheckNotification();
            }
        }
        public void RemoveNote(Note note)
        {
            if (note is NotePeriodical)
            {
                RemovePeiodical((NotePeriodical)note);
            }
            else
            {
                Remove(note);
            }
        }
        public void RemovePeiodical(NotePeriodical note)
        {
            periodicDiary.Remove(note);
        }
        public void Remove(Note note)
        {
            diary[note.startTime.Date].Remove(note);
        }
        public void CheckForReschlude()
        {
            List<Note> listToRemove = new List<Note>();
            List<Note> listToRedact = new List<Note>();

            foreach (DateTime date in diary.Keys)
            {
                if (date < DateTime.Now.Date)
                {
                    foreach (Note note in diary[date])
                    {
                        var reschleude = new RescheduleForm(note);
                        DialogResult reschleudeResult = reschleude.ShowDialog();

                        if (reschleudeResult == DialogResult.Abort)
                        {
                            listToRemove.Add(note);
                        }
                        else
                        {
                            listToRedact.Add(note);
                        }
                    }
                }
            }

            foreach (Note note in listToRemove)
            {
                this.RemoveNote(note);
            }

            foreach (Note note in listToRedact)
            {
                CallRedacrtForm(note);
            }
        }
        private void CallRedacrtForm(Note note)
        {
            var redact = new RedactingForm(note);
            var result = redact.noteForRedact;
            this.RemoveNote(note);
            DialogResult dialogResult = redact.ShowDialog();

            if (dialogResult == DialogResult.Ignore) 
            {
                this.Add(result);
            }
            else if (dialogResult != DialogResult.Abort)
            {
                this.Add(result);
                if (this.CheckForCrossing(result))
                {
                    var redac2t = new RescheduleForm(result, 1);
                    DialogResult dialogResult2 = redac2t.ShowDialog();
                    if (dialogResult2 == DialogResult.OK)
                    {
                        CallRedacrtForm(result);
                    }
                    else if (dialogResult2 == DialogResult.Cancel)
                    {

                        Remove(result);
                    }
                }

            }
        }
        public void Rescledule(NoteForRedactSender noteForRedactSender)
        {
            var redactNote = noteForRedactSender.RedactNote;

            CallRedacrtForm(redactNote);
        }
        public void CreateNewNote()
        {
            var create = new CreatePlan();
            if (create.ShowDialog() == DialogResult.OK)
            {
                var result = create.ResultNote;
                this.Add(result);
 
                if(this.CheckForCrossing(result))
                {
                    var redact = new RescheduleForm(result,1);
                    DialogResult dialogResult = redact.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        CallRedacrtForm(result);
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                       
                        Remove(result);
                    }
                }
            }
        }
    }
}