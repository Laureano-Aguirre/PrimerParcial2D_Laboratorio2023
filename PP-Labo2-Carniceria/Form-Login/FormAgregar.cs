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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void btn_AgregarCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Esta seguro que desea cancelar el ingreso de los datos?\n" +
                "Se borraran los datos.", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            lb_AgregarStock.Visible = false;
            lb_AgregarTipoDeCorte.Visible = false;
            lb_AgregarSeleccionarCorte.Visible = false;
            cmb_AgregarSeleccionarCorte.Visible = false;
            nud_AgregarStock.Visible = false;
            txb_AgregarTipoDeCorte.Visible = false;
            cmb_AgregarSeleccionarCorte.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_AgregarSeleccionarCorte.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_AgregarSeleccionarCorte.AutoCompleteSource = AutoCompleteSource.ListItems;
            nud_AgregarStock.Minimum = 0M;
            nud_AgregarStock.Maximum = 10;
            nud_AgregarStock.Value = 0M;
            nud_AgregarStock.Increment = 0.5M;
            foreach (Carne carne in Carne.ListaCarnes)
            {
                cmb_AgregarSeleccionarCorte.Items.Add(carne.TipoDeCarne);
            }

        }

        private void rdb_AgregarTipoDeCorte_CheckedChanged(object sender, EventArgs e)
        {
            lb_AgregarTipoDeCorte.Visible = true;
            txb_AgregarTipoDeCorte.Visible = true;
        }

        private void FormAgregar_Shown(object sender, EventArgs e)
        {
            rdb_AgregarStock.Checked = false;
            rdb_AgregarTipoDeCorte.Checked = false;
        }

        private void rdb_AgregarStock_CheckedChanged(object sender, EventArgs e)
        {
            lb_AgregarSeleccionarCorte.Visible = true;
            cmb_AgregarSeleccionarCorte.Visible = true;
            lb_AgregarStock.Visible = true;
            nud_AgregarStock.Visible = true;
        }

        private void btn_AgregarAgregar_Click(object sender, EventArgs e)
        {
            if (rdb_AgregarStock.Checked == false || rdb_AgregarTipoDeCorte.Checked == false)
            {
                if (!(string.IsNullOrEmpty(cmb_AgregarSeleccionarCorte.Text)))
                {
                    if (nud_AgregarStock.Value != 0)
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
                        else if(rdb_AgregarTipoDeCorte.Checked)
                        {
                            //Carne.ListaCarnes.Add(txb_AgregarTipoDeCorte.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar la cantidad de stock que desea reponer", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un tipo de carne", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de carne o stock.", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }



        }

        private void FormAgregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
