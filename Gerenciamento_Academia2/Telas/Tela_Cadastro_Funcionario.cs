using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gerenciamento_Academia2
{
    public partial class Tela_Cadastro_Funcionario : Form
    {
        private int Cod_Func, Cod_End;
        public Tela_Cadastro_Funcionario()
        {
            InitializeComponent();
            bt_Cadastrar.Enabled = false;
        }

        private void bt_Endereco_Click(object sender, EventArgs e)
        {
            Tela_Endereco tela_Endereco = new Tela_Endereco();
            tela_Endereco.ShowDialog();

            Cod_End = tela_Endereco.ID;
            bt_Cadastrar.Enabled = true;
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            string nome = txb_Nome_Func.Text;
            string tel = mtb_Tel_Func.Text;
            string rg = txb_Rg_Func.Text;
            string cpf = mtb_Cpf_Func.Text;
            string sexo = cmb_Sexo_Func.Text;
            string data_niver = mtb_DataNiver_Func.Text;
            string senha = txb_Senha_Func.Text;
            string nivel_acesso = cbx_Nivel_acesso.Text;


            Funcionario funcionario = new Funcionario(nome, sexo, tel, rg, cpf, data_niver, senha, nivel_acesso, Cod_End);

            try
            {
                FuncionarioCad funcionarioCad = new FuncionarioCad();
                funcionarioCad.Inserir(funcionario);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateListView();
            Limpar();

        }


        private void UpdateListView()
        {
            listViewFunc.Items.Clear();
            FuncionarioCad funcionarioCad = new FuncionarioCad();

            List<Funcionario> funcionario = funcionarioCad.ListarFuncionario();
            if (funcionario.Count > 0)
            {
                foreach (var func in funcionario)
                {
                    ListViewItem lv = new ListViewItem(func.Cod_Func.ToString());
                    lv.SubItems.Add(func.Nome);
                    lv.SubItems.Add(func.Telefone);
                    lv.SubItems.Add(func.Cpf);
                    lv.SubItems.Add(func.Data_niver);

                    listViewFunc.Items.Add(lv);
                }
            }
            // Se não houver elementos, mesclar as colunas e exibir apenas um texto para o usuário.
        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            FuncionarioCad funcionarioCad = new FuncionarioCad();

            try
            {
                funcionarioCad.Excluir(Cod_Func);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateListView();
            Limpar();
        }

        private void Tela_Cadastro_Funcionario_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listViewFunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listViewFunc.FocusedItem.Index;
            Cod_Func = int.Parse(listViewFunc.Items[index].SubItems[0].Text);
            txb_Nome_Func.Text = listViewFunc.Items[index].SubItems[1].Text;
            mtb_Tel_Func.Text = listViewFunc.Items[index].SubItems[2].Text;
            mtb_Cpf_Func.Text = listViewFunc.Items[index].SubItems[3].Text;
            mtb_DataNiver_Func.Text = listViewFunc.Items[index].SubItems[4].Text;

            bt_Cadastrar.Text = "EDITAR";
            bt_Excluir.Visible = true;
        }

        private void Limpar()
        {
            txb_Nome_Func.Clear();
            mtb_Tel_Func.Clear();
            txb_Senha_Func.Clear();
            txb_Rg_Func.Clear();
            mtb_Cpf_Func.Clear();
            txb_Nome_Func.Focus();
            mtb_DataNiver_Func.Clear();
            bt_Limpar.Enabled = true;
            bt_Excluir.Visible = true;
            bt_Cadastrar.Text = "CADASTRAR";
        }
    }
}
