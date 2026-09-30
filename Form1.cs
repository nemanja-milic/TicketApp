namespace TicketApp
{
    public partial class Form1 : Form
    {
        TicketService TicketService = new TicketService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnShowAllTickets_Click(object sender, EventArgs e)
        {
            List<TicketModel> list = TicketService.GetAllTickets();

            foreach (TicketModel ticket in list)
            {
                GroupBox groupBox = new GroupBox();

                groupBox.Text = $"" +
                    $"ID - {ticket.Id} \n" +
                    $"Contact Name - {ticket.ContactName} \n" +
                    $"Title - {ticket.Title}  \n" +
                    $"Latest note - {ticket.LatestNote()}"

                    ;
                flowLayoutPanelTickets.Controls.Add(groupBox);
            }
        }
    }
}
