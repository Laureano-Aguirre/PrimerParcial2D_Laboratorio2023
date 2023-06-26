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
    public partial class FormVerClientes : Form
    {
        public FormVerClientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FormVerClientes_Load(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                clientes = ConexionDB.LeerClientes();
                rtb_VerClientes.AppendText(Cliente.MostrarClientes(clientes));
            }
            catch (ExcepcionPropia ex)
            {
                MessageBox.Show($"Error al leer los clientes. Por favor, intentelo mas tarde.\n Mensaje del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void btn_VerClientesAtras_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea ir para atras?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
