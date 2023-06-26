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
    
    public partial class Tela_Cadastro_Aluno : Form
    {
        private int Cod_Aluno, Cod_End, Cod_Dep;
        public Tela_Cadastro_Aluno()
        {
            InitializeComponent();
            bt_Cadastrar.Enabled = false;
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();
            AlunoCad alunoCad = new AlunoCad();

            List<Aluno> alunos = alunoCad.ListarAluno();
            if (alunos.Count > 0)
            {
                foreach (var colab in alunos)
                {
                    ListViewItem lv = new ListViewItem(colab.Cod_Aluno.ToString());
                    lv.SubItems.Add(colab.Nome);
                    lv.SubItems.Add(colab.Telefone);
                    lv.SubItems.Add(colab.Cpf);
                    lv.SubItems.Add(colab.Data_niver);

                    listView1.Items.Add(lv);
                }
            }

            // Se não houver elementos, mesclar as colunas e exibir apenas um texto para o usuário.
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            string nome = txb_Nome_Aluno.Text;
            string tel = mtb_Tel_Aluno.Text;
            string rg = txb_Rg_Aluno.Text;
            string cpf = mtb_Cpf_Aluno.Text;
            string sexo = cmb_Sexo_Aluno.Text;
            string data_niver = mtb_DataNiver_Aluno.Text;
            string senha = txb_Senha_Aluno.Text;




            Aluno aluno = new Aluno(nome, sexo, tel, rg, cpf, data_niver, senha, Cod_End);

            try
            {
                AlunoCad alunoCad = new AlunoCad();
                alunoCad.Inserir(aluno);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateListView();
            Limpar();

        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            AlunoCad aluCad = new AlunoCad();

            try
            {
                aluCad.Excluir(Cod_Aluno);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateListView();
            Limpar();
            
        }

        private void Limpar()
        {
            txb_Nome_Aluno.Clear();
            txb_Senha_Aluno.Clear();
            mtb_Tel_Aluno.Clear();
            txb_Rg_Aluno.Clear();
            mtb_Cpf_Aluno.Clear();
            //cmb_Sexo_Aluno.Clear();
            txb_Nome_Aluno.Focus();
            mtb_DataNiver_Aluno.Clear();
            bt_Limpar.Enabled = true;
            bt_Excluir.Visible = true;
            bt_Cadastrar.Text = "CADASTRAR";
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listView1.FocusedItem.Index;
            Cod_Aluno = int.Parse(listView1.Items[index].SubItems[0].Text);
            txb_Nome_Aluno.Text = listView1.Items[index].SubItems[1].Text;
            mtb_Tel_Aluno.Text = listView1.Items[index].SubItems[2].Text;
            mtb_Cpf_Aluno.Text = listView1.Items[index].SubItems[3].Text;
            mtb_DataNiver_Aluno.Text = listView1.Items[index].SubItems[4].Text;

            bt_Cadastrar.Text = "EDITAR";
            bt_Excluir.Visible = true;
        }

        private void bt_Endereco_Click(object sender, EventArgs e)
        {
            Tela_Endereco tela_Endereco = new Tela_Endereco();
            tela_Endereco.ShowDialog();

            Cod_End = tela_Endereco.ID;
            bt_Cadastrar.Enabled = true;
        }

       
        private void Tela_Cadastro_Aluno_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }
    }
    
}
