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
    public partial class FormAgregarVendedor : Form
    {
        public FormAgregarVendedor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public bool ValidarDatos()
        {
            if (!(string.IsNullOrEmpty(txb_AgregarVendedorCorreo.Text)) && !(string.IsNullOrWhiteSpace(txb_AgregarVendedorCorreo.Text)))
            {
                string correo = txb_AgregarVendedorCorreo.Text;
                if (!(string.IsNullOrEmpty(txb_AgregarVendedorPassword.Text)) && !(string.IsNullOrWhiteSpace(txb_AgregarVendedorPassword.Text)))
                {
                    string password = txb_AgregarVendedorPassword.Text;
                    if ((StringExtension.ContarMayusculas(password) == 1) && (StringExtension.ContarMinusculas(password) == 1) && (StringExtension.ContarCaracteresEspeciales(password) == 1))
                    {
                        return true;
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

        private void bn_AgregarVendedorCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea ir para atras?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_AgregarVendedorAgregar_Click(object sender, EventArgs e)
        {
            if(ValidarDatos())
            {
                string correo = txb_AgregarVendedorCorreo.Text;
                string password = txb_AgregarVendedorPassword.Text;

                Vendedor vendedorNuevo = new Vendedor(correo, password);

                List<Vendedor> vendedores = new List<Vendedor>();
                try
                {
                    vendedores = ConexionDB.LeerVendedores();
                    bool existe = Vendedor.BuscarPorCorreo(vendedores, vendedorNuevo.Correo);
                    if (existe)
                    {
                        MessageBox.Show("El vendedor que intenta agregar, ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        ConexionDB.AgregarVendedor(vendedorNuevo);
                        MessageBox.Show("El vendedor fue agregado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                }
                catch (ExcepcionPropia ex)
                {
                    MessageBox.Show($"Error al querer agregar al usuario. Por favor, intentelo mas tarde. \n Mensaje del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
