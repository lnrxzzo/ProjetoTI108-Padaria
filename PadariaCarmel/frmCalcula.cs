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
    public partial class frmCalcula : Form
    {
        public frmCalcula()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum1.Focus();
            txtNum2.Clear();
            lblResposta.Text = "";
            rdbSoma.Checked = false;
            rdbSubtracao.Checked = false;
            rdbDivisao.Checked = false;
            rdbMultiplicacao.Checked = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;

            try
            {

                num1 = Convert.ToDouble(txtNum1.Text);
                num2 = Convert.ToDouble(txtNum2.Text);


                if (rdbSoma.Checked)
                {
                    resp = num1 + num2;
                }
                else


                if (rdbSubtracao.Checked)
                {
                    resp = num1 - num2;
                }

                if (rdbDivisao.Checked)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Impossível dividir por 0");
                        txtNum1.Text = "";
                        txtNum2.Text = "";
                        lblResposta.Text = "";
                        rdbDivisao.Checked = false;
                        txtNum1.Focus();
                    }
                    else
                    {
                        resp = num1 / num2;
                    }
                }
                if (rdbMultiplicacao.Checked)
                {
                    resp = num1 * num2;
                }

                if (rdbDivisao.Checked || rdbMultiplicacao.Checked || rdbSoma.Checked || rdbSubtracao.Checked)
                {
                    lblResposta.Text = resp.ToString();
                }
                else
                {
                    MessageBox.Show("Escolha uma operação");
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Insira somente números");
                txtNum1.Text = "";
                txtNum2.Text = "";
                txtNum1.Focus();

            }
        }

    }
}

