using Entidades;

namespace Form_Login
{
    public partial class FormComprar : Form
    {
        Tarjeta tarjetaAux;
        Cliente caux;
        decimal costoParcial = 0;

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
                Carne.LimpiarListaCompras();
                Form_MenuCliente form_MenuCliente = new Form_MenuCliente(caux);
                form_MenuCliente.Show();
                this.Hide();
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

        /// <summary>
        /// Muestra y ubica los label
        /// </summary>
        /// <param name="corte"></param>
        private void VisibilizarCortes(string corte)
        {

            foreach (Carne carne in Carne.ListaDeCompras)
            {
                if (corte == "Tira de asado")
                {
                    lb_CompraTiraAsado.Text = $"{carne.Kilos}KG {carne.TipoDeCarne}";
                    lb_CompraTiraAsado.Visible = true;
                    lb_CompraTiraAsado.BackColor = Color.FromArgb(191, 148, 113);
                }
                else if (corte == "Colita de cuadril")
                {
                    lb_CompraColitaDeCuadril.Text = $"{carne.Kilos}KG {carne.TipoDeCarne}";
                    lb_CompraColitaDeCuadril.Visible = true;
                    lb_CompraColitaDeCuadril.BackColor = Color.FromArgb(191, 148, 113);
                }
                else if (corte == "Bola de lomo")
                {
                    lb_CompraBolaLomo.Text = $"{carne.Kilos}KG {carne.TipoDeCarne}";
                    lb_CompraBolaLomo.Visible = true;
                    lb_CompraBolaLomo.BackColor = Color.FromArgb(191, 148, 113);
                }
                else if (corte == "Bife de chorizo")
                {
                    lb_CompraBifeChorizo.Text = $"{carne.Kilos}KG {carne.TipoDeCarne}";
                    lb_CompraBifeChorizo.Visible = true;
                    lb_CompraBifeChorizo.BackColor = Color.FromArgb(191, 148, 113);
                }
                else if (corte == "Ojo de bife")
                {
                    lb_CompraOjoBife.Text = $"{carne.Kilos}KG {carne.TipoDeCarne}";
                    lb_CompraOjoBife.Visible = true;
                    lb_CompraOjoBife.BackColor = Color.FromArgb(191, 148, 113);
                }
                else if (corte == "Entraña")
                {
                    lb_CompraEntrania.Text = $"{carne.Kilos}KG {carne.TipoDeCarne}";
                    lb_CompraEntrania.Visible = true;
                    lb_CompraEntrania.BackColor = Color.FromArgb(191, 148, 113);
                }
                else if (corte == "Tortuguita")
                {
                    lb_CompraTortuguita.Text = $"{carne.Kilos}KG {carne.TipoDeCarne}";
                    lb_CompraTortuguita.Visible = true;
                    lb_CompraTortuguita.BackColor = Color.FromArgb(191, 148, 113);
                }
                else if (corte == "Falda")
                {
                    lb_CompraFalda.Text = $"{carne.Kilos}KG {carne.TipoDeCarne}";
                    lb_CompraFalda.Visible = true;
                    lb_CompraFalda.BackColor = Color.FromArgb(191, 148, 113);
                }
            }
        }

