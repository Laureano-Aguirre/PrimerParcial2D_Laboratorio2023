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
    public partial class FormComprar : Form
    {
        Cliente caux;
        //List<Carne> listaAuxCarnes = Carne.ObtenerCortes();

        public FormComprar(Cliente cliente)
        {
            InitializeComponent();
            caux = cliente;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            pb_BolsaCompras.BackColor = Color.Transparent;
            nud_CompraKilos.Minimum = 0.5M;
            nud_CompraKilos.Maximum = 10;
            nud_CompraKilos.Value = 0.5M;
            nud_CompraKilos.Increment = 0.5M;
        }

        private void FormComprar_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"imagenes\img-fondoCompra2.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            lb_CompraMonto.Text = caux.Monto.ToString();
            lb_CompraPrecioPorKilo.Visible = false;
            lb_CompraBifeChorizo.Visible = false;
            lb_CompraBolaLomo.Visible = false;
            lb_CompraColitaDeCuadril.Visible = false;
            lb_CompraEntrania.Visible = false;
            lb_CompraFalda.Visible = false;
            lb_CompraOjoBife.Visible = false;
            lb_CompraTiraAsado.Visible = false;
            lb_CompraTortuguita.Visible = false;

            foreach(Carne carne in Carne.ListaCarnes)
            {
                cmb_CompraCortes.Items.Add(carne.TipoDeCarne);
            }
        }

        private void FormComprar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
           
        }

        private void btn_ComprarCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Esta seguro que desea cancelar la compra?\n" +
                "Puede perder todo lo que seleccionó.","Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Form_MenuCliente form_MenuCliente = new Form_MenuCliente(caux);
                form_MenuCliente.Show();
                this.Hide();
            }
        }

        private void cmb_CompraCortes_SelectedValueChanged(object sender, EventArgs e)
        {
            lb_CompraPrecioPorKilo.Text = (Carne.CargarPrecioPorKilo(cmb_CompraCortes.Text)).ToString();
            lb_CompraPrecioPorKilo.Visible = true;
        }

        private void nud_CompraKilos_ValueChanged(object sender, EventArgs e)
        {
            string corteCarne;

            corteCarne = cmb_CompraCortes.Text;

            VisibilizarCortes(corteCarne);
        }

        private void VisibilizarCortes(string corte)
        {
            if (corte == "Tira de asado")
            {
                lb_CompraTiraAsado.Text = nud_CompraKilos.Value.ToString()+ "KG" + cmb_CompraCortes.Text;
                lb_CompraTiraAsado.Visible = true;
            }
            else if (corte == "Colita de cuadril")
            {
                lb_CompraColitaDeCuadril.Text = nud_CompraKilos.Value.ToString() + "KG" + cmb_CompraCortes.Text;
                lb_CompraColitaDeCuadril.Visible = true;
            }
            else if (corte == "Bola de lomo")
            {
                lb_CompraBolaLomo.Text = nud_CompraKilos.Value.ToString() + "KG" + cmb_CompraCortes.Text;
                lb_CompraBolaLomo.Visible = true;
            }
            else if (corte == "Bife de chorizo")
            {
                lb_CompraBifeChorizo.Text = nud_CompraKilos.Value.ToString() + "KG" + cmb_CompraCortes.Text;
                lb_CompraBifeChorizo.Visible = true;
            }
            else if (corte == "Ojo de bife")
            {
                lb_CompraOjoBife.Text = nud_CompraKilos.Value.ToString() + "KG" + cmb_CompraCortes.Text;
                lb_CompraOjoBife.Visible = true;
            }
            else if (corte == "Entraña")
            {
                lb_CompraEntrania.Text = nud_CompraKilos.Value.ToString() + "KG" + cmb_CompraCortes.Text;
                lb_CompraEntrania.Visible = true;
            }
            else if (corte == "Tortuguita")
            {
                lb_CompraTortuguita.Text = nud_CompraKilos.Value.ToString() + "KG" + cmb_CompraCortes.Text;
                lb_CompraTortuguita.Visible = true;
            }
            else if (corte == "Falda")
            {
                lb_CompraFalda.Text = nud_CompraKilos.Value.ToString() + "KG" + cmb_CompraCortes.Text;
                lb_CompraFalda.Visible = true;
            }
        }
    }
}
