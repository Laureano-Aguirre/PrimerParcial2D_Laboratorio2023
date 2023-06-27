using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
                try
                {
                    lb_ModificarUsuario.Text = "Correo nuevo";

                    List<Cliente> clientes = new List<Cliente>();

                    clientes = ConexionDB.LeerClientes();

                    foreach (Cliente cliente in clientes)
                    {
                        cmb_ModificarUsuario.Items.Add(cliente.Correo);
                    }
                }
                catch (ExcepcionPropia ex)
                {
                    MessageBox.Show($"Error al querer leer los clientes. Por favor, intentelo mas tarde.\n Mensaje del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else if (retorno == 2)
            {
                try
                {
                    lb_ModificarUsuario.Text = "Password nueva";

                    List<Cliente> clientes = new List<Cliente>();

                    clientes = ConexionDB.LeerClientes();

                    foreach (Cliente cliente in clientes)
                    {
                        cmb_ModificarUsuario.Items.Add(cliente.Correo);
                    }
                }
                catch (ExcepcionPropia ex)
                {

                    MessageBox.Show($"Error al querer leer los clientes. Por favor, intentelo mas tarde.\n Mensaje del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }      
            }
            else if (retorno == 3)
            {
                try
                {
                    lb_ModificarUsuario.Text = "Monto nuevo";

                    List<Cliente> clientes = new List<Cliente>();

                    clientes = ConexionDB.LeerClientes();

                    foreach (Cliente cliente in clientes)
                    {
                        cmb_ModificarUsuario.Items.Add(cliente.Correo);
                    }
                }
                catch (ExcepcionPropia ex)
                {
                    MessageBox.Show($"Error al querer leer los clientes. Por favor, intentelo mas tarde.\n Mensaje del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (retorno == 4)
            {
                try
                {
                    lb_ModificarUsuario.Text = "Correo nuevo";

                    List<Vendedor> vendedores = new List<Vendedor>();

                    vendedores = ConexionDB.LeerVendedores();

                    foreach (Vendedor vendedor in vendedores)
                    {
                        cmb_ModificarUsuario.Items.Add(vendedor.Correo);
                    }
                }
                catch (ExcepcionPropia ex)
                {

                    MessageBox.Show($"Error al querer leer los vendedores. Por favor, intentelo mas tarde.\n Mensaje del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (retorno == 5)
            {
                try
                {
                    lb_ModificarUsuario.Text = "Password nueva";

                    List<Vendedor> vendedores = new List<Vendedor>();

                    vendedores = ConexionDB.LeerVendedores();

                    foreach (Vendedor vendedor in vendedores)
                    {
                        cmb_ModificarUsuario.Items.Add(vendedor.Correo);
                    }
                }
                catch (ExcepcionPropia ex)
                {
                    MessageBox.Show($"Error al querer leer los vendedores. Por favor, intentelo mas tarde.\n Mensaje del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
        }

        private void cmb_ModificarUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            if (retorno == 1 || retorno == 2 || retorno == 3)
            {
                try
                {
                    List<Cliente> clientes = new List<Cliente>();
                    clientes = ConexionDB.LeerClientes();
                    cAux = Cliente.DevolverCliente(clientes, cmb_ModificarUsuario.Text);

                    //TODO = corroborar que modifica.
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al querer leer los clientes. Por favor, intentelo mas tarde.\n Mensaje del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (retorno == 4 || retorno == 5)
            {
                try
                {
                    List<Vendedor> vendedores = new List<Vendedor>();
                    vendedores = ConexionDB.LeerVendedores();
                    vAux = Vendedor.DevolverVendedor(vendedores, cmb_ModificarUsuario.Text);

                    //TODO = corroborar que modifica.
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error al querer leer los vendedores. Por favor, intentelo mas tarde.\n Mensaje del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_ModificarUsuarioModificar_Click(object sender, EventArgs e)
        {
            if(retorno == 1 || retorno == 2 || retorno == 3)
            {
                if (ValidarDatoIngresadoCliente())
                {
                    this.Close();
                }
            }
            else if(retorno == 4 || retorno == 5)
            {
                if (ValidarDatoIngresadoVendedor())
                {
                    this.Close();
                }
            }
        }

        public bool ValidarDatoIngresadoCliente()
        {
            if(cAux is null)
            {
                MessageBox.Show("Debe elegir un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!(string.IsNullOrEmpty(txb_ModificarUsuario.Text)) && !(string.IsNullOrWhiteSpace(txb_ModificarUsuario.Text)))
                {
                    if (lb_ModificarUsuario.Text == "Correo nuevo")
                    {
                        try
                        {

                            List<Cliente> clientes = ConexionDB.LeerClientes();                     

                            bool existe = Cliente.BuscarPorCorreo(clientes, txb_ModificarUsuario.Text);
                            if(existe)
                            {
                                MessageBox.Show("El correo al que intenta actualizar, ya se encuentra en uso, por favor, proporcione uno nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                ConexionDB.ModificarCorreoCliente(cAux, txb_ModificarUsuario.Text);
                                MessageBox.Show("Correo actualizado exitosamente. Volverá al inicio.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }  
                        }
                        catch (ExcepcionPropia ex)
                        {

                            MessageBox.Show($"Error al querer modificar el correo del cliente. Por favor, intentelo mas tarde.\n Mensaje del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }                      
                    }
                    else if (lb_ModificarUsuario.Text == "Password nueva")
                    {
                        string pass = txb_ModificarUsuario.Text;
                        if (StringExtension.ContarMinusculas(pass) == 1 && StringExtension.ContarMayusculas(pass) == 1 && StringExtension.ContarCaracteresEspeciales(pass) == 1)
                        {
                            try
                            {
                                ConexionDB.ModificarPasswordCliente(cAux, pass);
                                MessageBox.Show("Contraseña actualizada correctamente. Volverá al inicio.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                            catch (ExcepcionPropia ex)
                            {

                                MessageBox.Show($"Error al querer modificar la contraseña del cliente. Por favor, intentelo mas tarde.\n Mensaje del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Contraseña invalida. \n Debe contener minusculas \n una mayuscula \n un caracter especial (#, $, @, &, *)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;

                        }
                    }
                    else if (lb_ModificarUsuario.Text == "Monto nuevo")
                    {
                        if (decimal.TryParse(txb_ModificarUsuario.Text, out decimal monto))
                        {
                            if (monto >= 0)
                            {
                                try
                                {
                                    ConexionDB.ModificarMontoCliente(cAux, monto);
                                    MessageBox.Show("Monto actualizado correctamente. Volverá al inicio.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return true;
                                }
                                catch (ExcepcionPropia ex)
                                {
                                    MessageBox.Show($"Error al querer modificar el monto del cliente. Por favor, intentelo mas tarde.\n Mensaje del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }    
                            }
                            else
                            {
                                MessageBox.Show("Monto invalido, debe ser igual o mayor  a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Monto invalido. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Operacion incorrecta. Revise los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            
            return false;
        }

        public bool ValidarDatoIngresadoVendedor()
        {
            if(vAux is null)
            {
                MessageBox.Show("Debe elegir un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!(string.IsNullOrEmpty(txb_ModificarUsuario.Text)) && !(string.IsNullOrWhiteSpace(txb_ModificarUsuario.Text)))
                {
                    if (lb_ModificarUsuario.Text == "Correo nuevo")
                    {
                        try
                        {
                            List<Vendedor> vendedores = ConexionDB.LeerVendedores();

                            bool existe = Vendedor.BuscarPorCorreo(vendedores, txb_ModificarUsuario.Text);
                            if(existe)
                            {
                                MessageBox.Show("El correo al que intenta actualizar, ya se encuentra en uso, por favor, proporcione uno nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                ConexionDB.ModificarCorreoVendedor(vAux, txb_ModificarUsuario.Text);
                                MessageBox.Show("Correo actualizado exitosamente. Volverá al inicio.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }                            
                        }
                        catch (ExcepcionPropia ex)
                        {

                            MessageBox.Show($"Error al querer modificar el correo del vendedor. Por favor, intentelo mas tarde.\n Mensaje del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }            
                    }
                    else if (lb_ModificarUsuario.Text == "Password nueva")
                    {
                        string pass = txb_ModificarUsuario.Text;
                        if (StringExtension.ContarMinusculas(pass) == 1 && StringExtension.ContarMayusculas(pass) == 1 && StringExtension.ContarCaracteresEspeciales(pass) == 1)
                        {
                            try
                            {
                                ConexionDB.ModificarPasswordVendedor(vAux, pass);
                                MessageBox.Show("Contraseña actualizada correctamente. Volverá al inicio.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                            catch (ExcepcionPropia ex)
                            {

                                MessageBox.Show($"Error al querer modificar la contraseña del vendedor. Por favor, intentelo mas tarde.\n Mensaje del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }             
                        }
                        else
                        {
                            MessageBox.Show("Contraseña invalida. \n Debe contener minusculas \n una mayuscula \n un caracter especial (#, $, @, &, *)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Operacion incorrecta. Revise los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }
    }
}
