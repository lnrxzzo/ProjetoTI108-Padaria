
namespace PadariaCarmel
{
    partial class frmCalcula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalcula));
            this.gpbOperacoes = new System.Windows.Forms.GroupBox();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbSoma = new System.Windows.Forms.RadioButton();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.gpbOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbOperacoes
            // 
            this.gpbOperacoes.Controls.Add(this.rdbDivisao);
            this.gpbOperacoes.Controls.Add(this.rdbMultiplicacao);
            this.gpbOperacoes.Controls.Add(this.rdbSubtracao);
            this.gpbOperacoes.Controls.Add(this.rdbSoma);
            this.gpbOperacoes.Location = new System.Drawing.Point(175, 62);
            this.gpbOperacoes.Name = "gpbOperacoes";
            this.gpbOperacoes.Size = new System.Drawing.Size(339, 223);
            this.gpbOperacoes.TabIndex = 2;
            this.gpbOperacoes.TabStop = false;
            this.gpbOperacoes.Text = "Operações";
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.Location = new System.Drawing.Point(25, 161);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(60, 17);
            this.rdbDivisao.TabIndex = 6;
            this.rdbDivisao.TabStop = true;
            this.rdbDivisao.Text = "Divisão";
            this.rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.Location = new System.Drawing.Point(25, 114);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(87, 17);
            this.rdbMultiplicacao.TabIndex = 5;
            this.rdbMultiplicacao.TabStop = true;
            this.rdbMultiplicacao.Text = "Multiplicação";
            this.rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.Location = new System.Drawing.Point(25, 68);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(74, 17);
            this.rdbSubtracao.TabIndex = 4;
            this.rdbSubtracao.TabStop = true;
            this.rdbSubtracao.Text = "Subtração";
            this.rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbSoma
            // 
            this.rdbSoma.AutoSize = true;
            this.rdbSoma.Location = new System.Drawing.Point(25, 22);
            this.rdbSoma.Name = "rdbSoma";
            this.rdbSoma.Size = new System.Drawing.Size(52, 17);
            this.rdbSoma.TabIndex = 3;
            this.rdbSoma.TabStop = true;
            this.rdbSoma.Text = "Soma";
            this.rdbSoma.UseVisualStyleBackColor = true;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(90, 74);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(53, 13);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Número 1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(90, 128);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(53, 13);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "Número 2";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(90, 95);
            this.txtNum1.MaxLength = 10;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(61, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(90, 149);
            this.txtNum2.MaxLength = 10;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(61, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(531, 204);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 38);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sai&r";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(531, 96);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 38);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(531, 149);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 38);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(96, 239);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Resultado";
            // 
            // lblResposta
            // 
            this.lblResposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResposta.Location = new System.Drawing.Point(88, 259);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(63, 22);
            this.lblResposta.TabIndex = 11;
            // 
            // frmCalcula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 457);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.gpbOperacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCalcula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padaria - Calculadora";
            this.gpbOperacoes.ResumeLayout(false);
            this.gpbOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbOperacoes;
        private System.Windows.Forms.RadioButton rdbSoma;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}