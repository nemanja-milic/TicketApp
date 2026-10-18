using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp
{
    internal class TicketRequest
    {

        public int TotalCountOfTickets { get; private set; }
        public List<TicketModel> ListOfTickets { get; private set; }

        public TicketRequest(List<TicketModel> list, int allTicketsCount)
        {
            ListOfTickets = list;
            TotalCountOfTickets = allTicketsCount;
        }
    }
}
