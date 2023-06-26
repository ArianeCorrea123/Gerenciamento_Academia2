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
    public partial class Tela_Cadastro_Professor : Form
    {
        private int Cod_Prof, Cod_Func;
        public Tela_Cadastro_Professor()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
            listViewProf.Items.Clear();
            ProfessoresCad professoresCad = new ProfessoresCad();

            List<Professores> professor = professoresCad.ListarProfessor();
            if (professor.Count > 0)
            {
                foreach (var colab in professor)
                {
                    ListViewItem lv = new ListViewItem(colab.Cod_Prof.ToString());
                    lv.SubItems.Add(colab.Nome);
                    lv.SubItems.Add(colab.Modalidade);
                    lv.SubItems.Add(colab.Telefone);
                    listViewProf.Items.Add(lv);
                }
            }

            // Se não houver elementos, mesclar as colunas e exibir apenas um texto para o usuário.
        }

        private void bt_Excluir_Prof_Click(object sender, EventArgs e)
        {
            ProfessoresCad profCad = new ProfessoresCad();

            try
            {
                profCad.Excluir(Cod_Prof);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateListView();
            Limpar();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listViewProf.FocusedItem.Index;
            Cod_Prof = int.Parse(listViewProf.Items[index].SubItems[0].Text);
            txb_Nome_Profe.Text = listViewProf.Items[index].SubItems[1].Text;
            txb_Nome_Mod.Text = listViewProf.Items[index].SubItems[1].Text;
            mtb_Tel_Prof.Text = listViewProf.Items[index].SubItems[2].Text;
            bt_Cadastrar_Professor.Text = "EDITAR";
            bt_Excluir_Prof.Visible = true;
        }

        private void bt_Cadastrar_Professor_Click(object sender, EventArgs e)
        {
            string nome = txb_Nome_Profe.Text;
            string modalidade = txb_Nome_Mod.Text;
            string tel = mtb_Tel_Prof.Text;





            Professores professores = new Professores(nome, modalidade, tel, Cod_Func);

            try
            {
                ProfessoresCad professoresCad = new ProfessoresCad();
                professoresCad.Inserir(professores);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateListView();
            Limpar();
        }

        private void bt_Limpar_Prof_Click(object sender, EventArgs e)
        {
            Limpar();

        }

        private void bt_Fechar_Prof_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpar()
        {
            txb_Nome_Profe.Clear();
            txb_Nome_Mod.Clear();
            mtb_Tel_Prof.Clear();
            txb_Nome_Profe.Focus();
            mtb_Tel_Prof.Clear();
            bt_Limpar_Prof.Enabled = true;
            bt_Excluir_Prof.Visible = true;
            bt_Cadastrar_Professor.Text = "CADASTRAR";
        }

        private void Cadastro_Professor_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }
    }
}
