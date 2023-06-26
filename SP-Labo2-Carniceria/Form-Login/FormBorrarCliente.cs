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
        Vendedor vAux;
        int retorno;

        public FormBorrarCliente(int opcion)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            retorno = opcion;
        }

        private void FormBorrarCliente_Load(object sender, EventArgs e)
        {
            if(retorno == 1) //si es cliente
            {
                try
                {
                    lb_BorrarCliente.Text = "Seleccione el cliente que desea eliminar:";
                    List<Cliente> clientes = new List<Cliente>();

                    clientes = ConexionDB.LeerClientes();

                    foreach (Cliente cliente in clientes)
                    {
                        cmb_BorrarClienteLista.Items.Add(cliente.Correo);
                    }
                }
                catch (ExcepcionPropia ex)
                {
                    MessageBox.Show($"Error al querer leer los usuarios. Por favor, intentelo mas tarde. \n Mensaje de error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else if(retorno == 2) // si es vendedor
            {
                try
                {
                    lb_BorrarCliente.Text = "Seleccione el vendedor que desea eliminar:";
                    List<Vendedor> vendedores = new List<Vendedor>();

                    vendedores = ConexionDB.LeerVendedores();

                    foreach (Vendedor vendedor in vendedores)
                    {
                        cmb_BorrarClienteLista.Items.Add(vendedor.Correo);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al querer leer los usuarios. Por favor, intentelo mas tarde. \n Mensaje de error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
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
            try
            {
                if (retorno == 1)
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
                else if (retorno == 2)
                {
                    List<Vendedor> vendedores = new List<Vendedor>();

                    vendedores = ConexionDB.LeerVendedores();

                    foreach (Vendedor vendedor in vendedores)
                    {
                        if (vendedor.Correo == cmb_BorrarClienteLista.Text)
                        {
                            vAux = vendedor;
                            break;
                        }
                    }
                }
            }
            catch (ExcepcionPropia ex)
            {

                MessageBox.Show($"Error al querer leer los usuarios. Por favor, intentelo mas tarde. \n Mensaje d el error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

        private void btn_BorrarClienteBorrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar de forma permanente al cliente? \n Todos sus datos se perderan", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (cAux is not null)
                    {
                        ConexionDB.BorrarCliente(cAux);
                        MessageBox.Show("Operacion realizada con exito, regresará al inicio.");
                        this.Close();
                    }
                    else if (vAux is not null)
                    {
                        ConexionDB.BorrarVendedor(vAux);
                        MessageBox.Show("Operacion realizada con exito, regresará al inicio.");
                        this.Close();
                    }
                    else if (cAux is null && vAux is null)
                    {
                        MessageBox.Show("Error, debe elegir un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch ( Exception ex)
                {

                    MessageBox.Show($"Operacion cancelada, error en el intento de borrar el usuario. \n " +
                        $"Mensaje del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Operacion cancelada, regresará al inicio.");
                this.Close();
            }
        }
    }
}
