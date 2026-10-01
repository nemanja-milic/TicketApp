using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp
{
    internal class TicketModel
    {
        public int Id { get; private set; }
        public string ContactName { get; set; }
        public string Title { get; set; }

        private List<string> notes = new List<string>();
        public List<string> Notes()
        {
            return notes;
        }
        public void AddNote(string note)
        {
            notes.Add(note);
        }

        public string LatestNote()
        {
            return notes[notes.Count()-1];
        }
        public TicketStatus Status { get; set; }
        public TicketModel(int id, string name, string title, string note)
        {
            Id = id;
            ContactName = name;
            Title = title;
            AddNote(note);
            Status = TicketStatus.Open;
        }
    }
}
