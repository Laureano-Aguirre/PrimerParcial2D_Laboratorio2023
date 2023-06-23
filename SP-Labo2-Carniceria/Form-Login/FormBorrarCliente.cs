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
    public partial class FormBorrarCliente : Form
    {
        Cliente cAux;
        
        public FormBorrarCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FormBorrarCliente_Load(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>();

            clientes = ConexionDB.LeerClientes();

            foreach (Cliente cliente in clientes)
            {
                cmb_BorrarClienteLista.Items.Add(cliente.Correo);
            }
        }

        private void btn_BorrarClienteCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea volver al inicio?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmb_BorrarClienteLista_SelectedValueChanged(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes = ConexionDB.LeerClientes();

            foreach (Cliente cliente in clientes)
            {
                if (cliente.Correo == cmb_BorrarClienteLista.Text)
                {
                    cAux = cliente;
                    break;
                }
            }
        }

        private void btn_BorrarClienteBorrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar de forma permanente al cliente? \n Todos sus datos se perderan", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.Yes)
            {
                ConexionDB.BorrarCliente(cAux);
                MessageBox.Show("Operacion realizada con exito, regresará al inicio.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Operacion cancelada, regresará al inicio.");
                this.Close();
            }
        }
    }
}
