namespace TicketApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddTicket = new Button();
            btnOpenTickets = new RadioButton();
            btnPendingTickets = new RadioButton();
            btnResolvedTickets = new RadioButton();
            groupBoxStatusTickets = new GroupBox();
            flowLayoutPanelTickets = new FlowLayoutPanel();
            txtTitle = new TextBox();
            txtContactName = new TextBox();
            lblTitle = new Label();
            lblContact = new Label();
            lblNote = new Label();
            txtNote = new RichTextBox();
            groupBoxAddTicket = new GroupBox();
            btnCancelTicket = new Button();
            btnSaveNewTicket = new Button();
            groupBoxStatusTickets.SuspendLayout();
            groupBoxAddTicket.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddTicket
            // 
            btnAddTicket.Location = new Point(794, 32);
            btnAddTicket.Margin = new Padding(3, 4, 3, 4);
            btnAddTicket.Name = "btnAddTicket";
            btnAddTicket.Size = new Size(86, 31);
            btnAddTicket.TabIndex = 0;
            btnAddTicket.Text = "Add ticket";
            btnAddTicket.UseVisualStyleBackColor = true;
            btnAddTicket.Click += btnAddTicket_Click;
            // 
            // btnOpenTickets
            // 
            btnOpenTickets.AutoSize = true;
            btnOpenTickets.Checked = true;
            btnOpenTickets.Location = new Point(7, 29);
            btnOpenTickets.Margin = new Padding(3, 4, 3, 4);
            btnOpenTickets.Name = "btnOpenTickets";
            btnOpenTickets.Size = new Size(111, 24);
            btnOpenTickets.TabIndex = 2;
            btnOpenTickets.TabStop = true;
            btnOpenTickets.Text = "OpenTickets";
            btnOpenTickets.UseVisualStyleBackColor = true;
            btnOpenTickets.CheckedChanged += btnOpenTickets_CheckedChanged;
            // 
            // btnPendingTickets
            // 
            btnPendingTickets.AutoSize = true;
            btnPendingTickets.Location = new Point(7, 63);
            btnPendingTickets.Margin = new Padding(3, 4, 3, 4);
            btnPendingTickets.Name = "btnPendingTickets";
            btnPendingTickets.Size = new Size(132, 24);
            btnPendingTickets.TabIndex = 3;
            btnPendingTickets.Text = "Pending Tickets";
            btnPendingTickets.UseVisualStyleBackColor = true;
            btnPendingTickets.CheckedChanged += btnPendingTickets_CheckedChanged;
            // 
            // btnResolvedTickets
            // 
            btnResolvedTickets.AutoSize = true;
            btnResolvedTickets.Location = new Point(7, 100);
            btnResolvedTickets.Margin = new Padding(3, 4, 3, 4);
            btnResolvedTickets.Name = "btnResolvedTickets";
            btnResolvedTickets.Size = new Size(139, 24);
            btnResolvedTickets.TabIndex = 4;
            btnResolvedTickets.Text = "Resolved Tickets";
            btnResolvedTickets.UseVisualStyleBackColor = true;
            btnResolvedTickets.CheckedChanged += btnResolvedTickets_CheckedChanged;
            // 
            // groupBoxStatusTickets
            // 
            groupBoxStatusTickets.Controls.Add(btnOpenTickets);
            groupBoxStatusTickets.Controls.Add(btnResolvedTickets);
            groupBoxStatusTickets.Controls.Add(btnPendingTickets);
            groupBoxStatusTickets.Location = new Point(14, 115);
            groupBoxStatusTickets.Margin = new Padding(3, 4, 3, 4);
            groupBoxStatusTickets.Name = "groupBoxStatusTickets";
            groupBoxStatusTickets.Padding = new Padding(3, 4, 3, 4);
            groupBoxStatusTickets.Size = new Size(229, 133);
            groupBoxStatusTickets.TabIndex = 5;
            groupBoxStatusTickets.TabStop = false;
            groupBoxStatusTickets.Text = "Select status of tickets";
            // 
            // flowLayoutPanelTickets
            // 
            flowLayoutPanelTickets.Location = new Point(21, 328);
            flowLayoutPanelTickets.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelTickets.Name = "flowLayoutPanelTickets";
            flowLayoutPanelTickets.Size = new Size(859, 243);
            flowLayoutPanelTickets.TabIndex = 6;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(6, 60);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 7;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(315, 60);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(125, 27);
            txtContactName.TabIndex = 10;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(6, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Title";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(336, 37);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(104, 20);
            lblContact.TabIndex = 12;
            lblContact.Text = "Contact Name";
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(6, 104);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(42, 20);
            lblNote.TabIndex = 13;
            lblNote.Text = "Note";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(6, 127);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(434, 70);
            txtNote.TabIndex = 14;
            txtNote.Text = "";
            // 
            // groupBoxAddTicket
            // 
            groupBoxAddTicket.Controls.Add(btnCancelTicket);
            groupBoxAddTicket.Controls.Add(btnSaveNewTicket);
            groupBoxAddTicket.Controls.Add(lblContact);
            groupBoxAddTicket.Controls.Add(lblNote);
            groupBoxAddTicket.Controls.Add(txtContactName);
            groupBoxAddTicket.Controls.Add(lblTitle);
            groupBoxAddTicket.Controls.Add(txtTitle);
            groupBoxAddTicket.Controls.Add(txtNote);
            groupBoxAddTicket.Location = new Point(423, 90);
            groupBoxAddTicket.Name = "groupBoxAddTicket";
            groupBoxAddTicket.Size = new Size(457, 231);
            groupBoxAddTicket.TabIndex = 0;
            groupBoxAddTicket.TabStop = false;
            groupBoxAddTicket.Visible = false;
            // 
            // btnCancelTicket
            // 
            btnCancelTicket.Location = new Point(346, 196);
            btnCancelTicket.Name = "btnCancelTicket";
            btnCancelTicket.Size = new Size(94, 29);
            btnCancelTicket.TabIndex = 16;
            btnCancelTicket.Text = "Cancel";
            btnCancelTicket.UseVisualStyleBackColor = true;
            btnCancelTicket.Click += btnCancelTicket_Click;
            // 
            // btnSaveNewTicket
            // 
            btnSaveNewTicket.Location = new Point(14, 200);
            btnSaveNewTicket.Name = "btnSaveNewTicket";
            btnSaveNewTicket.Size = new Size(94, 29);
            btnSaveNewTicket.TabIndex = 15;
            btnSaveNewTicket.Text = "Save";
            btnSaveNewTicket.UseVisualStyleBackColor = true;
            btnSaveNewTicket.Click += btnSaveNewTicket_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBoxAddTicket);
            Controls.Add(flowLayoutPanelTickets);
            Controls.Add(groupBoxStatusTickets);
            Controls.Add(btnAddTicket);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxStatusTickets.ResumeLayout(false);
            groupBoxStatusTickets.PerformLayout();
            groupBoxAddTicket.ResumeLayout(false);
            groupBoxAddTicket.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddTicket;
        private RadioButton btnOpenTickets;
        private RadioButton btnPendingTickets;
        private RadioButton btnResolvedTickets;
        private GroupBox groupBoxStatusTickets;
        private FlowLayoutPanel flowLayoutPanelTickets;
        private TextBox txtTitle;
        private TextBox txtContactName;
        private Label lblTitle;
        private Label lblContact;
        private Label lblNote;
        private RichTextBox txtNote;
        private GroupBox groupBoxAddTicket;
        private Button btnSaveNewTicket;
        private Button btnCancelTicket;
    }
}
