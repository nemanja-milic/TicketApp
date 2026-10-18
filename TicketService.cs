using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp
{
    internal class TicketService
    {
        private List<TicketModel> allTickets = new List<TicketModel>();

        private int TicketPerPage = 3;
        public TicketService()
        {
            GenerateRndTickets();
        }

        public void AddTicket(string contactName, string title, string note)
        {
            if(string.IsNullOrEmpty(contactName))
            {
                Console.WriteLine("Contact Name has to entered");
                return;
            }
            if (string.IsNullOrEmpty(title))
            {
                Console.WriteLine("Title has to entered");
                return;
            }
            if (string.IsNullOrEmpty(note))
            {
                Console.WriteLine("Note has to entered");
                return;
            }
            allTickets.Add(new TicketModel(GenerateNewId(), contactName, title, note));
        }

        public void EditTicket(int id, string title, string note, TicketStatus ticketStatus)
        {
            if (string.IsNullOrEmpty(title))
            {
                Console.WriteLine("please insert value for the title");
                return;
            }

            if (string.IsNullOrEmpty(note))
            {
                Console.WriteLine("please insert value for the title");
                return;
            }

            var editedTicketIndex = allTickets.FindIndex((ticket)=> ticket.Id == id);
                    
            if(editedTicketIndex == -1)
            {
                Console.WriteLine("Please provide a valid ID");
                return;
            }

            allTickets[editedTicketIndex].Title = title;
            allTickets[editedTicketIndex].AddNote(note);
            allTickets[editedTicketIndex].Status = ticketStatus;
        }

        public TicketRequest FilterTickets(string title, TicketStatus ticketStatus)
        {
            List<TicketModel> filteredTickets = new List<TicketModel>();
            if(string.IsNullOrEmpty(title))
            {
                filteredTickets = allTickets.Where(ticket => ticket.Status == ticketStatus).Take(TicketPerPage).ToList();

                return new TicketRequest(filteredTickets, allTickets.Count);
            }
            string normalizedTitle = title.ToLower();
            filteredTickets = allTickets.
                Where(ticket => ticket.Title.Contains(normalizedTitle, StringComparison.OrdinalIgnoreCase) && ticket.Status == ticketStatus)
                .Take(TicketPerPage)
                .ToList();
            return new TicketRequest(filteredTickets, allTickets.Count);
        }

        public List<TicketModel> GetOpenTickets()
        {
            return allTickets
                .Where(ticket => ticket.Status == TicketStatus.Open)
                .ToList();
        }

        public List<TicketModel> GetPendingTickets()
        {
            return allTickets
                .Where(ticket => ticket.Status == TicketStatus.Pending)
                .ToList();
        }

        public List<TicketModel> GetResolvedTickets()
        {
            return allTickets
                .Where(ticket => ticket.Status == TicketStatus.Resolved)
                .ToList();
        }

        public int GenerateNewId()
        {
            int countOfAllTickets = allTickets.Count();
            return countOfAllTickets++;
        }
        
        private void GenerateRndTickets()
        {
            AddTicket("Jack", "Haven`t received the package yet", "3 days latency");
            AddTicket("Michael", "Mine headsets are damaged", "Headsets are broken");
            AddTicket("Jack", "PC will not turn on", "PC have power, but just black screen");

            AddTicket("Eli", "The PC will not load up", "power brick faulty");
            AddTicket("Ben", "GXP headsets are damaged", "Headsets are broken");
            AddTicket("Nick", "Cannot login to website", "incorrect password");
        }
    }
}
