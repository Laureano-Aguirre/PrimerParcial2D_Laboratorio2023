using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Form_Login
{
    public partial class Form_MenuCliente : Form
    {
        Cliente cAux;
        private SoundPlayer soundPlayer1;
        private SoundPlayer soundPlayer2;
        public Form_MenuCliente(Cliente cliente)
        {
            InitializeComponent();

            cAux = cliente;
            lb_MenPrinBienvenido.Text = $"Bienvenido {cliente.Correo}!";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form_MenuCliente_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"imagenes\img-MenuPrincipalCliente.png");
            soundPlayer1 = new SoundPlayer(@"sonidos\sonido-monedas.wav");
            soundPlayer2 = new SoundPlayer(@"sonidos\sonido-meVoy.wav");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            timer1.Interval = 1000;          
            timer1.Enabled = true;
            lb_MenPrincMoneda.BackColor = Color.Transparent;
            lb_MenPrincMonto.BackColor = Color.Transparent;
            lb_MenuPrinHora.BackColor = Color.Transparent;
            lb_MenPrinBienvenido.BackColor = Color.Transparent;
            txb_MenPrinMonto.MaxLength = 6;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime horaActual = DateTime.Now;
            lb_MenuPrinHora.Text = horaActual.ToString("hh:mm:ss tt");
        }

        private void Form_MenuCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            timer1.Enabled = false;
        }

        private void btn_MenPrinSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cerrar sesion?","Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(resultado == DialogResult.Yes)
            {
                soundPlayer2.Play();
                Form1 frmLogin = new Form1();
                this.Hide();
                frmLogin.Show();
            }
            
        }

        private void metodosDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(Vendedor.MostrarMetodoDePago(),"",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void montoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Tu monto es: {txb_MenPrinMonto.Text}","", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cortesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Carne.MostrarCortes(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nuestro telefono es: 4301-0909", "Comunicate con nosotros!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_MenPrinComenzarAComprar_Click(object sender, EventArgs e)
        {
            if(!(ValidarMonto()))
            {
                MessageBox.Show("Para poder comprar, debe ingresar el monto.","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                soundPlayer1.Play();
                decimal.TryParse(txb_MenPrinMonto.Text, out decimal monto);
                cAux.Monto = monto;
                FormComprar frmComprar = new FormComprar(cAux);
                frmComprar.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Valida que el monto ingresado sea mayor que 0
        /// </summary>
        /// <returns></returns>
        private bool ValidarMonto()
        {

            if (!(string.IsNullOrEmpty(txb_MenPrinMonto.Text)))
            {
                if(int.TryParse(txb_MenPrinMonto.Text, out int num) && num>0)
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}
