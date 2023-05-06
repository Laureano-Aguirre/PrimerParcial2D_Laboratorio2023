using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Entidades;

namespace Form_Login
{
    public partial class FormTarjeta : Form
    {
        private PictureBox pb_tarjetaMastercard = new PictureBox();
        private PictureBox pb_tarjetaVisa = new PictureBox();
        public FormTarjeta()
        {
            InitializeComponent();
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
            lb_NombreEnTarjeta.Text=txb_NombreTitTarjeta.Text;
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
            if(long.TryParse(txb_NumeroTarjeta.Text, out long numeroTarjeta))
            {
                if(DateTime.TryParseExact(txb_FechaVtoTarjeta.Text, "MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaVto))
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
            pb_tarjetaVisa.Location = new Point(69,-30);
            pb_tarjetaVisa.Visible = false;
        }

        private void DetectarTarjeta()
        {
            string cardNum = txb_NumeroTarjeta.Text;

            // regular expressions to match first digits of credit/debit cards
            string visaRegex = "^4[0-9]{6,}$";
            string mastercardRegex = "^5[1-5][0-9]{5,}$";

            // check if cardNum matches any of the regex patterns
            if (Regex.IsMatch(cardNum, visaRegex))
            {
                pb_tarjetaVisa.Visible = true;
                lb_FechaVtoEnTarjeta.BackColor = Color.FromArgb(0,64,120);
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
    }
}
