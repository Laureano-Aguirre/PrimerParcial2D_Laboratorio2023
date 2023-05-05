using Entidades;
using System.Text;

namespace Form_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pb_Usuario.Visible = false;
            txb_LoginCorreo.Visible = false;
            txb_LoginPassword.Visible = false;
            btn_LoginIngresar.Visible = false;
            lb_LoginCorreo.Visible = false;
            lb_LoginPassword.Visible = false;
            Vendedor.HardcodearVendedores();
            Cliente.HardocdearClientes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"imagenes\img-nombreLogin.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_LoginCliente_Click(object sender, EventArgs e)
        {
            Visibilizacion();
            txb_LoginCorreo.Text = "cliente1@gmail.com";
            txb_LoginPassword.Text = "cliente1cliente";
            btn_LoginCliente.DialogResult = DialogResult.OK;
        }

        private void btn_LoginVendedor_Click(object sender, EventArgs e)
        {
            Visibilizacion();
            txb_LoginCorreo.Text = "vendedor1@gmail.com";
            txb_LoginPassword.Text = "vendedor1vendedor";
            btn_LoginVendedor.DialogResult = DialogResult.OK;
        }

        private void Visibilizacion()
        {
            txb_LoginCorreo.Visible = true;
            txb_LoginPassword.Visible = true;
            btn_LoginCliente.Visible = false;
            btn_LoginVendedor.Visible = false;
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
            //Cliente cAux = new Cliente(correo, pass);
            //Vendedor vAux = new Vendedor(correo, pass);

            if (ValidarDatos(correo, pass))
            {
                if ((Cliente.ValidarCliente(correo, pass)) && btn_LoginCliente.DialogResult == DialogResult.OK)
                {
                    Cliente cliente = new Cliente(correo, pass);

                    Form_MenuCliente frmMenuCliente = new Form_MenuCliente(cliente);
                    frmMenuCliente.Show();
                    this.Hide();
                }
                else if ((Vendedor.BuscarVendedor(correo, pass)) && btn_LoginVendedor.DialogResult == DialogResult.OK)
                {
                    FormHeladera frmHeladera = new FormHeladera();
                    frmHeladera.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
