using Entidades;
using System.ComponentModel;
using System.Media;

namespace Form_Login
{
    public partial class FormHeladera : Form
    {
        Vendedor vAux;
        private SoundPlayer soundCancelar;
        private SoundPlayer soundVender;
        public FormHeladera(Vendedor vendedor)
        {
            InitializeComponent();
            vAux = vendedor;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FormHeladera_Load_1(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"imagenes\img-Heladera2.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            lb_HeladeraBiennvenida.Text = $"Bienvenido {vAux.Mostrar()} !";
            dataGridView1.AutoGenerateColumns = false;
            soundVender = new SoundPlayer(@"sonidos\sonido-monedas.wav");
            soundCancelar = new SoundPlayer(@"sonidos\sonido-meVoy.wav");

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
                soundCancelar.Play();
                Application.Exit();
            }
        }

        private void stockToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormAgregar frmAgregar = new FormAgregar(vAux);
            frmAgregar.Show();
            this.Hide();
        }

        private void VisibilizarCortes(BindingList<Carne> bindingListaCarnes)
        {
            foreach (Carne carne in bindingListaCarnes)
            {
                var row = new DataGridViewRow();    // creo las filas para el datagridview

                var tipoDeCarneCell = new DataGridViewTextBoxCell();
                tipoDeCarneCell.Value = carne.TipoDeCarne;
                row.Cells.Add(tipoDeCarneCell);     //agrego las celdas a las filas

                var precioPorKiloCell = new DataGridViewTextBoxCell();
                precioPorKiloCell.Value = carne.PrecioPorKilo;
                row.Cells.Add(precioPorKiloCell);

                var stockCell = new DataGridViewTextBoxCell();
                stockCell.Value = carne.Stock;
                row.Cells.Add(stockCell);

                dataGridView1.Rows.Add(row);        //agrego las filas al datagridview
            }
        }

        private void precioPorKiloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarProducto frmModificarProducto = new FormModificarProducto(vAux);
            frmModificarProducto.Show();
            this.Hide();
        }

        private void btn_HeladeraVender_Click(object sender, EventArgs e)
        {
            soundVender.Play();
            FormVendedorVender frmVender = new FormVendedorVender(vAux);
            frmVender.Show();
            this.Hide();
        }

        private void historialDeFacturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFacturacion frmFacturacion = new FormFacturacion();
            frmFacturacion.ShowDialog();
        }

        private void historialDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistorialVentas frmHistorialVentas = new FormHistorialVentas();
            frmHistorialVentas.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVerClientes frmVerClientes = new FormVerClientes();
            frmVerClientes.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarCliente frmAgregarCliente = new FormAgregarCliente();
            frmAgregarCliente.ShowDialog();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormBorrarCliente frmBorrarCliente = new FormBorrarCliente(1);
            frmBorrarCliente.ShowDialog();
        }

        private void correoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarUsuario frmModificarUsuario = new FormModificarUsuario(1);
            frmModificarUsuario.ShowDialog();
        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarUsuario frmModificarUsuario = new FormModificarUsuario(2);
            frmModificarUsuario.ShowDialog();
        }

        private void montoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarUsuario frmModificarUsuario = new FormModificarUsuario(3);
            frmModificarUsuario.ShowDialog();
        }

        private void correoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormModificarUsuario frmModificarUsuario = new FormModificarUsuario(4);
            frmModificarUsuario.ShowDialog();
        }

        private void passwordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormModificarUsuario frmModificarUsuario = new FormModificarUsuario(5);
            frmModificarUsuario.ShowDialog();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorrarCliente frmBorrarCliente = new FormBorrarCliente(2);
            frmBorrarCliente.ShowDialog();
        }

        private void vendedorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormAgregarVendedor frmAgregarVendedor = new FormAgregarVendedor();
            frmAgregarVendedor.ShowDialog();
        }
    }
}
