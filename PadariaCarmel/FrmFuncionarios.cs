using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace PadariaCarmel
{
    public partial class FrmFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public FrmFuncionarios()
        {
            InitializeComponent();
        }
        public FrmFuncionarios(string nome)
        {
            InitializeComponent();
            txtNome.Text = nome;
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            desabilitarCampos();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }
        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEndereço.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEmail.Enabled = false;

            mskCEP.Enabled = false;
            mskCPF.Enabled = false;
            mskTelefone.Enabled = false;

            cbbEstado.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }


        public void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEndereço.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;


            mskCEP.Enabled = true;
            mskCPF.Enabled = true;
            mskTelefone.Enabled = true;

            cbbEstado.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;

            txtNome.Focus();
        }
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEndereço.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEmail.Clear();


            mskCEP.Clear();
            mskCPF.Clear();
            mskTelefone.Clear();

            cbbEstado.Text = "";

            txtNome.Focus();
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            CadastrarFuncionarios();

            MessageBox.Show("Usuário cadastrado com sucesso!", "Messagem do sistema.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            btnNovo.Enabled = true;
            limparCampos();
        }

        //cadastrar funcionarios
        public void CadastrarFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbFuncionarios(nome, email, telCel, cpf, endereco, numero, bairro, cidade, estado, cep) values(@nome, @email, @telCel, @cpf, @endereco, @numero, @bairro, @cidade, @estado, @cep);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome" , MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@email" , MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            comm.Parameters.Add("@telCel" , MySqlDbType.VarChar, 15).Value = mskTelefone.Text;
            comm.Parameters.Add("@cpf" , MySqlDbType.VarChar, 14).Value = mskCPF.Text;
            comm.Parameters.Add("@endereco" , MySqlDbType.VarChar, 100).Value = txtEndereço.Text;
            comm.Parameters.Add("@numero" , MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@bairro" , MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            comm.Parameters.Add("@cidade" , MySqlDbType.VarChar, 100).Value = txtCidade.Text;
            comm.Parameters.Add("@estado" , MySqlDbType.VarChar, 2).Value = cbbEstado.Text;
            comm.Parameters.Add("@cep" , MySqlDbType.VarChar, 9).Value = mskCEP.Text;

            comm.Connection = Conectar.obterConexao();
            int res = comm.ExecuteNonQuery();
            Conectar.fecharConexao();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        public void buscaCEP(string numCEP)
        {
            WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();
            try
            {
                WSCorreios.enderecoERP endereco = ws.consultaCEP(numCEP);

                txtEndereço.Text = endereco.end;
                txtBairro.Text = endereco.bairro;
                txtCidade.Text = endereco.cidade;
                cbbEstado.Text = endereco.uf;


            }
            catch (Exception)
            {
                MessageBox.Show("Insira um CEP válido!", "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                mskCEP.Focus();
                mskCEP.Text = "";
            }
        }

        private void mskCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscaCEP(mskCEP.Text);
                txtNumero.Focus();
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisarFuncionarios abrir = new FrmPesquisarFuncionarios();
            abrir.Show();
            this.Hide();
        }
    }
}
