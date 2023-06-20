using Entidades;
using System.Media;

namespace Form_Login
{
    public partial class FormComprar : Form
    {
        Tarjeta tarjetaAux;
        Cliente caux;
        decimal costoParcial = 0;
        private SoundPlayer soundAgregar;
        private SoundPlayer soundEfectivo;
        private SoundPlayer soundTarjeta;
        private SoundPlayer soundCancelar;
        private SoundPlayer soundPagar;

        public FormComprar(Cliente cliente)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            pb_BolsaCompras.BackColor = Color.Transparent;
            nud_CompraKilos.Minimum = 0M;
            nud_CompraKilos.Maximum = 10;
            nud_CompraKilos.Value = 0M;
            nud_CompraKilos.Increment = 0.5M;
            lb_ComprarCostoParcial.Text = "0";
            caux = cliente;
        }

        private void FormComprar_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"imagenes\img-fondoCompra2.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            soundAgregar = new SoundPlayer(@"sonidos\sonido-albuche.wav");
            soundEfectivo = new SoundPlayer(@"sonidos\sonido-efectivo.wav");
            soundTarjeta = new SoundPlayer(@"sonidos\sonido-tarjetas.wav");
            soundCancelar = new SoundPlayer(@"sonidos\sonido-meVoy.wav");
            soundPagar = new SoundPlayer(@"sonidos\sonido-final.wav");
            lb_CompraMonto.Text = caux.Monto.ToString();
            lb_CompraPrecioPorKilo.Visible = false;
            cmb_CompraCortes.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_CompraCortes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_CompraCortes.AutoCompleteSource = AutoCompleteSource.ListItems;
            btn_CompraEfectivo.DialogResult = DialogResult.None;
            btn_CompraCredito.DialogResult = DialogResult.None;
            btn_CompraCredito.DialogResult = DialogResult.None;
            btn_CompraAgregar.DialogResult = DialogResult.None;

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
                if (caux != null)
                {
                    Cliente.LimpiarListaCompras(caux);
                    Form_MenuCliente form_MenuCliente = new Form_MenuCliente(caux);
                    soundCancelar.Play();
                    form_MenuCliente.Show();
                    this.Hide();
                }   
            }
        }

        private void cmb_CompraCortes_SelectedValueChanged(object sender, EventArgs e)
        {
            nud_CompraKilos.Value = 0;
            lb_CompraPrecioPorKilo.Text = (Carne.CargarPrecioPorKilo(cmb_CompraCortes.Text)).ToString();
            lb_CompraPrecioPorKilo.Visible = true;
        }

        private void nud_CompraKilos_ValueChanged(object sender, EventArgs e)
        {
            string corteCarne;

            corteCarne = cmb_CompraCortes.Text;

            if (int.TryParse(lb_CompraPrecioPorKilo.Text, out int precioPorKilo))
            {
                lb_ComprarCostoParcial.Text = (Carne.CalcularCosto(nud_CompraKilos.Value, precioPorKilo)).ToString();

            }
        }

        private void FormComprar_TextChanged(object sender, EventArgs e)
        {
            cmb_CompraCortes.DroppedDown = false;
            cmb_CompraCortes.SelectionStart = cmb_CompraCortes.Text.Length;
            cmb_CompraCortes.DroppedDown = true;
        }

        private void btn_CompraAgregar_Click(object sender, EventArgs e)
        {

            if (ValidarCorte())
            {
                if (ValidarKilo())
                {
                    ValidarAgregar();
                }
                else
                {
                    MessageBox.Show("Debe elegir la cantidad de kilos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un corte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_CompraEfectivo_Click(object sender, EventArgs e)
        {
            bool pudoCambiarMonto = decimal.TryParse(lb_CompraMonto.Text, out decimal monto);
            bool pudoCambiarCostoFinal = decimal.TryParse(lb_ComprarCostoParcial.Text, out decimal costoFinal);

            if (ValidarCorte())
            {
                if (ValidarKilo())
                {
                    if (btn_CompraAgregar.DialogResult == DialogResult.OK)
                    {

                        if (Venta.CalcularPago(monto, costoFinal) < 0)
                        {
                            MessageBox.Show("No tiene suficiente dinero para poder realizar la operacion.\n" +
                                "Por favor, ingrese un nuevo monto y vuelva a comprar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Cliente.LimpiarListaCompras(caux);
                            this.Hide();
                            Form_MenuCliente frmMenuCliente = new Form_MenuCliente(caux);
                            frmMenuCliente.Show();
                        }
                        else
                        {
                            Tarjeta.BorrarTarjetas();
                            btn_CompraEfectivo.DialogResult = DialogResult.OK;
                            btn_CompraCredito.DialogResult = DialogResult.None;
                            btn_CompraDebito.DialogResult = DialogResult.None;
                            soundEfectivo.Play();
                            MessageBox.Show("Selecciono pagar con efectivo.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe agregar el producto para poder pagar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe elegir la cantidad de kilos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un corte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btn_CompraCredito_Click(object sender, EventArgs e)
        {
            if (ValidarMetodoPagoTarjeta() == 1)
            {
                MessageBox.Show("Selecciono pagar con tarjeta de credito.", "Cancelacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_CompraCredito.DialogResult = DialogResult.OK;
                btn_CompraEfectivo.DialogResult = DialogResult.None;
                btn_CompraDebito.DialogResult = DialogResult.None;
                soundTarjeta.Play();
                FormTarjeta frmTarjeta = new FormTarjeta();
                frmTarjeta.Show();
                foreach (Tarjeta tarjeta in Tarjeta.Tarjetas)
                {
                    tarjetaAux = tarjeta;
                    break;
                }
            }
            else if (ValidarMetodoPagoTarjeta() == -1)
            {
                MessageBox.Show("No tiene suficiente dinero para poder realizar la operacion.\n" +
                                "Por favor, ingrese un nuevo monto y vuelva a comprar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cliente.LimpiarListaCompras(caux);
                this.Hide();
                Form_MenuCliente frmMenuCliente = new Form_MenuCliente(caux);
                frmMenuCliente.Show();
            }

        }

        private void btn_CompraDebito_Click(object sender, EventArgs e)
        {

            if (ValidarMetodoPagoTarjeta() == 1)
            {
                MessageBox.Show("Selecciono pagar con tarjeta de debito.", "Cancelacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_CompraDebito.DialogResult = DialogResult.OK;
                btn_CompraEfectivo.DialogResult = DialogResult.None;
                btn_CompraCredito.DialogResult = DialogResult.None;
                soundTarjeta.Play();
                FormTarjeta frmTarjeta = new FormTarjeta();
                frmTarjeta.Show();
            }
            else if (ValidarMetodoPagoTarjeta() == -1)
            {
                MessageBox.Show("No tiene suficiente dinero para poder realizar la operacion.\n" +
                                "Por favor, ingrese un nuevo monto y vuelva a comprar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cliente.LimpiarListaCompras(caux);
                this.Hide();
                Form_MenuCliente frmMenuCliente = new Form_MenuCliente(caux);
                frmMenuCliente.Show();
            }
        }

        private void btn_CompraPagar_Click(object sender, EventArgs e)
        {
            bool pudoCambiarMonto = decimal.TryParse(lb_CompraMonto.Text, out decimal monto);
            bool pudoCambiarCostoFinal = decimal.TryParse(lb_ComprarCostoParcial.Text, out decimal costoFinal);

            if (ValidarCorte())
            {
                if (ValidarKilo())
                {
                    if (btn_CompraAgregar.DialogResult == DialogResult.OK)
                    {
                        if (pudoCambiarMonto)
                        {
                            if (pudoCambiarCostoFinal)
                            {
                                ValidarPago(monto, costoFinal);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe agregar el producto para poder pagar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe elegir la cantidad de kilos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un corte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        ///Valida que se haya seleccionado un corte 
        /// </summary>
        /// <returns></returns>
        private bool ValidarCorte()
        {
            bool retorno;

            if (cmb_CompraCortes.SelectedIndex == -1)
            {
                retorno = false;
            }
            else
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Valida que se hayan elegido los kilos
        /// </summary>
        /// <returns></returns>
        private bool ValidarKilo()
        {
            bool retorno;

            if (nud_CompraKilos.Value == 0)
            {
                retorno = false;
            }
            else
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Valida que tenga stock de carne y lo agrega a la lista de compras al producto agregado
        /// </summary>
        private void ValidarAgregar()
        {
            string tipoDeCarne = cmb_CompraCortes.SelectedItem.ToString();
            decimal kilos = nud_CompraKilos.Value;

            int precioPorKilo = Carne.CargarPrecioPorKilo(tipoDeCarne);
            int costo = Carne.CalcularCosto(kilos, precioPorKilo);

            costoParcial += costo;
            lb_ComprarCostoParcial.Text = costoParcial.ToString();
            foreach (Carne carne2 in Carne.ListaCarnes)
            {
                if (tipoDeCarne == carne2.TipoDeCarne)
                {
                    if (carne2.Stock > 0 && carne2.Stock >= kilos)
                    {
                        Carne carne1 = new Carne(tipoDeCarne, kilos);
                        caux.CargarCompra(carne1);
                        if (caux.CargarCompra(carne1))
                        {
                            foreach (Carne carne in Carne.ListaCarnes)
                            {
                                if (carne1.TipoDeCarne == carne.TipoDeCarne)
                                {
                                    carne.Stock = carne.Stock - kilos;
                                    MessageBox.Show("Agregado al carrito.");
                                    btn_CompraAgregar.DialogResult = DialogResult.OK;
                                    soundAgregar.Play();
                                    bool lineaExistente = false;
                                    foreach (string linea in rtb_CompraListaCompras.Lines)
                                    {
                                        if (linea.Contains(tipoDeCarne))
                                        {
                                            decimal pesoExistente = decimal.Parse(linea.Split(' ')[0].Replace("KG", ""));       //obtengo el peso del mismo producto seleccionado anteriormente
                                            decimal nuevoPeso = pesoExistente + kilos;                                          // sumo el peso anterior y el nuevo, para luego actualizar el rtb
                                            rtb_CompraListaCompras.Text = rtb_CompraListaCompras.Text.Replace(linea, $"{nuevoPeso}KG {tipoDeCarne}");
                                            lineaExistente = true;
                                            break;
                                        }
                                    }
                                    if (!lineaExistente)
                                    {
                                        rtb_CompraListaCompras.AppendText($"{kilos}KG {tipoDeCarne}\n");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Stock insuficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }       

        /// <summary>
        /// Valida que el monto que ingreso el usuario, alcance para comprar los productos
        /// </summary>
        /// <param name="monto"></param>
        /// <param name="costoFinal"></param>
        private void ValidarPago(decimal monto, decimal costoFinal)
        {
            if (Venta.CalcularPago(monto, costoFinal) >= 0)
            {
                caux.Gasto = costoFinal;
                if ((btn_CompraEfectivo.DialogResult == DialogResult.OK) || (btn_CompraCredito.DialogResult == DialogResult.OK) || (btn_CompraDebito.DialogResult == DialogResult.OK))
                {
                    DialogResult dialogresult = MessageBox.Show("Desea confirmar la compra?", "Confirmar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (dialogresult == DialogResult.Yes)
                    {
                        soundPagar.Play();
                        FormTicket frmTicket = new FormTicket(caux);
                        frmTicket.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Compra cancelada.", "Cancelacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione un metodo de pago.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No tiene suficiente dinero para poder realizar la operacion.\n" +
            "Por favor, ingrese un nuevo monto y vuelva a comprar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cliente.LimpiarListaCompras(caux);
                this.Hide();
                Form_MenuCliente frmMenuCliente = new Form_MenuCliente(caux);
                frmMenuCliente.Show();
            }
        }

        private int ValidarMetodoPagoTarjeta()
        {
            int retorno = 0;
            bool pudoCambiarMonto = decimal.TryParse(lb_CompraMonto.Text, out decimal monto);
            bool pudoCambiarCostoFinal = decimal.TryParse(lb_ComprarCostoParcial.Text, out decimal costoFinal);
            if (ValidarCorte())
            {
                if (ValidarKilo())
                {
                    if (btn_CompraAgregar.DialogResult == DialogResult.OK)
                    {
                        if (Venta.CalcularPago(monto, costoFinal) < 0)
                        {                    
                            retorno = -1;
                        }
                        else
                        {
                            retorno = 1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe agregar el producto para poder pagar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Debe elegir la cantidad de kilos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un corte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

            return retorno;
        }       

    }
}
