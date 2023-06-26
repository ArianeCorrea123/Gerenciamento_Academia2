using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_Academia2
{
    public partial class Tela_Endereco : Form
    {
        public Tela_Endereco()
        {
            InitializeComponent();
        }

        public int ID
        {
            get
            {
                EnderecoCad enderecoCad = new EnderecoCad();
                return enderecoCad.ListarUltimoId();
            }
        }

        private void bt_Cadastrar_Endereco_Click(object sender, EventArgs e)
        {
            string rua = txb_Endereco.Text;
            string numero = txb_Numero.Text;
            string bairro = txb_Bairro.Text;
            string complemento = txb_Complemento.Text;
            string cidade = txb_Cidade.Text;
            string cep = txb_Cep.Text;
            string estado = cbx_Uf.Text;


            Endereco colab = new Endereco(rua, numero, bairro, complemento, cidade, cep, estado);

            try
            {
                EnderecoCad enderecoCad = new EnderecoCad();
                enderecoCad.Inserir(colab);
                MessageBox.Show("Cadastrado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Limpar()
        {
            txb_Endereco.Clear();
            txb_Numero.Clear();
            txb_Complemento.Clear();
            txb_Bairro.Clear();
            txb_Cidade.Clear();
            //cmb_Sexo_Aluno.Clear();
            txb_Cep.Focus();
            //cbx_Uf.Clear();
            bt_Limpar_Endereco.Enabled = false;
            bt_Fechar_Endereco.Visible = false;
            bt_Cadastrar_Endereco.Text = "CADASTRAR";
        }
        private void bt_Limpar_Endereco_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void bt_Fechar_Endereco_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
