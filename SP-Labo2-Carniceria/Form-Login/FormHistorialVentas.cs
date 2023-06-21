using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Login
{
    public partial class FormHistorialVentas : Form
    {
        public FormHistorialVentas()
        {
            InitializeComponent();
        }

        private void FormHistorialVentas_Load(object sender, EventArgs e)
        {
            rtb_HistorialVentas.AppendText(Cliente.MostrarVentas());
        }

        private void btn_HistorialVentasAtras_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea ir para atras?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_HistorialVentasGenerarTxt_Click(object sender, EventArgs e)
        {
            Archivos.Escribir();
        }

        private void btn_HistorialVentasSerializarXml_Click(object sender, EventArgs e)
        {
            Serializadora<Carne>.EscribirXml(Carne.ListaCarnes);
        }

        private void btn_HistorialVentasDeserealizarXml_Click(object sender, EventArgs e)
        {
            List<Carne> carnes = new List<Carne>();

            carnes = Serializadora<Carne>.LeerXml();
            foreach (Carne carne in carnes)
            {
                MessageBox.Show($"{carne.TipoDeCarne} {carne.Kilos} {carne.PrecioPorKilo} {carne.Stock}");
            }

        }

        private void btn_HistorialVentaTipoDePagoXml_Click(object sender, EventArgs e)
        {

            List<ETipoDePago> listaDePagos = new List<ETipoDePago>();

            listaDePagos.Add(ETipoDePago.Credito);
            listaDePagos.Add(ETipoDePago.Debito);
            listaDePagos.Add(ETipoDePago.Efectivo);

            Serializadora<ETipoDePago>.EscribirXml(listaDePagos);
        }

        private void btn_HistorialVentaPagoDeserializarXml_Click(object sender, EventArgs e)
        {
            List<ETipoDePago> listaDePagos = new List<ETipoDePago>();

            listaDePagos = Serializadora<ETipoDePago>.LeerXml();
            foreach (ETipoDePago tipo in listaDePagos)
            {
                MessageBox.Show($"{tipo.ToString()}");
            }
        }
    }
}
