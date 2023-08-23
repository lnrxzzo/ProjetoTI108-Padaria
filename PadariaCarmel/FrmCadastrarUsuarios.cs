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
    public partial class FrmCadastrarUsuarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public FrmCadastrarUsuarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }
        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtContraSenha.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            carregaFuncionarios();


        }
        public void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtContraSenha.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;

            txtNome.Focus();
        }



        private void FrmCadastrarUsuarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtSenha.Text.Equals("   .   .   -") || txtContraSenha.Text.Equals("     -"))

            {

                MessageBox.Show("Preenchimento obrigatório!", "Messagem do sistema.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                txtNome.Focus();



            }
            else
            {
                CadastrarUsuarios();

                MessageBox.Show("Cadastrado com sucesso!    ", "Menssagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                desabilitarCampos();
                btnNovo.Enabled = true;
                limparCampos();
            }
        }
        public void CadastrarUsuarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuarios(nome, senha, codFunc)values(@nome, @senha, @codFunc);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = txtNome.Text;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 14).Value = txtSenha.Text;


            comm.Connection = Conectar.obterConexao();
            int res = comm.ExecuteNonQuery();
            Conectar.fecharConexao();
        }

        public void carregaFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios order by nome asc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conectar.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            lstFuncNCad.Items.Clear();

            while (DR.Read())
            {
                lstFuncNCad.Items.Add(DR.GetString(0));
            }
            Conectar.fecharConexao();

        }
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtContraSenha.Clear();
            txtSenha.Clear();



            txtNome.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
    }
}
