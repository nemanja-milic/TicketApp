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
            btnShowAllTickets = new Button();
            btnOpenTickets = new RadioButton();
            btnPendingTickets = new RadioButton();
            btnResolvedTickets = new RadioButton();
            groupBoxStatusTickets = new GroupBox();
            flowLayoutPanelTickets = new FlowLayoutPanel();
            groupBoxStatusTickets.SuspendLayout();
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
            // 
            // btnShowAllTickets
            // 
            btnShowAllTickets.Location = new Point(12, 24);
            btnShowAllTickets.Name = "btnShowAllTickets";
            btnShowAllTickets.Size = new Size(137, 23);
            btnShowAllTickets.TabIndex = 1;
            btnShowAllTickets.Text = "Show All tickets";
            btnShowAllTickets.UseVisualStyleBackColor = true;
            btnShowAllTickets.Click += btnShowAllTickets_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelTickets);
            Controls.Add(groupBoxStatusTickets);
            Controls.Add(btnShowAllTickets);
            Controls.Add(btnAddTicket);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxStatusTickets.ResumeLayout(false);
            groupBoxStatusTickets.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddTicket;
        private Button btnShowAllTickets;
        private RadioButton btnOpenTickets;
        private RadioButton btnPendingTickets;
        private RadioButton btnResolvedTickets;
        private GroupBox groupBoxStatusTickets;
        private FlowLayoutPanel flowLayoutPanelTickets;
    }
}
