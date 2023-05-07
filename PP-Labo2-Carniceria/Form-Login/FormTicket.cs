using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Form_Login
{
    public partial class FormTicket : Form
    {
        public FormTicket()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            rtb_TicketMostrar.Text = Carne.MostrarCompras();
        }
    }
}
