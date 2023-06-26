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
            //rtb_HistorialVentas.AppendText(Cliente.MostrarVentas());
            Venta venta = new Venta();

            rtb_HistorialVentas.AppendText(venta.Mostrar());
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
            try
            {
                Archivos.Escribir();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al querer escribir las ventas en el archivo. Por favor, intentelo mas tarde \n Mensaje del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_HistorialVentasSerializarXml_Click(object sender, EventArgs e)
        {
            try
            {
                Serializadora<Carne>.EscribirXml(Carne.ListaCarnes);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al querer serializar. Por favor, intentelo ams tarde. \n Mensaje del erorr: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_HistorialVentasDeserealizarXml_Click(object sender, EventArgs e)
        {
            List<Carne> carnes = new List<Carne>();
            try
            {
                carnes = Serializadora<Carne>.LeerXml();
                foreach (Carne carne in carnes)
                {
                    MessageBox.Show($"{carne.TipoDeCarne} {carne.Kilos} {carne.PrecioPorKilo} {carne.Stock}");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al querer deserializar. Por favor, intentelo ams tarde. \n Mensaje del erorr: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_HistorialVentaTipoDePagoXml_Click(object sender, EventArgs e)
        {

            List<ETipoDePago> listaDePagos = new List<ETipoDePago>();

            listaDePagos.Add(ETipoDePago.Credito);
            listaDePagos.Add(ETipoDePago.Debito);
            listaDePagos.Add(ETipoDePago.Efectivo);

            try
            {
                Serializadora<ETipoDePago>.EscribirXml(listaDePagos);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al querer serializar. Por favor, intentelo ams tarde. \n Mensaje del erorr: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_HistorialVentaPagoDeserializarXml_Click(object sender, EventArgs e)
        {
            List<ETipoDePago> listaDePagos = new List<ETipoDePago>();

            try
            {
                listaDePagos = Serializadora<ETipoDePago>.LeerXml();
                foreach (ETipoDePago tipo in listaDePagos)
                {
                    MessageBox.Show($"{tipo.ToString()}");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al querer serializar. Por favor, intentelo ams tarde. \n Mensaje del erorr: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_HistorialVentasSerializarJson_Click(object sender, EventArgs e)
        {
            try
            {
                Serializadora<Carne>.EscribirJson(Carne.ListaCarnes);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al querer serializar. Por favor, intentelo ams tarde. \n Mensaje del erorr: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_HistorialVentasDeserealizarJson_Click(object sender, EventArgs e)
        {
            List<Carne> carnes = new List<Carne>();
            try
            {
                carnes = Serializadora<Carne>.LeerJson();
                foreach (Carne carne in carnes)
                {
                    MessageBox.Show($"{carne.TipoDeCarne} {carne.Kilos} {carne.PrecioPorKilo} {carne.Stock}");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al querer deserializar. Por favor, intentelo ams tarde. \n Mensaje del erorr: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_HistorialVentaTipoDePagoJson_Click(object sender, EventArgs e)
        {
            List<ETipoDePago> listaDePagos = new List<ETipoDePago>();

            listaDePagos.Add(ETipoDePago.Credito);
            listaDePagos.Add(ETipoDePago.Debito);
            listaDePagos.Add(ETipoDePago.Efectivo);

            try
            {
                Serializadora<ETipoDePago>.EscribirJson(listaDePagos);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al querer serializar. Por favor, intentelo ams tarde. \n Mensaje del erorr: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_HistorialVentaPagoDeserializarJson_Click(object sender, EventArgs e)
        {
            List<ETipoDePago> listaDePagos = new List<ETipoDePago>();

            try
            {
                listaDePagos = Serializadora<ETipoDePago>.LeerJson();
                foreach (ETipoDePago tipo in listaDePagos)
                {
                    MessageBox.Show($"{tipo.ToString()}");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al querer serializar. Por favor, intentelo ams tarde. \n Mensaje del erorr: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