        private void btn_CompraCredito_Click(object sender, EventArgs e)
        {
            if (ValidarMetodoPagoTarjeta())
            {
                MessageBox.Show("Selecciono pagar con tarjeta de credito.", "Cancelacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_CompraCredito.DialogResult = DialogResult.OK;
                btn_CompraEfectivo.DialogResult = DialogResult.None;
                btn_CompraDebito.DialogResult = DialogResult.None;
                FormTarjeta frmTarjeta = new FormTarjeta();
                frmTarjeta.Show();
                foreach(Tarjeta tarjeta in Tarjeta.Tarjetas)
                {
                    tarjetaAux = tarjeta;
                    break;
                }
            }
            else
            {
                MessageBox.Show("No tiene suficiente dinero para poder realizar la operacion.\n" +
                                "Por favor, ingrese un nuevo monto y vuelva a comprar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Carne.LimpiarListaCompras();
                this.Hide();
                Form_MenuCliente frmMenuCliente = new Form_MenuCliente(caux);
                frmMenuCliente.Show();
            }

        }

        private void btn_CompraDebito_Click(object sender, EventArgs e)
        {

            if(ValidarMetodoPagoTarjeta())
            {
                MessageBox.Show("Selecciono pagar con tarjeta de debito.", "Cancelacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_CompraDebito.DialogResult = DialogResult.OK;
                btn_CompraEfectivo.DialogResult = DialogResult.None;
                btn_CompraCredito.DialogResult = DialogResult.None;
                FormTarjeta frmTarjeta = new FormTarjeta();
                frmTarjeta.Show();
            }
            else
            {
                MessageBox.Show("No tiene suficiente dinero para poder realizar la operacion.\n" +
                                "Por favor, ingrese un nuevo monto y vuelva a comprar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Carne.LimpiarListaCompras();
                this.Hide();
                Form_MenuCliente frmMenuCliente = new Form_MenuCliente(caux);
                frmMenuCliente.Show();
            }
        }

        private void btn_CompraAgregar_Click(object sender, EventArgs e)
        {

            if (ValidarCorte())
            {
                if (ValidarKilo())
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
                                if (carne1.CargarCompra(carne1))
                                {
                                    foreach (Carne carne in Carne.ListaCarnes)
                                    {
                                        if (carne1.TipoDeCarne == carne.TipoDeCarne)
                                        {
                                            carne.Stock = carne.Stock - kilos;
                                            MessageBox.Show("Agregado al carrito.");
                                            btn_CompraAgregar.DialogResult = DialogResult.OK;
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
                    VisibilizarCortes(tipoDeCarne);
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
        /// Valida que el monto que ingreso el usuario, alcance para comprar los productos
        /// </summary>
        /// <param name="monto"></param>
        /// <param name="costoFinal"></param>
        private void ValidarPago(decimal monto, decimal costoFinal)
        {
            if (Carne.CalcularPago(monto, costoFinal) >= 0)
            {
                caux.Gasto = costoFinal;
                if ((btn_CompraEfectivo.DialogResult == DialogResult.OK) || (btn_CompraCredito.DialogResult == DialogResult.OK) || (btn_CompraDebito.DialogResult == DialogResult.OK))
                {
                    DialogResult dialogresult = MessageBox.Show("Desea confirmar la compra?", "Confirmar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (dialogresult == DialogResult.Yes)
                    {
                        FormTicket frmTicket = new FormTicket(caux);
                        frmTicket.Show();
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
                Carne.LimpiarListaCompras();
                this.Hide();
                Form_MenuCliente frmMenuCliente = new Form_MenuCliente(caux);
                frmMenuCliente.Show();
            }
        }

        private bool ValidarMetodoPagoTarjeta()
        {
            bool retorno = false;
            bool pudoCambiarMonto = decimal.TryParse(lb_CompraMonto.Text, out decimal monto);
            bool pudoCambiarCostoFinal = decimal.TryParse(lb_ComprarCostoParcial.Text, out decimal costoFinal);
            if (ValidarCorte())
            {
                if (ValidarKilo())
                {
                    if (btn_CompraAgregar.DialogResult == DialogResult.OK)
                    {
                        if (Carne.CalcularPago(monto, costoFinal) < 0)
                        {
                            retorno = false;
                        }
                        else
                        {
                            retorno = true;
                        }
                    }
                }
            }

            return retorno;
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

                        if (Carne.CalcularPago(monto, costoFinal) < 0)
                        {
                            MessageBox.Show("No tiene suficiente dinero para poder realizar la operacion.\n" +
                                "Por favor, ingrese un nuevo monto y vuelva a comprar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Carne.LimpiarListaCompras();
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

        private void FormComprar_TextChanged(object sender, EventArgs e)
        {
            cmb_CompraCortes.DroppedDown = false;
            cmb_CompraCortes.SelectionStart = cmb_CompraCortes.Text.Length;
            cmb_CompraCortes.DroppedDown = true;
        }


    }
}
