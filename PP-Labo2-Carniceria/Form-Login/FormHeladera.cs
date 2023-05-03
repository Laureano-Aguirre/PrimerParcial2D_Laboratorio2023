using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Login
{
    public partial class FormHeladera : Form
    {
        public FormHeladera()
        {
            InitializeComponent();
        }

        private void FormHeladera_Load(object sender, EventArgs e)
        {

        }

        private void FormHeladera_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
