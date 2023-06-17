using Entidades;
using System.Media;

namespace Form_Login
{
    public partial class FormModificarProducto : Form
    {
        Vendedor vAux;
        private SoundPlayer soundCancelar;
        private SoundPlayer soundModificar;
        public FormModificarProducto(Vendedor vendedor)
        {
            InitializeComponent();
            vAux = vendedor;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btn_ModificarCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Esta seguro que desea cancelar el ingreso de los datos?\n" +
                "Se borraran los datos.", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                soundCancelar.Play();
                FormHeladera frmHeladera = new FormHeladera(vAux);
                frmHeladera.Show();
                this.Hide();
            }
        }

        private void FormModificarProducto_Load(object sender, EventArgs e)
        {
            soundModificar = new SoundPlayer(@"sonidos\sonido-vaca.wav");
            soundCancelar = new SoundPlayer(@"sonidos\sonido-meVoy.wav");
            foreach (Carne carne in Carne.ListaCarnes)
            {
                cmb_ModificarSeleccionarCarne.Items.Add(carne.TipoDeCarne);
            }
        }

        private void FormModificarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_ModificarModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_ModificarSeleccionarCarne.Text))
            {
                MessageBox.Show("Debe seleccionar un tipo de carne", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chb_ModificarPrecioXKilo.Checked && !chb_ModificarStock.Checked)
            {
                MessageBox.Show("Debe seleccionar modificar el stock o el precio por kilo.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ModificarStockOPrecio();
        }

        /// <summary>
        /// Modifica precio o stock, y puede hacer ambos a la vez.
        /// </summary>
        private void ModificarStockOPrecio()
        {
            bool pudoCambiarStock = int.TryParse(txb_ModificarStock.Text, out int stock);
            bool pudoCambiarPrecio = int.TryParse(txb_ModificarPrecioXKilo.Text, out int precio);

            if (chb_ModificarStock.Checked)
            {
                if (!pudoCambiarStock)
                {
                    MessageBox.Show("Debe ingresar el nuevo stock", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (Carne carne in Carne.ListaCarnes)
                {
                    if (cmb_ModificarSeleccionarCarne.Text == carne.TipoDeCarne)
                    {
                        soundModificar.Play();
                        carne.Stock = stock;
                        break;
                    }
                }
            }

            if (chb_ModificarPrecioXKilo.Checked)
            {
                if (!pudoCambiarPrecio)
                {
                    MessageBox.Show("Debe ingresar el nuevo precio por kilo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (Carne carne in Carne.ListaCarnes)
                {
                    if (cmb_ModificarSeleccionarCarne.Text == carne.TipoDeCarne)
                    {
                        soundModificar.Play();
                        carne.PrecioPorKilo = precio;
                        break;
                    }
                }
            }

            FormHeladera frmHeladera = new FormHeladera(vAux);
            frmHeladera.Show();
            this.Hide();
        }

    }
}
