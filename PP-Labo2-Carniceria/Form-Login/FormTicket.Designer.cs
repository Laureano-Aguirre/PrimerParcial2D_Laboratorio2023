namespace Form_Login
{
    partial class FormTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTicket));
            this.rtb_TicketMostrar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtb_TicketMostrar
            // 
            this.rtb_TicketMostrar.Location = new System.Drawing.Point(12, 12);
            this.rtb_TicketMostrar.Name = "rtb_TicketMostrar";
            this.rtb_TicketMostrar.Size = new System.Drawing.Size(348, 396);
            this.rtb_TicketMostrar.TabIndex = 0;
            this.rtb_TicketMostrar.Text = "";
            // 
            // FormTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(437, 471);
            this.Controls.Add(this.rtb_TicketMostrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTicket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.FormTicket_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtb_TicketMostrar;
    }
}