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
        private Cliente cAux;
        private Tarjeta tAux;
        private bool usoTarjeta = false;
        private decimal recarga;
        public FormTicket(Cliente cliente)
        {
            cAux = cliente;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            MostrarRichTextBox();
        }

        /// <summary>
        /// Agrupa todo el codigo dentro de este metodo, para no cargar tanto el LOAD.s
        /// </summary>
        private void MostrarRichTextBox()
        {
            rtb_TicketMostrar.AppendText("CARNICERIA LA BOCA\n");
            rtb_TicketMostrar.Select(0, "CARNICERIA LA BOCA\n".Length);
            rtb_TicketMostrar.SelectionAlignment = HorizontalAlignment.Center;
            rtb_TicketMostrar.AppendText("\n");

            rtb_TicketMostrar.AppendText($"{cAux.MostrarPersona(cAux)}\n\n");

            foreach (Tarjeta tarjeta in Tarjeta.Tarjetas)
            {
                if (tarjeta != null)
                {
                    tAux = tarjeta;
                    rtb_TicketMostrar.AppendText("DATOS DE LA TARJETA\n");
                    rtb_TicketMostrar.Select(rtb_TicketMostrar.TextLength - 1, "DATOS DE LA TARJETA\n".Length);
                    rtb_TicketMostrar.SelectionAlignment = HorizontalAlignment.Center;
                    rtb_TicketMostrar.AppendText($"{tarjeta.MostrarDatos(tarjeta.Nombre, tarjeta.Numero)}\n");
                    usoTarjeta = true;
                }
            }
            rtb_TicketMostrar.AppendText("DETALLES DE LA COMPRA\n");
            rtb_TicketMostrar.Select(rtb_TicketMostrar.TextLength - 1, "DETALLES DE LA COMPRA\n".Length);
            rtb_TicketMostrar.SelectionAlignment = HorizontalAlignment.Center;
            rtb_TicketMostrar.AppendText($"{Carne.MostrarCompras()}\n");
            rtb_TicketMostrar.AppendText($"SUBTOTAL: {cAux.Gasto}\n");
            rtb_TicketMostrar.Select(rtb_TicketMostrar.TextLength - 1, $"SUBTOTAL: {cAux.Gasto}\n".Length);
            rtb_TicketMostrar.SelectionAlignment = HorizontalAlignment.Right;
            if (usoTarjeta)
            {
                recarga = tAux.AgregarRecarga(cAux.Gasto);
                rtb_TicketMostrar.AppendText($"RECARGA: {recarga}\n");
                rtb_TicketMostrar.Select(rtb_TicketMostrar.TextLength - 1, $"RECARGA: {recarga}\n".Length);
                rtb_TicketMostrar.SelectionAlignment = HorizontalAlignment.Right;
                rtb_TicketMostrar.AppendText($"TOTAL: {recarga + cAux.Gasto}\n");
                rtb_TicketMostrar.Select(rtb_TicketMostrar.TextLength - 1, $"TOTAL: {recarga + cAux.Gasto}\n".Length);
                rtb_TicketMostrar.SelectionAlignment = HorizontalAlignment.Right;
            }
            else
            {
                rtb_TicketMostrar.AppendText($"TOTAL: {cAux.Gasto}\n");
                rtb_TicketMostrar.Select(rtb_TicketMostrar.TextLength - 1, $"TOTAL: {cAux.Gasto}\n".Length);
                rtb_TicketMostrar.SelectionAlignment = HorizontalAlignment.Right;
            }
        }
    }
}
