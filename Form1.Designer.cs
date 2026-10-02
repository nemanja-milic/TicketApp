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
            groupBoxEditTicket = new GroupBox();
            btnEditCancel = new Button();
            btnEditSave = new Button();
            groupBoxEdit = new GroupBox();
            btnEditResolved = new RadioButton();
            btnEditOpen = new RadioButton();
            btnEditPending = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            txtEditTitle = new TextBox();
            txtEditNote = new RichTextBox();
            groupBoxStatusTickets.SuspendLayout();
            groupBoxAddTicket.SuspendLayout();
            groupBoxEditTicket.SuspendLayout();
            groupBoxEdit.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddTicket
            // 
            btnAddTicket.Location = new Point(695, 24);
            btnAddTicket.Name = "btnAddTicket";
            btnAddTicket.Size = new Size(75, 23);
            btnAddTicket.TabIndex = 0;
            btnAddTicket.Text = "Add ticket";
            btnAddTicket.UseVisualStyleBackColor = true;
            btnAddTicket.Click += btnAddTicket_Click;
            // 
            // btnOpenTickets
            // 
            btnOpenTickets.AutoSize = true;
            btnOpenTickets.Checked = true;
            btnOpenTickets.Location = new Point(6, 22);
            btnOpenTickets.Name = "btnOpenTickets";
            btnOpenTickets.Size = new Size(91, 19);
            btnOpenTickets.TabIndex = 2;
            btnOpenTickets.TabStop = true;
            btnOpenTickets.Text = "OpenTickets";
            btnOpenTickets.UseVisualStyleBackColor = true;
            btnOpenTickets.CheckedChanged += btnOpenTickets_CheckedChanged;
            // 
            // btnPendingTickets
            // 
            btnPendingTickets.AutoSize = true;
            btnPendingTickets.Location = new Point(6, 47);
            btnPendingTickets.Name = "btnPendingTickets";
            btnPendingTickets.Size = new Size(109, 19);
            btnPendingTickets.TabIndex = 3;
            btnPendingTickets.Text = "Pending Tickets";
            btnPendingTickets.UseVisualStyleBackColor = true;
            btnPendingTickets.CheckedChanged += btnPendingTickets_CheckedChanged;
            // 
            // btnResolvedTickets
            // 
            btnResolvedTickets.AutoSize = true;
            btnResolvedTickets.Location = new Point(6, 75);
            btnResolvedTickets.Name = "btnResolvedTickets";
            btnResolvedTickets.Size = new Size(112, 19);
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
            groupBoxStatusTickets.Location = new Point(12, 86);
            groupBoxStatusTickets.Name = "groupBoxStatusTickets";
            groupBoxStatusTickets.Size = new Size(200, 100);
            groupBoxStatusTickets.TabIndex = 5;
            groupBoxStatusTickets.TabStop = false;
            groupBoxStatusTickets.Text = "Select status of tickets";
            // 
            // flowLayoutPanelTickets
            // 
            flowLayoutPanelTickets.Location = new Point(18, 246);
            flowLayoutPanelTickets.Name = "flowLayoutPanelTickets";
            flowLayoutPanelTickets.Size = new Size(752, 182);
            flowLayoutPanelTickets.TabIndex = 6;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(5, 45);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(110, 23);
            txtTitle.TabIndex = 7;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(276, 45);
            txtContactName.Margin = new Padding(3, 2, 3, 2);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(110, 23);
            txtContactName.TabIndex = 10;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(5, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(30, 15);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Title";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(294, 28);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(84, 15);
            lblContact.TabIndex = 12;
            lblContact.Text = "Contact Name";
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(5, 78);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(33, 15);
            lblNote.TabIndex = 13;
            lblNote.Text = "Note";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(5, 95);
            txtNote.Margin = new Padding(3, 2, 3, 2);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(380, 54);
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
            groupBoxAddTicket.Location = new Point(370, 68);
            groupBoxAddTicket.Margin = new Padding(3, 2, 3, 2);
            groupBoxAddTicket.Name = "groupBoxAddTicket";
            groupBoxAddTicket.Padding = new Padding(3, 2, 3, 2);
            groupBoxAddTicket.Size = new Size(400, 173);
            groupBoxAddTicket.TabIndex = 0;
            groupBoxAddTicket.TabStop = false;
            groupBoxAddTicket.Visible = false;
            // 
            // btnCancelTicket
            // 
            btnCancelTicket.Location = new Point(303, 150);
            btnCancelTicket.Margin = new Padding(3, 2, 3, 2);
            btnCancelTicket.Name = "btnCancelTicket";
            btnCancelTicket.Size = new Size(82, 22);
            btnCancelTicket.TabIndex = 16;
            btnCancelTicket.Text = "Cancel";
            btnCancelTicket.UseVisualStyleBackColor = true;
            btnCancelTicket.Click += btnCancelTicket_Click;
            // 
            // btnSaveNewTicket
            // 
            btnSaveNewTicket.Location = new Point(12, 150);
            btnSaveNewTicket.Margin = new Padding(3, 2, 3, 2);
            btnSaveNewTicket.Name = "btnSaveNewTicket";
            btnSaveNewTicket.Size = new Size(82, 22);
            btnSaveNewTicket.TabIndex = 15;
            btnSaveNewTicket.Text = "Save";
            btnSaveNewTicket.UseVisualStyleBackColor = true;
            btnSaveNewTicket.Click += btnSaveNewTicket_Click;
            // 
            // groupBoxEditTicket
            // 
            groupBoxEditTicket.Controls.Add(btnEditCancel);
            groupBoxEditTicket.Controls.Add(btnEditSave);
            groupBoxEditTicket.Controls.Add(groupBoxEdit);
            groupBoxEditTicket.Controls.Add(label2);
            groupBoxEditTicket.Controls.Add(label3);
            groupBoxEditTicket.Controls.Add(txtEditTitle);
            groupBoxEditTicket.Controls.Add(txtEditNote);
            groupBoxEditTicket.Location = new Point(267, 67);
            groupBoxEditTicket.Margin = new Padding(3, 2, 3, 2);
            groupBoxEditTicket.Name = "groupBoxEditTicket";
            groupBoxEditTicket.Padding = new Padding(3, 2, 3, 2);
            groupBoxEditTicket.Size = new Size(400, 173);
            groupBoxEditTicket.TabIndex = 17;
            groupBoxEditTicket.TabStop = false;
            groupBoxEditTicket.Visible = false;
            // 
            // btnEditCancel
            // 
            btnEditCancel.Location = new Point(310, 151);
            btnEditCancel.Name = "btnEditCancel";
            btnEditCancel.Size = new Size(75, 23);
            btnEditCancel.TabIndex = 22;
            btnEditCancel.Text = "Cancel";
            btnEditCancel.UseVisualStyleBackColor = true;
            // 
            // btnEditSave
            // 
            btnEditSave.Location = new Point(10, 151);
            btnEditSave.Name = "btnEditSave";
            btnEditSave.Size = new Size(75, 23);
            btnEditSave.TabIndex = 21;
            btnEditSave.Text = "Save";
            btnEditSave.UseVisualStyleBackColor = true;
            btnEditSave.Click += btnEditSave_Click;
            // 
            // groupBoxEdit
            // 
            groupBoxEdit.Controls.Add(btnEditResolved);
            groupBoxEdit.Controls.Add(btnEditOpen);
            groupBoxEdit.Controls.Add(btnEditPending);
            groupBoxEdit.Location = new Point(270, 1);
            groupBoxEdit.Name = "groupBoxEdit";
            groupBoxEdit.Size = new Size(115, 89);
            groupBoxEdit.TabIndex = 20;
            groupBoxEdit.TabStop = false;
            // 
            // btnEditResolved
            // 
            btnEditResolved.AutoSize = true;
            btnEditResolved.Location = new Point(16, 72);
            btnEditResolved.Name = "btnEditResolved";
            btnEditResolved.Size = new Size(72, 19);
            btnEditResolved.TabIndex = 19;
            btnEditResolved.Text = "Resolved";
            btnEditResolved.UseVisualStyleBackColor = true;
            // 
            // btnEditOpen
            // 
            btnEditOpen.AutoSize = true;
            btnEditOpen.Location = new Point(16, 22);
            btnEditOpen.Name = "btnEditOpen";
            btnEditOpen.Size = new Size(54, 19);
            btnEditOpen.TabIndex = 17;
            btnEditOpen.Text = "Open";
            btnEditOpen.UseVisualStyleBackColor = true;
            // 
            // btnEditPending
            // 
            btnEditPending.AutoSize = true;
            btnEditPending.Location = new Point(16, 47);
            btnEditPending.Name = "btnEditPending";
            btnEditPending.Size = new Size(69, 19);
            btnEditPending.TabIndex = 18;
            btnEditPending.Text = "Pending";
            btnEditPending.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 77);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 13;
            label2.Text = "Note";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 26);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 11;
            label3.Text = "Title";
            // 
            // txtEditTitle
            // 
            txtEditTitle.Location = new Point(5, 45);
            txtEditTitle.Margin = new Padding(3, 2, 3, 2);
            txtEditTitle.Name = "txtEditTitle";
            txtEditTitle.Size = new Size(110, 23);
            txtEditTitle.TabIndex = 7;
            // 
            // txtEditNote
            // 
            txtEditNote.Location = new Point(5, 95);
            txtEditNote.Margin = new Padding(3, 2, 3, 2);
            txtEditNote.Name = "txtEditNote";
            txtEditNote.Size = new Size(380, 54);
            txtEditNote.TabIndex = 14;
            txtEditNote.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxEditTicket);
            Controls.Add(groupBoxAddTicket);
            Controls.Add(flowLayoutPanelTickets);
            Controls.Add(groupBoxStatusTickets);
            Controls.Add(btnAddTicket);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxStatusTickets.ResumeLayout(false);
            groupBoxStatusTickets.PerformLayout();
            groupBoxAddTicket.ResumeLayout(false);
            groupBoxAddTicket.PerformLayout();
            groupBoxEditTicket.ResumeLayout(false);
            groupBoxEditTicket.PerformLayout();
            groupBoxEdit.ResumeLayout(false);
            groupBoxEdit.PerformLayout();
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
        private GroupBox groupBoxEditTicket;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private RichTextBox txtEditNote;
        private GroupBox groupBoxEdit;
        private RadioButton btnEditResolved;
        private RadioButton btnEditOpen;
        private RadioButton btnEditPending;
        private TextBox txtEditTitle;
        private Button btnEditCancel;
        private Button btnEditSave;
    }
}
