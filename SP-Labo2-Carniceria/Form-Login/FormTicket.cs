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
        decimal costoCompra;
        public FormTicket(Cliente cliente, decimal costoFinal)
        {
            cAux = cliente;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            costoCompra = costoFinal;
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            MostrarRichTextBox(cAux);
        }

        /// <summary>
        /// Agrupa todo el codigo dentro de este metodo, para no cargar tanto el LOAD.s
        /// </summary>
        private void MostrarRichTextBox(Cliente cliente)
        {
            rtb_TicketMostrar.AppendText("CARNICERIA LA BOCA\n");
            rtb_TicketMostrar.Select(0, "CARNICERIA LA BOCA\n".Length);
            rtb_TicketMostrar.SelectionAlignment = HorizontalAlignment.Center;
            rtb_TicketMostrar.AppendText("--------------------------------------------------------------------\n");
            rtb_TicketMostrar.AppendText("DATOS DEL CLIENTE\n");
            rtb_TicketMostrar.Select(rtb_TicketMostrar.TextLength - "DATOS DEL CLIENTE\n".Length, "DATOS DEL CLIENTE\n".Length);
            rtb_TicketMostrar.SelectionAlignment = HorizontalAlignment.Center;
            rtb_TicketMostrar.AppendText($"{cAux.MostrarPersona(cAux)}\n");

            rtb_TicketMostrar.AppendText("--------------------------------------------------------------------\n");
            foreach (Tarjeta tarjeta in Tarjeta.Tarjetas)
            {
                if (tarjeta != null)
                {
                    tAux = tarjeta;
                    rtb_TicketMostrar.AppendText("DATOS DE LA TARJETA\n");
                    rtb_TicketMostrar.Select(rtb_TicketMostrar.TextLength - 1, "DATOS DE LA TARJETA\n".Length);
                    rtb_TicketMostrar.SelectionAlignment = HorizontalAlignment.Center;
                    rtb_TicketMostrar.AppendText($"{tarjeta.MostrarDatos(tarjeta.Nombre, tarjeta.Numero)}\n");
                    rtb_TicketMostrar.AppendText("--------------------------------------------------------------------\n");
                    usoTarjeta = true;
                }
            }

            List<Carne> carnes = cliente.ListaDeCompras.Distinct().ToList(); // Eliminar duplicados de la lista de compras

            rtb_TicketMostrar.AppendText("DETALLES DE LA COMPRA\n");
            rtb_TicketMostrar.Select(rtb_TicketMostrar.TextLength - 1, "DETALLES DE LA COMPRA\n".Length);
            rtb_TicketMostrar.SelectionAlignment = HorizontalAlignment.Center;

            foreach (Carne carne in carnes) // Mostrar las carnes sin duplicados
            {
                rtb_TicketMostrar.AppendText($"-{carne.Kilos.ToString()}KG {carne.TipoDeCarne}\n");
            }

            rtb_TicketMostrar.AppendText("--------------------------------------------------------------------\n");
            rtb_TicketMostrar.AppendText($"SUBTOTAL: {costoCompra}\n");
            rtb_TicketMostrar.Select(rtb_TicketMostrar.TextLength - 1, $"SUBTOTAL: {costoCompra}\n".Length);
            rtb_TicketMostrar.SelectionAlignment = HorizontalAlignment.Right;

            if (usoTarjeta)
            {
                recarga = tAux.AgregarRecarga(costoCompra);
                rtb_TicketMostrar.AppendText($"RECARGA: {recarga}\n");
                rtb_TicketMostrar.Select(rtb_TicketMostrar.TextLength - 1, $"RECARGA: {recarga}\n".Length);
                rtb_TicketMostrar.SelectionAlignment = HorizontalAlignment.Right;
                rtb_TicketMostrar.AppendText($"TOTAL: {recarga + costoCompra}\n");
                rtb_TicketMostrar.Select(rtb_TicketMostrar.TextLength - 1, $"TOTAL: {recarga + costoCompra}\n".Length);
                rtb_TicketMostrar.SelectionAlignment = HorizontalAlignment.Right;
            }
            else
            {
                rtb_TicketMostrar.AppendText($"TOTAL: {costoCompra}\n");
                rtb_TicketMostrar.Select(rtb_TicketMostrar.TextLength - 1, $"TOTAL: {costoCompra}\n".Length);
                rtb_TicketMostrar.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

            private void FormTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
