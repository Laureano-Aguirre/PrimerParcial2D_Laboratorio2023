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
    public partial class FormFacturacion : Form
    {
        public FormFacturacion()
        {
            InitializeComponent();
        }

        private void FormFacturacion_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dgb_Facturaciones.AutoGenerateColumns = false;

            dgb_Facturaciones.Columns.Add("Cliente", "Cliente");
            dgb_Facturaciones.Columns.Add("Monto", "Monto inicial");
            dgb_Facturaciones.Columns.Add("Gasto", "Total gastado");
            BindingList<Venta> bindingListaVentas = new BindingList<Venta>(Venta.ListaVentas);

            VisibilizarVentas(bindingListaVentas);
        }

        private void VisibilizarVentas(BindingList<Venta> bindingListaVentas)
        {
            foreach (Venta venta in bindingListaVentas)
            {
                var row = new DataGridViewRow();    // creo las filas para el datagridview

                var clienteCell = new DataGridViewTextBoxCell();
                clienteCell.Value = venta.Cliente;
                row.Cells.Add(clienteCell);     //agrego las celdas a las filas

                var montoCell = new DataGridViewTextBoxCell();
                montoCell.Value = venta.Monto;
                row.Cells.Add(montoCell);

                var gastoClienteCell = new DataGridViewTextBoxCell();
                gastoClienteCell.Value = venta.Gasto;
                row.Cells.Add(gastoClienteCell);

                dgb_Facturaciones.Rows.Add(row);        //agrego las filas al datagridview
            }
        }

        private void btn_FacturacionAtras_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea ir para atras?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
