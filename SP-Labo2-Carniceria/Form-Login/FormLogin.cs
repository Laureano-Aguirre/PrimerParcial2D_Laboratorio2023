using Entidades;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Form_Login
{

    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer1;
        private SoundPlayer soundPlayer2;
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
            Vendedor.HardcodearVendedores();
            //Cliente.HardocdearClientes();
            Carne.CargarCortes();
            Venta.HarcodearVentas();
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

        /// <summary>
        /// Muestra y esconde los controladores
        /// </summary>
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

        /// <summary>
        /// Valida que los datos ingresados por el usuario no sean nulos
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
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

            if (!(esValido))
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

        private void btn_LoginIngresar_Click(object sender, EventArgs e)
        {
            string correo = txb_LoginCorreo.Text;
            string pass = txb_LoginPassword.Text;

            try
            {
                if (ValidarDatos(correo, pass))
                {
                    if (StringExtension.ContarMinusculas(pass) == 1 && StringExtension.ContarMayusculas(pass) == 1 && StringExtension.ContarCaracteresEspeciales(pass) == 1)
                    {
                        if ((Cliente.ValidarCliente(correo, pass)) && btn_LoginCliente.DialogResult == DialogResult.OK)
                        {
                            Cliente cliente = new Cliente(correo, pass);

                            Form_MenuCliente frmMenuCliente = new Form_MenuCliente(cliente);
                            soundPlayer1.Play();
                            frmMenuCliente.Show();
                            this.Hide();
                        }
                        else if ((Vendedor.BuscarVendedor(correo, pass)) && btn_LoginVendedor.DialogResult == DialogResult.OK)
                        {
                            Vendedor vendedor = new Vendedor(4,correo, pass);
                            FormHeladera frmHeladera = new FormHeladera(vendedor);
                            soundPlayer2.Play();
                            frmHeladera.Show();
                            this.Hide();
                        }
                        else
                        {
                            throw new Exception ("usuario incorrecto.");
                        }
                    }
                    else
                    {
                        throw new Exception ("contraseña incorrecta.");                        
                    }
                }
            }
            catch(Exception ex)
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
    }
}
