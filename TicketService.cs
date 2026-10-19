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

        private int numberForID {  get; set; }

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

        public TicketRequest FilterTickets(string title, TicketStatus ticketStatus, int page)
        {
            List<TicketModel> filteredTickets = new List<TicketModel>();


            int startFromTicket = (page - 1) * TicketPerPage;
            if(startFromTicket < 0) startFromTicket = 0;
            int totalCount = 0;


            if (string.IsNullOrEmpty(title))
            {
                filteredTickets = 
                    allTickets.
                    Where(ticket => ticket.Status == ticketStatus).
                    Skip(startFromTicket).
                    Take(TicketPerPage).
                    ToList();
                totalCount = allTickets.
                    Where(ticket => ticket.Status == ticketStatus).
                    Count();

                return new TicketRequest(filteredTickets, totalCount);
            }
            string normalizedTitle = title.ToLower();
            filteredTickets = allTickets.
                Where(ticket => ticket.Title.Contains(normalizedTitle, StringComparison.OrdinalIgnoreCase) && ticket.Status == ticketStatus)
                .Skip(startFromTicket)
                .Take(TicketPerPage)
                .ToList();

            totalCount = allTickets.
                    Where(ticket => ticket.Title.Contains(normalizedTitle, StringComparison.OrdinalIgnoreCase) && ticket.Status == ticketStatus).Count();
            return new TicketRequest(filteredTickets, totalCount);
        }
        public int GenerateNewId()
        {
            numberForID++;
            return numberForID;
        }
        
        private void GenerateRndTickets()
        {
            AddTicket("1", "Haven`t received the package yet", "3 days latency");
            AddTicket("2", "Mine headsets are damaged", "Headsets are broken");
            AddTicket("3", "PC will not turn on", "PC have power, but just black screen");

            AddTicket("4", "The PC will not load up", "power brick faulty");
            AddTicket("5", "GXP headsets are damaged", "Headsets are broken");
            AddTicket("6", "Cannot login to website", "incorrect password");
        }
    }
}
