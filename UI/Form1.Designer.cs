namespace AppTresCamadas
{
    partial class Form1
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
            this.btnCadastrarEndereco = new System.Windows.Forms.Button();
            this.tbLogradouro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbUsuarioPesquisa = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gridEnderecos = new System.Windows.Forms.DataGridView();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.gbCadastroUsuario = new System.Windows.Forms.GroupBox();
            this.gbCadastroEndereco = new System.Windows.Forms.GroupBox();
            this.gbResultadoPesquisa = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnderecos)).BeginInit();
            this.gbCadastroUsuario.SuspendLayout();
            this.gbCadastroEndereco.SuspendLayout();
            this.gbResultadoPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrarEndereco
            // 
            this.btnCadastrarEndereco.Location = new System.Drawing.Point(12, 163);
            this.btnCadastrarEndereco.Name = "btnCadastrarEndereco";
            this.btnCadastrarEndereco.Size = new System.Drawing.Size(138, 23);
            this.btnCadastrarEndereco.TabIndex = 25;
            this.btnCadastrarEndereco.Text = "Cadastrar Endereço";
            this.btnCadastrarEndereco.UseVisualStyleBackColor = true;
            this.btnCadastrarEndereco.Click += new System.EventHandler(this.btnEndereco_Click);
            // 
            // tbLogradouro
            // 
            this.tbLogradouro.Location = new System.Drawing.Point(88, 46);
            this.tbLogradouro.Name = "tbLogradouro";
            this.tbLogradouro.Size = new System.Drawing.Size(276, 20);
            this.tbLogradouro.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Logradouro:";
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(88, 125);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(276, 20);
            this.tbEstado.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Estado:";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(88, 74);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(276, 20);
            this.tbNumero.TabIndex = 22;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(88, 99);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(276, 20);
            this.tbCidade.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Usuário:";
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(86, 17);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(278, 21);
            this.cbUsuario.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Usuário:";
            // 
            // cbUsuarioPesquisa
            // 
            this.cbUsuarioPesquisa.FormattingEnabled = true;
            this.cbUsuarioPesquisa.Location = new System.Drawing.Point(69, 22);
            this.cbUsuarioPesquisa.Name = "cbUsuarioPesquisa";
            this.cbUsuarioPesquisa.Size = new System.Drawing.Size(183, 21);
            this.cbUsuarioPesquisa.TabIndex = 28;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(258, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(77, 21);
            this.btnPesquisar.TabIndex = 29;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // gridEnderecos
            // 
            this.gridEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEnderecos.Location = new System.Drawing.Point(9, 152);
            this.gridEnderecos.Name = "gridEnderecos";
            this.gridEnderecos.Size = new System.Drawing.Size(326, 166);
            this.gridEnderecos.TabIndex = 30;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(6, 116);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 31;
            this.lblCPF.Text = "CPF";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(6, 91);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 32;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 33;
            this.lblNome.Text = "Nome";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nome:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Telefone:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "CPF:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(73, 35);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(291, 20);
            this.tbNome.TabIndex = 15;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(73, 63);
            this.mtbTelefone.Mask = "(99) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(182, 20);
            this.mtbTelefone.TabIndex = 16;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(73, 88);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(182, 20);
            this.mtbCPF.TabIndex = 17;
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(12, 124);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(126, 23);
            this.btnCadastrarUsuario.TabIndex = 18;
            this.btnCadastrarUsuario.Text = "Cadastrar Usuário";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // gbCadastroUsuario
            // 
            this.gbCadastroUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gbCadastroUsuario.Controls.Add(this.tbNome);
            this.gbCadastroUsuario.Controls.Add(this.label10);
            this.gbCadastroUsuario.Controls.Add(this.label11);
            this.gbCadastroUsuario.Controls.Add(this.label12);
            this.gbCadastroUsuario.Controls.Add(this.mtbTelefone);
            this.gbCadastroUsuario.Controls.Add(this.mtbCPF);
            this.gbCadastroUsuario.Controls.Add(this.btnCadastrarUsuario);
            this.gbCadastroUsuario.Location = new System.Drawing.Point(12, 2);
            this.gbCadastroUsuario.Name = "gbCadastroUsuario";
            this.gbCadastroUsuario.Size = new System.Drawing.Size(387, 167);
            this.gbCadastroUsuario.TabIndex = 34;
            this.gbCadastroUsuario.TabStop = false;
            this.gbCadastroUsuario.Text = "Cadastro de Usuário";
            // 
            // gbCadastroEndereco
            // 
            this.gbCadastroEndereco.Controls.Add(this.label5);
            this.gbCadastroEndereco.Controls.Add(this.label3);
            this.gbCadastroEndereco.Controls.Add(this.label2);
            this.gbCadastroEndereco.Controls.Add(this.label1);
            this.gbCadastroEndereco.Controls.Add(this.tbLogradouro);
            this.gbCadastroEndereco.Controls.Add(this.tbNumero);
            this.gbCadastroEndereco.Controls.Add(this.tbCidade);
            this.gbCadastroEndereco.Controls.Add(this.label4);
            this.gbCadastroEndereco.Controls.Add(this.btnCadastrarEndereco);
            this.gbCadastroEndereco.Controls.Add(this.cbUsuario);
            this.gbCadastroEndereco.Controls.Add(this.tbEstado);
            this.gbCadastroEndereco.Location = new System.Drawing.Point(12, 175);
            this.gbCadastroEndereco.Name = "gbCadastroEndereco";
            this.gbCadastroEndereco.Size = new System.Drawing.Size(387, 192);
            this.gbCadastroEndereco.TabIndex = 0;
            this.gbCadastroEndereco.TabStop = false;
            this.gbCadastroEndereco.Text = "Cadastro de Endereço";
            // 
            // gbResultadoPesquisa
            // 
            this.gbResultadoPesquisa.Controls.Add(this.label6);
            this.gbResultadoPesquisa.Controls.Add(this.cbUsuarioPesquisa);
            this.gbResultadoPesquisa.Controls.Add(this.lblCPF);
            this.gbResultadoPesquisa.Controls.Add(this.btnPesquisar);
            this.gbResultadoPesquisa.Controls.Add(this.lblTelefone);
            this.gbResultadoPesquisa.Controls.Add(this.gridEnderecos);
            this.gbResultadoPesquisa.Controls.Add(this.lblNome);
            this.gbResultadoPesquisa.Location = new System.Drawing.Point(415, 2);
            this.gbResultadoPesquisa.Name = "gbResultadoPesquisa";
            this.gbResultadoPesquisa.Size = new System.Drawing.Size(355, 365);
            this.gbResultadoPesquisa.TabIndex = 35;
            this.gbResultadoPesquisa.TabStop = false;
            this.gbResultadoPesquisa.Text = "Resultado Pesquisa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 374);
            this.Controls.Add(this.gbResultadoPesquisa);
            this.Controls.Add(this.gbCadastroEndereco);
            this.Controls.Add(this.gbCadastroUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEnderecos)).EndInit();
            this.gbCadastroUsuario.ResumeLayout(false);
            this.gbCadastroUsuario.PerformLayout();
            this.gbCadastroEndereco.ResumeLayout(false);
            this.gbCadastroEndereco.PerformLayout();
            this.gbResultadoPesquisa.ResumeLayout(false);
            this.gbResultadoPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrarEndereco;
        private System.Windows.Forms.TextBox tbLogradouro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbUsuarioPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView gridEnderecos;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.GroupBox gbCadastroUsuario;
        private System.Windows.Forms.GroupBox gbCadastroEndereco;
        private System.Windows.Forms.GroupBox gbResultadoPesquisa;
    }
}

