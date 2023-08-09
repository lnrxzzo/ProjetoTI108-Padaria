using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaCarmel
{
    public partial class FrmPesquisarFuncionarios : Form
    {
        public FrmPesquisarFuncionarios()
        {
            InitializeComponent();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked)
            {
                txtDescricao.Focus();
                lstPesquisar.Items.Clear();
                lstPesquisar.Items.Add(txtDescricao.Text);
            }
            if (rdbNome.Checked)
            {
                lstPesquisar.Items.Clear();
                lstPesquisar.Items.Add(txtDescricao.Text);
            }

        }
        public void limparCampos()
        {
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Clear();
            lstPesquisar.Items.Clear();
            txtDescricao.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
