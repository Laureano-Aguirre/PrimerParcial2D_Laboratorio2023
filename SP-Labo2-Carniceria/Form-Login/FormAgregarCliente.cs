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
    public partial class FormAgregarCliente : Form
    {
        public FormAgregarCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void bn_AgregarClienteCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea ir para atras?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_AgregarClienteAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                if (ValidarDatos())
                {
                    string correo = txb_AgregarClienteCorreo.Text;
                    string password = txb_AgregarClientePassword.Text;
                    decimal monto = Convert.ToDecimal(txb_AgregarClienteMonto.Text);
                    decimal gasto = Convert.ToDecimal(txb_AgregarClienteGasto.Text);

                    Cliente clienteNuevo = new Cliente(correo, password, monto, gasto);

                    List<Cliente> clientes = new List<Cliente>();

                    clientes = ConexionDB.LeerClientes();

                    bool existe = Cliente.BuscarPorCorreo(clientes, clienteNuevo.Correo);
                    if (existe)
                    {
                        MessageBox.Show("El cliente que intenta agregar, ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        ConexionDB.AgregarCliente(clienteNuevo);
                        MessageBox.Show("El cliente fue agregado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al querer agregar el cliente, por favor, intente mas tarde. \n" +
                    $"Mensaje de error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            
        }

        public bool ValidarDatos()
        {
            if (!(string.IsNullOrEmpty(txb_AgregarClienteCorreo.Text)) && !(string.IsNullOrWhiteSpace(txb_AgregarClienteCorreo.Text)))
            {
                string correo = txb_AgregarClienteCorreo.Text;
                if (!(string.IsNullOrEmpty(txb_AgregarClientePassword.Text)) && !(string.IsNullOrWhiteSpace(txb_AgregarClientePassword.Text)))
                {
                    string password = txb_AgregarClientePassword.Text;

                    if ((StringExtension.ContarMayusculas(password) == 1) && (StringExtension.ContarMinusculas(password) == 1) && (StringExtension.ContarCaracteresEspeciales(password) == 1))
                    {
                        if (!(string.IsNullOrEmpty(txb_AgregarClienteMonto.Text)) && !(string.IsNullOrWhiteSpace(txb_AgregarClienteMonto.Text)))
                        {
                            if (decimal.TryParse(txb_AgregarClienteMonto.Text, out decimal monto) && monto > 0)
                            {
                                if (decimal.TryParse(txb_AgregarClienteGasto.Text, out decimal gasto) && gasto >= 0)
                                {
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Gasto invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }
                            else
                            {
                                MessageBox.Show("Monto invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Monto invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña invalida. \n Debe contener minusculas \n una mayuscula \n un caracter especial (#, $, @, &, *)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Correo incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
    }
}
