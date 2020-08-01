using Business;
using BusinessModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTresCamadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        private void loadAll()
        {
            cbUsuario.DataSource = cbUsuarioPesquisa.DataSource = Usuario.Todos();
        }

        private void btnEndereco_Click(object sender, EventArgs e)
        {
            var endereco = new EnderecoModel();
            endereco.CPF = ((UsuarioModel)cbUsuario.SelectedValue).CPF;
            endereco.Logradouro = tbLogradouro.Text;
            endereco.Numero = tbNumero.Text;
            endereco.Cidade = tbCidade.Text;
            endereco.Estado = tbEstado.Text;
            Endereco.Gravar(endereco);

            MessageBox.Show("Endereço salvo para usuário " + cbUsuario.SelectedValue + "!");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var usuario = (UsuarioModel)cbUsuarioPesquisa.SelectedValue;
            lblNome.Text = "Nome: " + usuario.Nome;
            lblTelefone.Text = "Telefone: " + usuario.Telefone;
            lblCPF.Text = "CPF: " + usuario.CPF;
            gridEnderecos.DataSource = Endereco.PorCPF(usuario.CPF);
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {

            var usuario = new UsuarioModel();
            usuario.Nome = tbNome.Text;
            usuario.Telefone = mtbTelefone.Text;
            usuario.CPF = mtbCPF.Text;
            Usuario.Gravar(usuario);

            MessageBox.Show("Usuário salvo com sucesso!");

            tbNome.Text = "";
            mtbTelefone.Text = "";
            mtbCPF.Text = "";
            tbNome.Focus();
        }
    }
}
