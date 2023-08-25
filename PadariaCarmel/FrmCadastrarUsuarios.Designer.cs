
namespace PadariaCarmel
{
    partial class FrmCadastrarUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarUsuarios));
            this.pnlFuncionarios = new System.Windows.Forms.Panel();
            this.lblFuncNCad = new System.Windows.Forms.Label();
            this.lstFuncNCad = new System.Windows.Forms.ListBox();
            this.txtContraSenha = new System.Windows.Forms.TextBox();
            this.lblContraSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtCodFunc = new System.Windows.Forms.TextBox();
            this.pnlFuncionarios.SuspendLayout();
            this.pnlCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFuncionarios
            // 
            this.pnlFuncionarios.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlFuncionarios.Controls.Add(this.txtCodFunc);
            this.pnlFuncionarios.Controls.Add(this.lblFuncNCad);
            this.pnlFuncionarios.Controls.Add(this.lstFuncNCad);
            this.pnlFuncionarios.Controls.Add(this.txtContraSenha);
            this.pnlFuncionarios.Controls.Add(this.lblContraSenha);
            this.pnlFuncionarios.Controls.Add(this.txtSenha);
            this.pnlFuncionarios.Controls.Add(this.lblSenha);
            this.pnlFuncionarios.Controls.Add(this.txtNome);
            this.pnlFuncionarios.Controls.Add(this.lblNome);
            this.pnlFuncionarios.Controls.Add(this.txtCodigo);
            this.pnlFuncionarios.Controls.Add(this.lblCodigo);
            this.pnlFuncionarios.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFuncionarios.Location = new System.Drawing.Point(4, 3);
            this.pnlFuncionarios.Name = "pnlFuncionarios";
            this.pnlFuncionarios.Size = new System.Drawing.Size(779, 454);
            this.pnlFuncionarios.TabIndex = 0;
            // 
            // lblFuncNCad
            // 
            this.lblFuncNCad.AutoSize = true;
            this.lblFuncNCad.Location = new System.Drawing.Point(463, 97);
            this.lblFuncNCad.Name = "lblFuncNCad";
            this.lblFuncNCad.Size = new System.Drawing.Size(188, 20);
            this.lblFuncNCad.TabIndex = 12;
            this.lblFuncNCad.Text = "Funcionários não cadastrados";
            // 
            // lstFuncNCad
            // 
            this.lstFuncNCad.FormattingEnabled = true;
            this.lstFuncNCad.ItemHeight = 20;
            this.lstFuncNCad.Location = new System.Drawing.Point(467, 120);
            this.lstFuncNCad.Name = "lstFuncNCad";
            this.lstFuncNCad.Size = new System.Drawing.Size(275, 304);
            this.lstFuncNCad.TabIndex = 11;
            this.lstFuncNCad.SelectedIndexChanged += new System.EventHandler(this.lstFuncNCad_SelectedIndexChanged);
            // 
            // txtContraSenha
            // 
            this.txtContraSenha.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtContraSenha.Location = new System.Drawing.Point(19, 249);
            this.txtContraSenha.MaxLength = 14;
            this.txtContraSenha.Name = "txtContraSenha";
            this.txtContraSenha.PasswordChar = 'l';
            this.txtContraSenha.Size = new System.Drawing.Size(277, 25);
            this.txtContraSenha.TabIndex = 4;
            // 
            // lblContraSenha
            // 
            this.lblContraSenha.AutoSize = true;
            this.lblContraSenha.Location = new System.Drawing.Point(15, 226);
            this.lblContraSenha.Name = "lblContraSenha";
            this.lblContraSenha.Size = new System.Drawing.Size(87, 20);
            this.lblContraSenha.TabIndex = 10;
            this.lblContraSenha.Text = "Contra-senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenha.Location = new System.Drawing.Point(19, 183);
            this.txtSenha.MaxLength = 14;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'l';
            this.txtSenha.Size = new System.Drawing.Size(277, 25);
            this.txtSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(15, 160);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 20);
            this.lblSenha.TabIndex = 8;
            this.lblSenha.Text = "Senha";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(19, 120);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(320, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 97);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(19, 59);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(102, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(15, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCRUD.Controls.Add(this.btnVoltar);
            this.pnlCRUD.Controls.Add(this.btnLimpar);
            this.pnlCRUD.Controls.Add(this.btnPesquisar);
            this.pnlCRUD.Controls.Add(this.btnExcluir);
            this.pnlCRUD.Controls.Add(this.btnAlterar);
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Controls.Add(this.btnNovo);
            this.pnlCRUD.Location = new System.Drawing.Point(5, 463);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(778, 90);
            this.pnlCRUD.TabIndex = 5;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(679, 43);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 36);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(566, 43);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 36);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(453, 43);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(90, 36);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(340, 43);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 36);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(233, 43);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 36);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(122, 43);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(90, 36);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(9, 43);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 36);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Location = new System.Drawing.Point(81, 342);
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(20, 26);
            this.txtCodFunc.TabIndex = 13;
            // 
            // FrmCadastrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 565);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.pnlFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmCadastrarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuarios";
            this.Load += new System.EventHandler(this.FrmCadastrarUsuarios_Load);
            this.pnlFuncionarios.ResumeLayout(false);
            this.pnlFuncionarios.PerformLayout();
            this.pnlCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFuncionarios;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtContraSenha;
        private System.Windows.Forms.Label lblContraSenha;
        private System.Windows.Forms.Label lblFuncNCad;
        private System.Windows.Forms.ListBox lstFuncNCad;
        private System.Windows.Forms.TextBox txtCodFunc;
    }
}