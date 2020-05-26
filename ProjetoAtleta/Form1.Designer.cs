namespace ProjetoAtleta
{
    partial class ProjetoAltelta
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_peso = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.btn_calcularIMC = new System.Windows.Forms.Button();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.txt_IMC = new System.Windows.Forms.TextBox();
            this.lbl_imc = new System.Windows.Forms.Label();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.btn_calcularidade = new System.Windows.Forms.Button();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.dtp_nascimento = new System.Windows.Forms.DateTimePicker();
            this.btn_criarAtleta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(62, 125);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(34, 13);
            this.lbl_peso.TabIndex = 0;
            this.lbl_peso.Text = "Peso:";
            this.lbl_peso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(65, 141);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(96, 20);
            this.txt_peso.TabIndex = 1;
            // 
            // btn_calcularIMC
            // 
            this.btn_calcularIMC.Enabled = false;
            this.btn_calcularIMC.Location = new System.Drawing.Point(65, 195);
            this.btn_calcularIMC.Name = "btn_calcularIMC";
            this.btn_calcularIMC.Size = new System.Drawing.Size(107, 22);
            this.btn_calcularIMC.TabIndex = 2;
            this.btn_calcularIMC.Text = "Calcular IMC";
            this.btn_calcularIMC.UseVisualStyleBackColor = true;
            this.btn_calcularIMC.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(177, 141);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(107, 20);
            this.txt_altura.TabIndex = 4;
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(174, 125);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(37, 13);
            this.lbl_altura.TabIndex = 3;
            this.lbl_altura.Text = "Altura:";
            // 
            // txt_IMC
            // 
            this.txt_IMC.Enabled = false;
            this.txt_IMC.Location = new System.Drawing.Point(65, 236);
            this.txt_IMC.Name = "txt_IMC";
            this.txt_IMC.Size = new System.Drawing.Size(219, 20);
            this.txt_IMC.TabIndex = 6;
            // 
            // lbl_imc
            // 
            this.lbl_imc.AutoSize = true;
            this.lbl_imc.Location = new System.Drawing.Point(62, 220);
            this.lbl_imc.Name = "lbl_imc";
            this.lbl_imc.Size = new System.Drawing.Size(51, 13);
            this.lbl_imc.TabIndex = 5;
            this.lbl_imc.Text = "Seu IMC:";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Location = new System.Drawing.Point(59, 26);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(60, 13);
            this.lbl_subtitulo.TabIndex = 7;
            this.lbl_subtitulo.Text = "Bem_vindo";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(65, 64);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(219, 20);
            this.txt_nome.TabIndex = 9;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(62, 48);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 8;
            this.lbl_nome.Text = "Nome:";
            this.lbl_nome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Location = new System.Drawing.Point(62, 86);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(105, 13);
            this.lbl_nascimento.TabIndex = 10;
            this.lbl_nascimento.Text = "Data de nascimento:";
            this.lbl_nascimento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_calcularidade
            // 
            this.btn_calcularidade.Enabled = false;
            this.btn_calcularidade.Location = new System.Drawing.Point(177, 195);
            this.btn_calcularidade.Name = "btn_calcularidade";
            this.btn_calcularidade.Size = new System.Drawing.Size(107, 22);
            this.btn_calcularidade.TabIndex = 12;
            this.btn_calcularidade.Text = "Calcular Idade";
            this.btn_calcularidade.UseVisualStyleBackColor = true;
            this.btn_calcularidade.Click += new System.EventHandler(this.btn_calcularidade_Click);
            // 
            // txt_idade
            // 
            this.txt_idade.Enabled = false;
            this.txt_idade.Location = new System.Drawing.Point(65, 275);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(219, 20);
            this.txt_idade.TabIndex = 14;
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(62, 259);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(58, 13);
            this.lbl_idade.TabIndex = 13;
            this.lbl_idade.Text = "Sua idade:";
            // 
            // dtp_nascimento
            // 
            this.dtp_nascimento.Location = new System.Drawing.Point(65, 102);
            this.dtp_nascimento.Name = "dtp_nascimento";
            this.dtp_nascimento.Size = new System.Drawing.Size(217, 20);
            this.dtp_nascimento.TabIndex = 15;
            // 
            // btn_criarAtleta
            // 
            this.btn_criarAtleta.Location = new System.Drawing.Point(65, 167);
            this.btn_criarAtleta.Name = "btn_criarAtleta";
            this.btn_criarAtleta.Size = new System.Drawing.Size(217, 22);
            this.btn_criarAtleta.TabIndex = 16;
            this.btn_criarAtleta.Text = "Cadastrar";
            this.btn_criarAtleta.UseVisualStyleBackColor = true;
            this.btn_criarAtleta.Click += new System.EventHandler(this.btn_criarAtleta_Click);
            // 
            // ProjetoAltelta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 322);
            this.Controls.Add(this.btn_criarAtleta);
            this.Controls.Add(this.dtp_nascimento);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.btn_calcularidade);
            this.Controls.Add(this.lbl_nascimento);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.txt_IMC);
            this.Controls.Add(this.lbl_imc);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.btn_calcularIMC);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.lbl_peso);
            this.Name = "ProjetoAltelta";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ProjetoAltelta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Button btn_calcularIMC;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.TextBox txt_IMC;
        private System.Windows.Forms.Label lbl_imc;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.Button btn_calcularidade;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.DateTimePicker dtp_nascimento;
        private System.Windows.Forms.Button btn_criarAtleta;
    }
}

