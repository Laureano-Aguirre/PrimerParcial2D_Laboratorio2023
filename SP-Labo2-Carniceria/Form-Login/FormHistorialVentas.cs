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
            rtb_HistorialVentas.AppendText(Cliente.MostrarCarritoCompras());
        }

        private void btn_HistorialVentasAtras_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea ir para atras?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
