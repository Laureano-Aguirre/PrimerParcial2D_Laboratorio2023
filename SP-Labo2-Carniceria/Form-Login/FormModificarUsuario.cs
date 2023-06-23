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
    public partial class FormModificarUsuario : Form
    {
        int retorno;
        Cliente cAux;
        Vendedor vAux;
        //Type tipoUsuario;

        public FormModificarUsuario(int opcion)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            retorno = opcion;
        }

        private void FormModificarUsuario_Load(object sender, EventArgs e)
        {
            if (retorno == 1)
            {
                lb_ModificarUsuarioCorreo.Visible = true;
                lb_ModificarUsuarioPassword.Visible = true;
                lb_ModificarUsuarioMonto.Visible = true;
                txb_ModificarUsuarioCorreo.Visible = true;
                txb_ModificarUsuarioPassword.Visible = true;
                txb_ModificarUsuarioMonto.Visible = true;
                List<Cliente> clientes = new List<Cliente>();

                clientes = ConexionDB.LeerClientes();

                foreach (Cliente cliente in clientes)
                {
                    cmb_ModificarUsuario.Items.Add(cliente.Correo);
                }
            }
            else if (retorno == 2)
            {
                lb_ModificarUsuarioCorreo.Visible = true;
                lb_ModificarUsuarioPassword.Visible = true;
                lb_ModificarUsuarioMonto.Visible = false;
                txb_ModificarUsuarioCorreo.Visible = true;
                txb_ModificarUsuarioPassword.Visible = true;
                txb_ModificarUsuarioMonto.Visible = false;
                List<Vendedor> vendedores = new List<Vendedor>();

                vendedores = ConexionDB.LeerVendedores();

                foreach (Vendedor vendedor in vendedores)
                {
                    cmb_ModificarUsuario.Items.Add(vendedor.Correo);
                }
            }

        }

        private void cmb_ModificarUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            if(retorno == 1)
            {
                try
                {
                    List<Cliente> clientes = new List<Cliente>();
                    cAux = Cliente.DevolverCliente(clientes, cmb_ModificarUsuario.Text);

                    //TODO = corroborar que modifica.
                }
                catch (Exception ex)
                {

                    throw new Exception (ex.Message);
                }
                
            }
            else if(retorno == 2)
            {
                try
                {
                    List<Vendedor> vendedores = new List<Vendedor>();
                    vAux = Vendedor.DevolverVendedor(vendedores, cmb_ModificarUsuario.Text);

                    //TODO = corroborar que modifica.
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }
        }

        private void bn_ModificarUsuarioCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea volver al inicio?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
