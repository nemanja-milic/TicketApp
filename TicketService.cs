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
        public TicketService()
        {
            GenerateRndTickets();
        }

        public void AddTicket(string contactName, string title, string note)
        {
            allTickets.Add(new TicketModel(GenerateNewId(), contactName, title, note));
        }

        public List<TicketModel> GetAllTickets()
        {
            return allTickets;
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
        }
    }
}
