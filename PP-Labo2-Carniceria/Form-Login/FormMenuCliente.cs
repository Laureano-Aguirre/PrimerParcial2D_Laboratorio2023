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
    public partial class Form_MenuCliente : Form
    {
        public Form_MenuCliente(string correo)
        {
            InitializeComponent();
            Carne.CargarCortes();
            lb_MenPrinBienvenido.Text = $"Bienvenido {correo}!";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form_MenuCliente_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"imagenes\img-MenuPrincipalCliente.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            timer1.Interval = 1000;          
            timer1.Enabled = true;
            lb_MenPrincMoneda.BackColor = Color.Transparent;
            lb_MenPrincMonto.BackColor = Color.Transparent;
            lb_MenuPrinHora.BackColor = Color.Transparent;
            lb_MenPrinBienvenido.BackColor = Color.Transparent;
  
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
            DialogResult resultado = MessageBox.Show("Desea salir de la aplicacion?","Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(resultado == DialogResult.Yes)
            {
                this.Close();
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
                FormComprar frmComprar = new FormComprar();
                frmComprar.Show();
                this.Hide();
            }
        }

        private bool ValidarMonto()
        {
            if(txb_MenPrinMonto is not null)
            {
                return true;
            }
            return false;
        }
    }
}
