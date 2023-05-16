using Entidades;
using System.Media;
using System.Text.RegularExpressions;


namespace Form_Login
{
    public partial class FormAgregar : Form
    {
        Vendedor vAux;
        private SoundPlayer soundCancelar;
        private SoundPlayer soundAgregar;
        public FormAgregar(Vendedor vendedor)
        {
            InitializeComponent();
            vAux = vendedor;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FormAgregar_Load_1(object sender, EventArgs e)
        {
            VisibilizacionYConfiguracionControladores();
            soundAgregar = new SoundPlayer(@"sonidos\sonido-vaca.wav");
            soundCancelar = new SoundPlayer(@"sonidos\sonido-meVoy.wav");
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

            lb_AgregarTipoDeCorte.Visible = false;
            lb_AgregarStockNuevoCorte.Visible = false;
            lb_AgregarPrecioXKiloCorte.Visible = false;
            txb_AgregarTipoDeCorte.Visible = false;
            txb_AgregarStockNuevoCorte.Visible = false;
            txb_AgregarPrecioXKiloCorte.Visible = false;
        }

        private void rdb_AgregarTipoDeCorte_CheckedChanged_1(object sender, EventArgs e)
        {
            lb_AgregarTipoDeCorte.Visible = true;
            lb_AgregarStockNuevoCorte.Visible = true;
            lb_AgregarPrecioXKiloCorte.Visible = true;
            txb_AgregarTipoDeCorte.Visible = true;
            txb_AgregarStockNuevoCorte.Visible = true;
            txb_AgregarPrecioXKiloCorte.Visible = true;

            lb_AgregarSeleccionarCorte.Visible = false;
            cmb_AgregarSeleccionarCorte.Visible = false;
            lb_AgregarStock.Visible = false;
            nud_AgregarStock.Visible = false;
        }

        private void btn_AgregarAgregar_Click_1(object sender, EventArgs e)
        {
            if (ValidarAgregarStock())
            {
                AgregarCorteOStock();
            }
            else if (ValidarAgregarCorte())
            {
                AgregarCorteOStock();
            }
        }

        private void btn_AgregarCancelar_Click_1(object sender, EventArgs e)
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
            if (rdb_AgregarStock.Checked)
            {
                foreach (Carne carne in Carne.ListaCarnes)
                {
                    if (cmb_AgregarSeleccionarCorte.Text == carne.TipoDeCarne)
                    {
                        carne.Stock += nud_AgregarStock.Value;
                        soundAgregar.Play();
                        MessageBox.Show("Stock agregado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
            else if (rdb_AgregarTipoDeCorte.Checked)
            {
                bool corteExistente = false;
                foreach (Carne carne in Carne.ListaCarnes)
                {
                    if (carne.TipoDeCarne == txb_AgregarTipoDeCorte.Text)
                    {
                        corteExistente = true;
                        break;
                    }
                }

                if (corteExistente)
                {
                    MessageBox.Show("Ya existe un tipo de carne con ese nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool pudoCambiarPrecio = int.TryParse(txb_AgregarPrecioXKiloCorte.Text, out int precio);
                    bool pudoCambiarStock = decimal.TryParse(txb_AgregarStockNuevoCorte.Text, out decimal stock);
                    bool pudoCargarCorte = Carne.CargarTipoDeCorte(txb_AgregarTipoDeCorte.Text, precio, stock);
                    if (pudoCargarCorte)
                    {
                        soundAgregar.Play();
                        MessageBox.Show("Tipo de corte agregado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            FormHeladera frmHeladera = new FormHeladera(vAux);
            this.Hide();
            frmHeladera.Show();
        }


        /// <summary>
        /// Valida el ingreso de datos a la hora de agregar stock
        /// </summary>
        /// <returns></returns>
        private bool ValidarAgregarStock()
        {
            if (rdb_AgregarStock.Checked == true)
            {
                if (!(string.IsNullOrEmpty(cmb_AgregarSeleccionarCorte.Text)))
                {
                    if (nud_AgregarStock.Value != 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una cantidad de stock.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un tipo de corte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Valida el ingreso de datos a la hora de agregar un nuevo corte, con sus respectivas caracteristicas.
        /// </summary>
        /// <returns></returns>
        private bool ValidarAgregarCorte()
        {
            Regex regex = new Regex("^[a-zA-Z\\s]+$");
            bool pudoCambiarStock = decimal.TryParse(txb_AgregarStockNuevoCorte.Text, out decimal stock);
            bool pudoCambiarPrecioXKilo = decimal.TryParse(txb_AgregarPrecioXKiloCorte.Text, out decimal precioXKilo);
            if (rdb_AgregarTipoDeCorte.Checked == true)
            {
                if (!(string.IsNullOrEmpty(txb_AgregarTipoDeCorte.Text)) && !(string.IsNullOrWhiteSpace(txb_AgregarTipoDeCorte.Text)) && regex.Match(txb_AgregarTipoDeCorte.Text).Success)
                {
                    if (!(string.IsNullOrEmpty(txb_AgregarStockNuevoCorte.Text)) && !(string.IsNullOrWhiteSpace(txb_AgregarStockNuevoCorte.Text)) && pudoCambiarStock == true)
                    {
                        if (!(string.IsNullOrEmpty(txb_AgregarPrecioXKiloCorte.Text)) && !(string.IsNullOrWhiteSpace(txb_AgregarPrecioXKiloCorte.Text)) && pudoCambiarPrecioXKilo == true)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("El el precio por kilo ingresado es invalido. Ingreselo nuevamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El stock ingresado es invalido. Ingreselo nuevamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El tipo de corte seleccionado a agregar es invalido. Ingreselo nuevamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
