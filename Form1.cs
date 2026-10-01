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

            List<TicketModel> list = TicketService.GetOpenTickets();

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

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            groupBoxAddTicket.Visible = true;
        }

        private void btnSaveNewTicket_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContactName.Text))
            {
                MessageBox.Show("Contact Name has to entered");
                return;
            }
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Title has to entered");
                return;
            }
            if (string.IsNullOrEmpty(txtNote.Text))
            {
                MessageBox.Show("Note has to entered");
                return;
            }
            TicketService.AddTicket(txtContactName.Text, txtTitle.Text, txtNote.Text);
        }

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            groupBoxAddTicket.Visible = false;
        }
    }
}
