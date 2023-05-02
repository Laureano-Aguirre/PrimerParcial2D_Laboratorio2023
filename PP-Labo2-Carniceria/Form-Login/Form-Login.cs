using Entidades;

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"imagenes\img-nombreLogin.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //pb_Usuario.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btn_LoginCliente_Click(object sender, EventArgs e)
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

        private void btn_LoginVendedor_Click(object sender, EventArgs e)
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
    }
}