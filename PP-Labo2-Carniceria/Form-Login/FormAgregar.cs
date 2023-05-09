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
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FormAgregar_Load_1(object sender, EventArgs e)
        {
            VisibilizacionYConfiguracionControladores();
            foreach (Carne carne in Carne.ListaCarnes)
            {
                cmb_AgregarSeleccionarCorte.Items.Add(carne.TipoDeCarne);
            }
        }

        private void FormAgregar_Shown_1(object sender, EventArgs e)
        {
            rdb_AgregarStock.Checked = false;
            rdb_AgregarTipoDeCorte.Checked = false;
        }

        private void rdb_AgregarStock_CheckedChanged_1(object sender, EventArgs e)
        {
            lb_AgregarSeleccionarCorte.Visible = true;
            cmb_AgregarSeleccionarCorte.Visible = true;
            lb_AgregarStock.Visible = true;
            nud_AgregarStock.Visible = true;
        }

        private void rdb_AgregarTipoDeCorte_CheckedChanged_1(object sender, EventArgs e)
        {
            lb_AgregarTipoDeCorte.Visible = true;
            lb_AgregarStockNuevoCorte.Visible = true;
            lb_AgregarPrecioXKiloCorte.Visible = true;
            txb_AgregarTipoDeCorte.Visible = true;
            txb_AgregarStockNuevoCorte.Visible = true;
            txb_AgregarPrecioXKiloCorte.Visible = true;
            lb_AgregarPrecioXKiloCorte.Visible = true;
        }

        private void btn_AgregarAgregar_Click_1(object sender, EventArgs e)
        {
            if (rdb_AgregarStock.Checked == true || rdb_AgregarTipoDeCorte.Checked == true)
            {
                if (!(string.IsNullOrEmpty(cmb_AgregarSeleccionarCorte.Text)) || !(string.IsNullOrEmpty(txb_AgregarTipoDeCorte.Text)))
                {
                    if (nud_AgregarStock.Value != 0 || !(string.IsNullOrEmpty(txb_AgregarStockNuevoCorte.Text)))
                    {
                        AgregarCorteOStock();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar la cantidad de stock que desea reponer o agregar al nuevo tipo de corte", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un tipo de carne", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de carne o stock.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_AgregarCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Esta seguro que desea cancelar el ingreso de los datos?\n" +
                "Se borraran los datos.", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                FormHeladera frmHeladera = new FormHeladera();
                frmHeladera.Show();
                this.Hide();
            }
        }
        private void FormAgregar_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Configura los controladores
        /// </summary>
        public void VisibilizacionYConfiguracionControladores()
        {
            lb_AgregarStock.Visible = false;
            lb_AgregarTipoDeCorte.Visible = false;
            lb_AgregarSeleccionarCorte.Visible = false;
            lb_AgregarPrecioXKiloCorte.Visible = false;
            lb_AgregarStockNuevoCorte.Visible = false;
            cmb_AgregarSeleccionarCorte.Visible = false;
            nud_AgregarStock.Visible = false;
            txb_AgregarTipoDeCorte.Visible = false;
            txb_AgregarPrecioXKiloCorte.Visible = false;
            txb_AgregarStockNuevoCorte.Visible = false;
            cmb_AgregarSeleccionarCorte.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_AgregarSeleccionarCorte.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_AgregarSeleccionarCorte.AutoCompleteSource = AutoCompleteSource.ListItems;
            nud_AgregarStock.Minimum = 0M;
            nud_AgregarStock.Maximum = 10;
            nud_AgregarStock.Value = 0M;
            nud_AgregarStock.Increment = 0.5M;
        }

        /// <summary>
        /// Chequea que se quiere agregar, si corte o stock. Luego, en caso de que sea corte, confirma que no exista uno ya con ese nombre, en caso de que no, lo agrega
        /// </summary>
        private void AgregarCorteOStock()
        {
            if (rdb_AgregarStock.Checked == true)
            {
                foreach (Carne carne in Carne.ListaCarnes)
                {
                    if (cmb_AgregarSeleccionarCorte.Text == carne.TipoDeCarne)
                    {
                        carne.Stock += nud_AgregarStock.Value;

                        FormHeladera frmHeladera = new FormHeladera();
                        this.Hide();
                        frmHeladera.Show();
                    }
                }
            }
            else if (rdb_AgregarTipoDeCorte.Checked)
            {
                foreach (Carne carne in Carne.ListaCarnes)
                {
                    if (txb_AgregarTipoDeCorte.Text != carne.TipoDeCarne)
                    {
                        bool pudoCambiarPrecio = int.TryParse(txb_AgregarPrecioXKiloCorte.Text, out int precio);
                        bool pudoCambiarStock = decimal.TryParse(txb_AgregarStockNuevoCorte.Text, out decimal stock);
                        bool pudoCargarCorte = Carne.CargarTipoDeCorte(txb_AgregarTipoDeCorte.Text, precio, stock);
                        if (pudoCargarCorte)
                        {
                            MessageBox.Show("Tipo de corte agregado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormHeladera frmHeladera = new FormHeladera();
                            this.Hide();
                            frmHeladera.Show();
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un tipo de carne con ese nombre", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        FormHeladera frmHeladera = new FormHeladera();
                        this.Hide();
                        frmHeladera.Show();
                        break;
                    }
                }
            }
        }
    }
}
