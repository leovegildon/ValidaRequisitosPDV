using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ValidaRequisitosPDV
{
    public partial class FormDetalhe : Form
    {
        public FormDetalhe()
        {
            InitializeComponent();
        }

        public string textoDetalhe;

        public void richDetalhe_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDetalhe_Load(object sender, EventArgs e)
        {
            richDetalhe.Text = textoDetalhe;
        }
    }
}
