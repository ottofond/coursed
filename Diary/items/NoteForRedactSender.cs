using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.items
{
    public class NoteForRedactSender : EventArgs
    {
        public Note RedactNote { get; }

        public NoteForRedactSender(Note note)

        {
            RedactNote = note;
        }
    }
}
