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
            txtTitleSearch = new TextBox();
            btnRunFilters = new Button();
            lblFilterTitle = new Label();
            textBox1 = new TextBox();
            lblContactName = new Label();
            flowLayoutPanelPagination = new FlowLayoutPanel();
            groupBoxStatusTickets.SuspendLayout();
            groupBoxAddTicket.SuspendLayout();
            groupBoxEditTicket.SuspendLayout();
            groupBoxEdit.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddTicket
            // 
            btnAddTicket.Location = new Point(1023, 13);
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
            groupBoxStatusTickets.Location = new Point(28, 77);
            groupBoxStatusTickets.Margin = new Padding(3, 4, 3, 4);
            groupBoxStatusTickets.Name = "groupBoxStatusTickets";
            groupBoxStatusTickets.Padding = new Padding(3, 4, 3, 4);
            groupBoxStatusTickets.Size = new Size(229, 136);
            groupBoxStatusTickets.TabIndex = 5;
            groupBoxStatusTickets.TabStop = false;
            groupBoxStatusTickets.Text = "Select status of tickets";
            // 
            // flowLayoutPanelTickets
            // 
            flowLayoutPanelTickets.Location = new Point(12, 414);
            flowLayoutPanelTickets.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelTickets.Name = "flowLayoutPanelTickets";
            flowLayoutPanelTickets.Size = new Size(1097, 306);
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
            txtNote.Size = new Size(434, 71);
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
            groupBoxAddTicket.Location = new Point(652, 83);
            groupBoxAddTicket.Name = "groupBoxAddTicket";
            groupBoxAddTicket.Size = new Size(457, 231);
            groupBoxAddTicket.TabIndex = 0;
            groupBoxAddTicket.TabStop = false;
            groupBoxAddTicket.Visible = false;
            // 
            // btnCancelTicket
            // 
            btnCancelTicket.Location = new Point(346, 200);
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
            // groupBoxEditTicket
            // 
            groupBoxEditTicket.Controls.Add(btnEditCancel);
            groupBoxEditTicket.Controls.Add(btnEditSave);
            groupBoxEditTicket.Controls.Add(groupBoxEdit);
            groupBoxEditTicket.Controls.Add(label2);
            groupBoxEditTicket.Controls.Add(label3);
            groupBoxEditTicket.Controls.Add(txtEditTitle);
            groupBoxEditTicket.Controls.Add(txtEditNote);
            groupBoxEditTicket.Location = new Point(535, 90);
            groupBoxEditTicket.Name = "groupBoxEditTicket";
            groupBoxEditTicket.Size = new Size(457, 231);
            groupBoxEditTicket.TabIndex = 17;
            groupBoxEditTicket.TabStop = false;
            groupBoxEditTicket.Visible = false;
            // 
            // btnEditCancel
            // 
            btnEditCancel.Location = new Point(354, 201);
            btnEditCancel.Margin = new Padding(3, 4, 3, 4);
            btnEditCancel.Name = "btnEditCancel";
            btnEditCancel.Size = new Size(86, 31);
            btnEditCancel.TabIndex = 22;
            btnEditCancel.Text = "Cancel";
            btnEditCancel.UseVisualStyleBackColor = true;
            btnEditCancel.Click += btnEditCancel_Click;
            // 
            // btnEditSave
            // 
            btnEditSave.Location = new Point(11, 201);
            btnEditSave.Margin = new Padding(3, 4, 3, 4);
            btnEditSave.Name = "btnEditSave";
            btnEditSave.Size = new Size(86, 31);
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
            groupBoxEdit.Location = new Point(309, 1);
            groupBoxEdit.Margin = new Padding(3, 4, 3, 4);
            groupBoxEdit.Name = "groupBoxEdit";
            groupBoxEdit.Padding = new Padding(3, 4, 3, 4);
            groupBoxEdit.Size = new Size(131, 119);
            groupBoxEdit.TabIndex = 20;
            groupBoxEdit.TabStop = false;
            // 
            // btnEditResolved
            // 
            btnEditResolved.AutoSize = true;
            btnEditResolved.Location = new Point(18, 96);
            btnEditResolved.Margin = new Padding(3, 4, 3, 4);
            btnEditResolved.Name = "btnEditResolved";
            btnEditResolved.Size = new Size(90, 24);
            btnEditResolved.TabIndex = 19;
            btnEditResolved.Text = "Resolved";
            btnEditResolved.UseVisualStyleBackColor = true;
            // 
            // btnEditOpen
            // 
            btnEditOpen.AutoSize = true;
            btnEditOpen.Location = new Point(18, 29);
            btnEditOpen.Margin = new Padding(3, 4, 3, 4);
            btnEditOpen.Name = "btnEditOpen";
            btnEditOpen.Size = new Size(66, 24);
            btnEditOpen.TabIndex = 17;
            btnEditOpen.Text = "Open";
            btnEditOpen.UseVisualStyleBackColor = true;
            // 
            // btnEditPending
            // 
            btnEditPending.AutoSize = true;
            btnEditPending.Location = new Point(18, 63);
            btnEditPending.Margin = new Padding(3, 4, 3, 4);
            btnEditPending.Name = "btnEditPending";
            btnEditPending.Size = new Size(83, 24);
            btnEditPending.TabIndex = 18;
            btnEditPending.Text = "Pending";
            btnEditPending.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 103);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 13;
            label2.Text = "Note";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 35);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 11;
            label3.Text = "Title";
            // 
            // txtEditTitle
            // 
            txtEditTitle.Location = new Point(6, 60);
            txtEditTitle.Name = "txtEditTitle";
            txtEditTitle.Size = new Size(125, 27);
            txtEditTitle.TabIndex = 7;
            // 
            // txtEditNote
            // 
            txtEditNote.Location = new Point(6, 127);
            txtEditNote.Name = "txtEditNote";
            txtEditNote.Size = new Size(434, 71);
            txtEditNote.TabIndex = 14;
            txtEditNote.Text = "";
            // 
            // txtTitleSearch
            // 
            txtTitleSearch.Location = new Point(32, 36);
            txtTitleSearch.Name = "txtTitleSearch";
            txtTitleSearch.Size = new Size(125, 27);
            txtTitleSearch.TabIndex = 18;
            // 
            // btnRunFilters
            // 
            btnRunFilters.Location = new Point(28, 283);
            btnRunFilters.Name = "btnRunFilters";
            btnRunFilters.Size = new Size(129, 27);
            btnRunFilters.TabIndex = 19;
            btnRunFilters.Text = "Filter Tickets";
            btnRunFilters.UseVisualStyleBackColor = true;
            btnRunFilters.Click += btnRunFilters_Click;
            // 
            // lblFilterTitle
            // 
            lblFilterTitle.AutoSize = true;
            lblFilterTitle.Location = new Point(35, 13);
            lblFilterTitle.Name = "lblFilterTitle";
            lblFilterTitle.Size = new Size(38, 20);
            lblFilterTitle.TabIndex = 20;
            lblFilterTitle.Text = "Title";
            lblFilterTitle.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 21;
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Location = new Point(182, 13);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(101, 20);
            lblContactName.TabIndex = 22;
            lblContactName.Text = "Contact name";
            // 
            // flowLayoutPanelPagination
            // 
            flowLayoutPanelPagination.Location = new Point(435, 343);
            flowLayoutPanelPagination.Name = "flowLayoutPanelPagination";
            flowLayoutPanelPagination.Size = new Size(674, 64);
            flowLayoutPanelPagination.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 723);
            Controls.Add(flowLayoutPanelPagination);
            Controls.Add(lblContactName);
            Controls.Add(textBox1);
            Controls.Add(lblFilterTitle);
            Controls.Add(btnRunFilters);
            Controls.Add(txtTitleSearch);
            Controls.Add(groupBoxEditTicket);
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
            groupBoxEditTicket.ResumeLayout(false);
            groupBoxEditTicket.PerformLayout();
            groupBoxEdit.ResumeLayout(false);
            groupBoxEdit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button button2;
        private Label lblContactName;
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
        private TextBox txtTitleSearch;
        private Button btnRunFilters;
        private Label lblFilterTitle;
        private FlowLayoutPanel flowLayoutPanelPagination;
    }
}
