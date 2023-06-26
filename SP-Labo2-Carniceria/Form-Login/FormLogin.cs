using Entidades;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Collections.Generic;

namespace Form_Login
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer1;
        private SoundPlayer soundPlayer2;
        public delegate void EventoInicioSesion(object sender, EventArgs e);        //definimos el tipo de delegado
        public event EventoInicioSesion InicioSesionExitoso;                        //declaramos el evento relacionado al tipo de delegado anterior

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            soundPlayer1 = new SoundPlayer(@"sonidos\sonido-vaca.wav");
            soundPlayer2 = new SoundPlayer(@"sonidos\sonido-gallina.wav");

            pb_Usuario.Visible = false;
            txb_LoginCorreo.Visible = false;
            txb_LoginPassword.Visible = false;
            btn_LoginIngresar.Visible = false;
            btn_LoginAtras.Visible = false;
            lb_LoginCorreo.Visible = false;
            lb_LoginPassword.Visible = false;

            Carne.CargarCortes();
            Venta.HarcodearVentas();

            InicioSesionExitoso += OnInicioSesionExitoso;       //agregamos al metodo como manejador para el evento.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"imagenes\img-login.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btn_LoginCliente_Click(object sender, EventArgs e)
        {
            Visibilizacion();
            soundPlayer1.Play();
            txb_LoginCorreo.Text = "cliente1@gmail.com";
            txb_LoginPassword.Text = "Cliente1cliente*";
            btn_LoginCliente.DialogResult = DialogResult.OK;
        }

        private void btn_LoginVendedor_Click(object sender, EventArgs e)
        {
            Visibilizacion();
            soundPlayer2.Play();
            txb_LoginCorreo.Text = "vendedor1@gmail.com";
            txb_LoginPassword.Text = "Vendedor1vendedor*";
            btn_LoginVendedor.DialogResult = DialogResult.OK;
        }

        private void Visibilizacion()
        {
            txb_LoginCorreo.Visible = true;
            txb_LoginPassword.Visible = true;
            btn_LoginCliente.Visible = false;
            btn_LoginVendedor.Visible = false;
            btn_LoginAtras.Visible = true;
            btn_LoginIngresar.Visible = true;
            lb_LoginCorreo.Visible = true;
            lb_LoginPassword.Visible = true;
            pb_Usuario.Visible = true;
        }

        private bool ValidarDatos(string mail, string pass)
        {
            bool esValido = true;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Se deben completar los siguientes datos: ");

            if (string.IsNullOrEmpty(mail))
            {
                sb.AppendLine("Correo");
                esValido = false;
            }
            if (string.IsNullOrEmpty(pass))
            {
                sb.AppendLine("Contraseña");
                esValido = false;
            }

            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

        private void btn_LoginIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                List<Vendedor> vendedores = ConexionDB.LeerVendedores();
                List<Cliente> clientes = ConexionDB.LeerClientes();
                string correo = txb_LoginCorreo.Text;
                string pass = txb_LoginPassword.Text;
                if (ValidarDatos(correo, pass))
                {
                    if (StringExtension.ContarMinusculas(pass) == 1 && StringExtension.ContarMayusculas(pass) == 1 && StringExtension.ContarCaracteresEspeciales(pass) == 1)
                    {
                        Cliente cliente = new Cliente(correo, pass);
                        Vendedor vendedor = new Vendedor(correo, pass);
                        if (Cliente.ValidarCliente(clientes, cliente) && btn_LoginCliente.DialogResult == DialogResult.OK)
                        {
                            Thread inicioSesionThread = new Thread(() =>
                            {
                                InicioSesionExitoso?.Invoke(this, EventArgs.Empty);             //notifico a los manejadores que el login fue correcto
                            });
                            inicioSesionThread.Start();              
                            Form_MenuCliente frmMenuCliente = new Form_MenuCliente(cliente);
                            soundPlayer1.Play();
                            frmMenuCliente.Show();
                            this.Hide();
                        }
                        else if (Vendedor.BuscarVendedor(vendedores, vendedor) && btn_LoginVendedor.DialogResult == DialogResult.OK)
                        {
                            Thread inicioSesionThread = new Thread(() =>
                            {
                                InicioSesionExitoso?.Invoke(this, EventArgs.Empty);
                            });
                            inicioSesionThread.Start();
                            FormHeladera frmHeladera = new FormHeladera(vendedor);
                            soundPlayer2.Play();
                            frmHeladera.Show();
                            this.Hide();
                        }
                        else
                        {
                            throw new ExcepcionPropia("usuario incorrecto.");
                        }
                    }
                    else
                    {
                        throw new ExcepcionPropia("contraseña incorrecta.");
                    }
                }
            }
            catch (ExcepcionPropia ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            

        }

        private void btn_LoginAtras_Click(object sender, EventArgs e)
        {

            pb_Usuario.Visible = false;
            txb_LoginCorreo.Visible = false;
            txb_LoginPassword.Visible = false;
            btn_LoginIngresar.Visible = false;
            btn_LoginAtras.Visible = false;
            btn_LoginCliente.Visible = true;
            btn_LoginVendedor.Visible = true;
            lb_LoginCorreo.Visible = false;
            lb_LoginPassword.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OnInicioSesionExitoso(object sender, EventArgs e)
        {
            //cuando se dispare el evento que maneja este metodo, aparecerá un messagebox confirmando que se inicio sesión correctamente
            MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);     
        }
    }
}
