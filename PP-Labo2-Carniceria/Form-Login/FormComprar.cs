using Entidades;

namespace Form_Login
{
    public partial class FormComprar : Form
    {
        Cliente caux;
        //List<Carne> listaAuxCarnes = Carne.ObtenerCortes();
        static decimal costoFinal = 0;


        public FormComprar(Cliente cliente)
        {
            InitializeComponent();
            caux = cliente;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            pb_BolsaCompras.BackColor = Color.Transparent;
            nud_CompraKilos.Minimum = 0M;
            nud_CompraKilos.Maximum = 10;
            nud_CompraKilos.Value = 0M;
            nud_CompraKilos.Increment = 0.5M;
            lb_ComprarCostoTotal.Text = "0";
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

            foreach (Carne carne in Carne.ListaCarnes)
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
                "Puede perder todo lo que seleccionó.", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            bool pudoCambiar = int.TryParse(lb_ComprarCostoTotal.Text, out int costoFinal);

            corteCarne = cmb_CompraCortes.Text;

            VisibilizarCortes(corteCarne);

            if (int.TryParse(lb_CompraPrecioPorKilo.Text, out int precioPorKilo))
            {
                lb_ComprarCostoTotal.Text = (Carne.CalcularCosto(nud_CompraKilos.Value, precioPorKilo).ToString() + costoFinal);
            }
        }

        private void VisibilizarCortes(string corte)
        {
            if (corte == "Tira de asado")
            {
                lb_CompraTiraAsado.Text = nud_CompraKilos.Value.ToString() + "KG" + cmb_CompraCortes.Text;
                lb_CompraTiraAsado.Visible = true;
                lb_CompraTiraAsado.BackColor = Color.FromArgb(191, 148, 113);
            }
            else if (corte == "Colita de cuadril")
            {
                lb_CompraColitaDeCuadril.Text = nud_CompraKilos.Value.ToString() + "KG" + cmb_CompraCortes.Text;
                lb_CompraColitaDeCuadril.Visible = true;
                lb_CompraColitaDeCuadril.BackColor = Color.FromArgb(191, 148, 113);
            }
            else if (corte == "Bola de lomo")
            {
                lb_CompraBolaLomo.Text = nud_CompraKilos.Value.ToString() + "KG" + cmb_CompraCortes.Text;
                lb_CompraBolaLomo.Visible = true;
                lb_CompraBolaLomo.BackColor = Color.FromArgb(191, 148, 113);
            }
            else if (corte == "Bife de chorizo")
            {
                lb_CompraBifeChorizo.Text = nud_CompraKilos.Value.ToString() + "KG" + cmb_CompraCortes.Text;
                lb_CompraBifeChorizo.Visible = true;
                lb_CompraBifeChorizo.BackColor = Color.FromArgb(191, 148, 113);
            }
            else if (corte == "Ojo de bife")
            {
                lb_CompraOjoBife.Text = nud_CompraKilos.Value.ToString() + "KG" + cmb_CompraCortes.Text;
                lb_CompraOjoBife.Visible = true;
                lb_CompraOjoBife.BackColor = Color.FromArgb(191, 148, 113);
            }
            else if (corte == "Entraña")
            {
                lb_CompraEntrania.Text = nud_CompraKilos.Value.ToString() + "KG" + cmb_CompraCortes.Text;
                lb_CompraEntrania.Visible = true;
                lb_CompraEntrania.BackColor = Color.FromArgb(191, 148, 113);
            }
            else if (corte == "Tortuguita")
            {
                lb_CompraTortuguita.Text = nud_CompraKilos.Value.ToString() + "KG" + cmb_CompraCortes.Text;
                lb_CompraTortuguita.Visible = true;
                lb_CompraTortuguita.BackColor = Color.FromArgb(191, 148, 113);
            }
            else if (corte == "Falda")
            {
                lb_CompraFalda.Text = nud_CompraKilos.Value.ToString() + "KG" + cmb_CompraCortes.Text;
                lb_CompraFalda.Visible = true;
                lb_CompraFalda.BackColor = Color.FromArgb(191, 148, 113);
            }
        }

        private void btn_CompraCredito_Click(object sender, EventArgs e)
        {
            FormTarjeta frmTarjeta = new FormTarjeta();
            frmTarjeta.Show();
        }

        private void btn_CompraDebito_Click(object sender, EventArgs e)
        {
            FormTarjeta frmTarjeta = new FormTarjeta();
            frmTarjeta.Show();
        }

        private void cmb_CompraCortes_SelectedIndexChanged(object sender, EventArgs e)
        {
            nud_CompraKilos.Value = 0;

            // Obtener el precio por kilo del nuevo corte seleccionado
            int precioPorKiloNuevoCorte = Carne.CargarPrecioPorKilo(cmb_CompraCortes.Text);

            // Obtener el costo total actual
            int costoTotalActual = int.Parse(lb_ComprarCostoTotal.Text);

            // Calcular el costo total correspondiente al nuevo corte
            int costoTotalNuevoCorte = Carne.CalcularCosto((int)nud_CompraKilos.Value, precioPorKiloNuevoCorte);

            // Sumar el costo total actual con el costo total del nuevo corte
            int costoTotal = costoTotalActual + costoTotalNuevoCorte;

            // Actualizar el label lb_ComprarCostoTotal con el nuevo valor
            lb_ComprarCostoTotal.Text = costoFinal.ToString();
        }
    }
}
