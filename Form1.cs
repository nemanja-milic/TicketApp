using System.Collections.Generic;

namespace TicketApp
{
    public partial class Form1 : Form
    {
        TicketService TicketService = new TicketService();

        TicketModel EditedTicket;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<TicketModel> list = TicketService.GetOpenTickets();
            DisplayTickets(list);

        }
        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            groupBoxAddTicket.Visible = true;
            groupBoxEditTicket.Visible = false;
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
            ClearAddTicketTxtInputs();
        }

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            ClearAddTicketTxtInputs();
            groupBoxAddTicket.Visible = false;
        }
        private void btnOpenTickets_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelTickets.Controls.Clear();
            List<TicketModel> list = TicketService.GetOpenTickets();
            DisplayTickets(list);
        }

        private void btnPendingTickets_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelTickets.Controls.Clear();
            List<TicketModel> list = TicketService.GetPendingTickets();
            DisplayTickets(list);
        }

        private void btnResolvedTickets_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelTickets.Controls.Clear();
            List<TicketModel> list = TicketService.GetResolvedTickets();
            DisplayTickets(list);
        }

        private void EditTicket(object sender, EventArgs e)
        {
            groupBoxEditTicket.Visible = true;
            Button editBtn = (Button)sender;
            if (editBtn.Tag == null)
            {
                Console.WriteLine("Ticket tag is null");
                return;
            }
            EditedTicket = (TicketModel)editBtn.Tag;
            if (EditedTicket.Status == TicketStatus.Open)
            {
                btnEditOpen.Checked = true;
            }
            else if (EditedTicket.Status == TicketStatus.Pending)
            {
                btnEditPending.Checked = true;
            }
            else if (EditedTicket.Status == TicketStatus.Resolved)
            {
                btnEditResolved.Checked = true;
            }
            txtEditTitle.Text = EditedTicket.Title;
            txtEditNote.Text = EditedTicket.Notes()[0]; // for now it will be only first note

        }

        private void DisplayTickets(List<TicketModel> list)
        {
            foreach (TicketModel ticket in list)
            {
                GroupBox groupBox = new GroupBox();
                Button btnEdit = new Button();
                btnEdit.Tag = ticket;
                btnEdit.Text = "Edit";
                btnEdit.Click += EditTicket;


                groupBox.Text = $"" +
                    $"ID - {ticket.Id} \n" +
                    $"Contact Name - {ticket.ContactName} \n" +
                    $"Title - {ticket.Title}  \n" +
                    $"Latest note - {ticket.LatestNote()}"

                    ;
                groupBox.Controls.Add(btnEdit);
                flowLayoutPanelTickets.Controls.Add(groupBox);
            }
        }

        private void ClearAddTicketTxtInputs()
        {
            txtContactName.Text = "";
            txtTitle.Text = "";
            txtNote.Text = "";
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            TicketStatus ticketStatus = TicketStatus.Open;
            if(btnEditOpen.Checked)
                ticketStatus = TicketStatus.Resolved;
            if (btnEditPending.Checked)
                ticketStatus = TicketStatus.Pending;
            if(btnEditResolved.Checked)
                ticketStatus = TicketStatus.Resolved;
            TicketService.EditTicket(EditedTicket.Id, txtEditTitle.Text, txtEditTitle.Text, txtEditNote.Text, ticketStatus);
        }
    }
}
