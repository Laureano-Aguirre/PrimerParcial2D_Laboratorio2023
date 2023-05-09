using Entidades;

namespace Form_Login
{
    public partial class FormModificarProducto : Form
    {
        public FormModificarProducto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btn_ModificarCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Esta seguro que desea cancelar el ingreso de los datos?\n" +
                "Se borraran los datos.", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormModificarProducto_Load(object sender, EventArgs e)
        {
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
                        carne.PrecioPorKilo = precio;
                        break;
                    }
                }
            }

            FormHeladera frmHeladera = new FormHeladera();
            frmHeladera.Show();
            this.Hide();
        }

    }
}
