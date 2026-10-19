using System.Collections.Generic;

namespace TicketApp
{
    public partial class Form1 : Form
    {
        TicketService TicketService = new TicketService();

        TicketModel EditedTicket;

        TicketStatus SelectedRadioStatus;

        private int TicketPerPage = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectedRadioStatus = TicketStatus.Open;
            FilterTickets();

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
            SelectedRadioStatus = TicketStatus.Open;
        }

        private void btnPendingTickets_CheckedChanged(object sender, EventArgs e)
        {
            SelectedRadioStatus = TicketStatus.Pending;
        }

        private void btnResolvedTickets_CheckedChanged(object sender, EventArgs e)
        {
            SelectedRadioStatus = TicketStatus.Resolved;
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
            flowLayoutPanelTickets.Controls.Clear();
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

        private void LoadPagination(int ticketPerPage, double numberOfTickets)
        {
            if(numberOfTickets <= ticketPerPage)
            {
                flowLayoutPanelPagination.Visible = false;
                return;
            }

            flowLayoutPanelPagination.Controls.Clear();

            double total = numberOfTickets / ticketPerPage;

            int numberOfPages = (int)Math.Ceiling(total);

            Label lbl = new Label();
            lbl.Text = "Pages";
            flowLayoutPanelPagination.Controls.Add(lbl);

            for(int i = 1; i < numberOfPages + 1; i++)
            {
                Button btn = new Button();
                btn.Tag = i;
                btn.Text = i + "";
                btn.Click += GoToPage;
                flowLayoutPanelPagination.Controls.Add(btn);
            }
            flowLayoutPanelPagination.Visible = true;
        }

        private void GoToPage(object sender, EventArgs e)
        {
            int pageNumber = 0;
            Button btn = (Button)sender;
            btn.BackColor = Color.RebeccaPurple;
            if(int.TryParse(btn.Text, out pageNumber))
            {
                FilterTickets(pageNumber);
            }
        }

        private void FilterTickets(int page = 0)
        {
            TicketRequest tRequest = TicketService.FilterTickets(txtTitleSearch.Text, SelectedRadioStatus, page);
            DisplayTickets(tRequest.ListOfTickets);
            LoadPagination(TicketPerPage, tRequest.TotalCountOfTickets);
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
            if (btnEditPending.Checked)
            {
                ticketStatus = TicketStatus.Pending;
            }
            if (btnEditResolved.Checked)
            {
                ticketStatus = TicketStatus.Resolved;
            }

            TicketService.EditTicket(EditedTicket.Id, txtEditTitle.Text, txtEditNote.Text, ticketStatus);
            MessageBox.Show("Ticket is edited");
            groupBoxEditTicket.Visible = false;
            FilterTickets();
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            groupBoxEditTicket.Visible = false;
        }

        private void btnRunFilters_Click(object sender, EventArgs e)
        {
            FilterTickets();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
