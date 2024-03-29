﻿using Entidades;
using System.Media;

namespace Form_Login
{
    public partial class FormVendedorVender : Form
    {
        decimal costoParcial = 0;
        Cliente caux;
        Vendedor vAux;
        private SoundPlayer soundCancelar;
        private SoundPlayer soundVender;
        private SoundPlayer soundAgregar;
        private SoundPlayer soundEfectivo;
        public FormVendedorVender(Vendedor vendedor)
        {
            InitializeComponent();
            vAux = vendedor;
            this.BackgroundImage = Image.FromFile(@"imagenes\img-fondoCompra2.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FormVendedorVender_Load(object sender, EventArgs e)
        {
            soundAgregar = new SoundPlayer(@"sonidos\sonido-albuche.wav");
            soundEfectivo = new SoundPlayer(@"sonidos\sonido-efectivo.wav");
            soundCancelar = new SoundPlayer(@"sonidos\sonido-meVoy.wav");
            soundVender = new SoundPlayer(@"sonidos\sonido-final.wav");
            nud_VenderKilos.Minimum = 0M;
            nud_VenderKilos.Maximum = 10;
            nud_VenderKilos.Value = 0M;
            nud_VenderKilos.Increment = 0.5M;
            lb_VenderEnZocaloCostoParcial.Text = "0";
            lb_VenderPrecioPorKilo.Visible = false;
            cmb_VenderSeleccionarCorte.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_VenderSeleccionarCorte.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_VenderSeleccionarCorte.AutoCompleteSource = AutoCompleteSource.ListItems;
            rtb_VendedorVenderClientes.AppendText(Cliente.ListarClientes());

            foreach (Carne carne in Carne.ListaCarnes)
            {
                cmb_VenderSeleccionarCorte.Items.Add(carne.TipoDeCarne);
            }

            foreach (Persona persona in Persona.ListaPersonas)
            {
                if (persona is Cliente cliente)
                {
                    cmb_VenderSeleccionarCliente.Items.Add(cliente.Correo);
                }
            }
        }

        private void btn_VendedorVenderCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResutl = MessageBox.Show("Esta seguro que desea volver al inicio?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResutl == DialogResult.Yes)
            {
                soundCancelar.Play();
                FormHeladera frmHeladera = new FormHeladera(vAux);
                frmHeladera.Show();
                this.Hide();
            }
        }

        private void FormVendedorVender_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cmb_VenderSeleccionarCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            string correo = cmb_VenderSeleccionarCliente.Text;

            cmb_VenderSeleccionarCorte.SelectedItem = null;
            Carne.LimpiarListaCompras();
            rtb_VenderMostrarCompra.Clear();
            costoParcial = 0;
            foreach (Persona persona in Persona.ListaPersonas)
            {
                if (persona is Cliente cliente)
                {
                    if (cliente.Correo == correo)
                    {
                        caux = cliente;
                    }
                }
            }
        }

        private void cmb_VenderSeleccionarCorte_SelectedValueChanged(object sender, EventArgs e)
        {
            nud_VenderKilos.Value = 0;    
            lb_VenderPrecioPorKilo.Text = (Carne.CargarPrecioPorKilo(cmb_VenderSeleccionarCorte.Text)).ToString();
            lb_VenderPrecioPorKilo.Visible = true;
        }

        private void nud_VenderKilos_ValueChanged(object sender, EventArgs e)
        {
            string corteCarne;

            corteCarne = cmb_VenderSeleccionarCorte.Text;

            if (int.TryParse(lb_VenderPrecioPorKilo.Text, out int precioPorKilo))
            {
                lb_VenderEnZocaloCostoParcial.Text = (Carne.CalcularCosto(nud_VenderKilos.Value, precioPorKilo)).ToString();

            }
        }

        private void btn_VenderAgregar_Click(object sender, EventArgs e)
        {
            
            if (!(string.IsNullOrEmpty(cmb_VenderSeleccionarCliente.Text)))
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
            else
            {
                MessageBox.Show("Debe elegir un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }           

        private void btn_VenderEfectivo_Click(object sender, EventArgs e)
        {
            decimal monto = caux.Monto;
            bool pudoCambiarCostoFinal = decimal.TryParse(lb_VenderEnZocaloCostoParcial.Text, out decimal costoFinal);

            if (ValidarCorte())
            {
                if (ValidarKilo())
                {
                    ValidarEfectivo(monto,  costoFinal);
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

        private void btn_VendedorVender_Click(object sender, EventArgs e)
        {
            
            bool pudoCambiarCostoFinal = decimal.TryParse(lb_VenderEnZocaloCostoParcial.Text, out decimal costoFinal);
            if (!(string.IsNullOrEmpty(cmb_VenderSeleccionarCliente.Text)))
            {
                decimal monto = caux.Monto;
                if (ValidarCorte())
                {
                    if (ValidarKilo())
                    {
                        ValidarVender(monto, pudoCambiarCostoFinal, costoFinal);
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
            else
            {
                MessageBox.Show("Debe elegir un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Valida que se haya elegido un corte
        /// </summary>
        /// <returns></returns>
        private bool ValidarCorte()
        {
            bool retorno;

            if (cmb_VenderSeleccionarCorte.SelectedIndex == -1)
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

            if (nud_VenderKilos.Value == 0)
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
        /// Valida el producto agregado, controlando que dicho producto tenga stock y se encuentre dentro de la lista de cortes.
        /// </summary>
        private void ValidarAgregar()
        {
            string tipoDeCarne = cmb_VenderSeleccionarCorte.SelectedItem.ToString();
            decimal kilos = nud_VenderKilos.Value;

            int precioPorKilo = Carne.CargarPrecioPorKilo(tipoDeCarne);
            int costo = Carne.CalcularCosto(kilos, precioPorKilo);

            costoParcial += costo;
            lb_VenderEnZocaloCostoParcial.Text = costoParcial.ToString();
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
                                    soundAgregar.Play();
                                    bool lineaExistente = false;
                                    foreach (string linea in rtb_VenderMostrarCompra.Lines)
                                    {
                                        if (linea.Contains(tipoDeCarne))
                                        {

                                            decimal pesoExistente = decimal.Parse(linea.Split(' ')[0].Replace("KG", ""));       //obtengo el peso del mismo producto seleccionado anteriormente


                                            decimal nuevoPeso = pesoExistente + kilos;                                          // sumo el peso anterior y el nuevo, para luego actualizar el rtb
                                            rtb_VenderMostrarCompra.Text = rtb_VenderMostrarCompra.Text.Replace(linea, $"{nuevoPeso}KG {tipoDeCarne}");
                                            lineaExistente = true;
                                            break;
                                        }
                                    }
                                    if (!lineaExistente)
                                    {
                                        rtb_VenderMostrarCompra.AppendText($"{kilos}KG {tipoDeCarne}\n");
                                    }
                                    btn_VenderAgregar.DialogResult = DialogResult.OK;
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
        /// Valida la venta, que el producto se encuentre agregado en la lista de compras y que tenga el monto suficiente
        /// </summary>
        /// <param name="monto"></param>
        /// <param name="pudoCambiarCostoFinal"></param>
        /// <param name="costoFinal"></param>
        private void ValidarVender(decimal monto, bool pudoCambiarCostoFinal, decimal costoFinal)
        {
            if (btn_VenderAgregar.DialogResult == DialogResult.OK)
            {
                if (btn_VenderEfectivo.DialogResult == DialogResult.OK)
                {
                    if (pudoCambiarCostoFinal)
                    {
                        if (Carne.CalcularPago(monto, costoFinal) >= 0)
                        {
                            Venta venta = new Venta(caux.Correo, caux.Monto, costoFinal);
                            if (venta.CargarVenta(venta))
                            {
                                soundVender.Play();
                                caux.Gasto = costoFinal;
                                MessageBox.Show($"PRODUCTOS:{Carne.MostrarCompras()}\n" +
                                    $"GASTO: {caux.Gasto}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo cargar la venta al historial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("No tiene monto suficiente para poder pagar.", "Sin saldo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe elegir un metodo de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Debe agregar el producto para poder pagar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Valida que se tenga el monto suficiente
        /// </summary>
        /// <param name="monto"></param>
        /// <param name="costoFinal"></param>
        private void ValidarEfectivo(decimal monto, decimal costoFinal)
        {
            if (btn_VenderAgregar.DialogResult == DialogResult.OK)
            {
                if (Carne.CalcularPago(monto, costoFinal) < 0)
                {
                    MessageBox.Show("No tiene suficiente dinero para poder realizar la operacion.\n" +
                        "Por favor, elija otro cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    soundEfectivo.Play();
                    btn_VenderEfectivo.DialogResult = DialogResult.OK;
                    MessageBox.Show("Selecciono pagar con efectivo.", "Metodo de pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe agregar el producto para poder pagar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
