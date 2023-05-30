using Entidades;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Form_Login
{

    public partial class FormTarjeta : Form
    {
        private PictureBox pb_tarjetaMastercard = new PictureBox();
        private PictureBox pb_tarjetaVisa = new PictureBox();
        Cliente cliente;
        public FormTarjeta()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            txb_NumeroTarjeta.MaxLength = 16;
            txb_NumeroTarjeta.TextChanged += new EventHandler(txb_NumeroTarjeta_TextChanged);
            ConfigarTarjetaMastercard();
            ConfigurarTarjetaVisa();
            Controls.Add(pb_tarjetaMastercard);
            Controls.Add(pb_tarjetaVisa);
        }

        private void FormTarjeta_Load(object sender, EventArgs e)
        {
            Visibilidad();
        }

        private void txb_NumeroTarjeta_TextChanged(object sender, EventArgs e)
        {
            lb_NumeroEnTarjeta.Text = txb_NumeroTarjeta.Text;
            lb_NumeroEnTarjeta.Visible = true;
            DetectarTarjeta();
        }

        private void txb_NombreTitTarjeta_TextChanged(object sender, EventArgs e)
        {
            lb_NombreEnTarjeta.Text = txb_NombreTitTarjeta.Text;
            lb_NombreEnTarjeta.Visible = true;
        }

        private void txb_FechaVtoTarjeta_TextChanged(object sender, EventArgs e)
        {
            lb_FechaVtoRealEnTarjeta.Text = txb_FechaVtoTarjeta.Text;
            lb_FechaVtoEnTarjeta.Visible = true;
            lb_FechaVtoRealEnTarjeta.Visible = true;
        }

        private void btn_AceptarTarjeta_Click(object sender, EventArgs e)
        {
            string cardNum = txb_NumeroTarjeta.Text;
            string visaRegex = "^4[0-9]{6,}$";
            string mastercardRegex = "^5[1-5][0-9]{5,}$";

            ValidarTarjeta(cardNum, visaRegex, mastercardRegex);

        }

        /// <summary>
        /// Valida el ingreso de los datos de la tarjeta, tanto de los datos propios de la tarjeta, como de que banco es la tarjeta
        /// </summary>
        /// <param name="cardNum"></param>
        /// <param name="visaRegex"></param>
        /// <param name="masterCardRegex"></param>
        private void ValidarTarjeta(string cardNum, string visaRegex, string mastercardRegex)
        {
            Regex regex = new Regex("^[A-Z\\s]+$");
            if (long.TryParse(txb_NumeroTarjeta.Text, out long numeroTarjeta) && txb_NumeroTarjeta.Text.Length == 16 && (Regex.IsMatch(cardNum, visaRegex) || Regex.IsMatch(cardNum, mastercardRegex)))
            {
                if (!(string.IsNullOrEmpty(txb_NombreTitTarjeta.Text)) && !(string.IsNullOrWhiteSpace(txb_NombreTitTarjeta.Text)))
                {
                    if (regex.Match(txb_NombreTitTarjeta.Text).Success)
                    {
                        if (DateTime.TryParseExact(txb_FechaVtoTarjeta.Text, "MM/yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaVto) && FechaValida(fechaVto))
                        {
                            Tarjeta tarjeta = new Tarjeta(numeroTarjeta, txb_NombreTitTarjeta.Text, fechaVto);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Fecha de vencimiento incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar unicamente letras en el nombre del titular.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nombre de titular de tarjeta incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Numero de tarjeta incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Visibilidad()
        {
            lb_FechaVtoEnTarjeta.Visible = false;
            lb_FechaVtoRealEnTarjeta.Visible = false;
            lb_NombreEnTarjeta.Visible = false;
            lb_NumeroEnTarjeta.Visible = false;
        }

        private void ConfigarTarjetaMastercard()
        {
            pb_tarjetaMastercard.Image = Image.FromFile(@"imagenes\img-mastercard.png");
            pb_tarjetaMastercard.SizeMode = PictureBoxSizeMode.AutoSize;
            pb_tarjetaMastercard.BackColor = Color.Transparent;
            pb_tarjetaMastercard.Location = new Point(150, 40);
            pb_tarjetaMastercard.Visible = false;
        }

        private void ConfigurarTarjetaVisa()
        {
            pb_tarjetaVisa.Image = Image.FromFile(@"imagenes\img-visaCredito.png");
            pb_tarjetaVisa.SizeMode = PictureBoxSizeMode.AutoSize;
            pb_tarjetaVisa.Location = new Point(69, -30);
            pb_tarjetaVisa.Visible = false;
        }

        private void DetectarTarjeta()
        {
            string cardNum = txb_NumeroTarjeta.Text;


            string visaRegex = "^4[0-9]{6,}$"; //comienza con un cuatro, luego indica que debe haber minimo 6 numeros (del 0 al 9) y el $ indica que debe terminar con un caracter numerico
            string mastercardRegex = "^5[1-5][0-9]{5,}$"; // comienza con un 5, seguido de numeros entre el 1 y el 5 (al menos 5 nnumeros)


            if (Regex.IsMatch(cardNum, visaRegex)) //chequea con un metodo del using RegularExpressions, si el numero de tarjeta ingresado, va coincidiendo con la expresion regular de VISA, en este caso
            {
                pb_tarjetaVisa.Visible = true;
                lb_FechaVtoEnTarjeta.BackColor = Color.FromArgb(0, 64, 120);
                lb_FechaVtoRealEnTarjeta.BackColor = Color.FromArgb(0, 64, 120);
                lb_NombreEnTarjeta.BackColor = Color.FromArgb(0, 64, 120);
                lb_NumeroEnTarjeta.BackColor = Color.FromArgb(0, 64, 120);
            }
            else if (Regex.IsMatch(cardNum, mastercardRegex))
            {
                pb_tarjetaMastercard.Visible = true;
                lb_FechaVtoEnTarjeta.BackColor = Color.FromArgb(54, 66, 80);
                lb_FechaVtoRealEnTarjeta.BackColor = Color.FromArgb(54, 66, 80);
                lb_NombreEnTarjeta.BackColor = Color.FromArgb(54, 66, 80);
                lb_NumeroEnTarjeta.BackColor = Color.FromArgb(54, 66, 80);
            }
        }

        private void btn_CancelarTarjeta_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Esta seguro que desea cancelar el ingreso de los datos?\n" +
                "Se borraran los datos.", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool FechaValida(DateTime fecha)
        {
            DateTime fechaActual = DateTime.Now;

            if(fecha.CompareTo(fechaActual) < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
