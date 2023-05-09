using Entidades;
using System.ComponentModel;

namespace Form_Login
{
    public partial class FormHeladera : Form
    {
        public FormHeladera()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FormHeladera_Load_1(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"imagenes\img-Heladera2.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Deshabilitar la generación automática de columnas
            dataGridView1.AutoGenerateColumns = false;

            // Agregar las columnas manualmente
            dataGridView1.Columns.Add("TipoDeCarne", "Tipo de carne");
            dataGridView1.Columns.Add("PrecioPorKilo", "Precio por kilo");
            dataGridView1.Columns.Add("Stock", "Stock (en kilos)");
            BindingList<Carne> bindingListaCarnes = new BindingList<Carne>(Carne.ListaCarnes);

            VisibilizarCortes(bindingListaCarnes);
        }

        private void FormHeladera_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_HeladeraSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResutl = MessageBox.Show("Esta seguro que desea cerrar el programa?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResutl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void stockToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormAgregar frmAgregar = new FormAgregar();
            frmAgregar.Show();
            this.Hide();
        }

        private void VisibilizarCortes(BindingList<Carne> bindingListaCarnes)
        {
            foreach (Carne carne in bindingListaCarnes)
            {
                // Crear una nueva fila para el DataGridView
                var row = new DataGridViewRow();

                // Agregar las celdas a la fila
                var tipoDeCarneCell = new DataGridViewTextBoxCell();
                tipoDeCarneCell.Value = carne.TipoDeCarne;
                row.Cells.Add(tipoDeCarneCell);

                var precioPorKiloCell = new DataGridViewTextBoxCell();
                precioPorKiloCell.Value = carne.PrecioPorKilo;
                row.Cells.Add(precioPorKiloCell);

                var stockCell = new DataGridViewTextBoxCell();
                stockCell.Value = carne.Stock;
                row.Cells.Add(stockCell);

                // Agregar la fila al DataGridView
                dataGridView1.Rows.Add(row);
            }
        }

        private void precioPorKiloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarProducto frmModificarProducto = new FormModificarProducto();
            frmModificarProducto.Show();
            this.Hide();
        }

        private void btn_HeladeraVender_Click(object sender, EventArgs e)
        {
            FormVendedorVender frmVender = new FormVendedorVender();
            frmVender.Show();
            this.Hide();
        }
    }
}
