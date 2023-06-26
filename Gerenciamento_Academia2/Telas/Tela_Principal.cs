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
    public partial class Tela_Principal : Form
    {
        public Tela_Principal(string usuario, string nivel)
        {
            InitializeComponent();
            lb_Nivel_Usuario.Text = usuario;
            lb_Nivel_Acesso.Text = nivel;
            
        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Aluno cadastro_Alunos = new Tela_Cadastro_Aluno();
            cadastro_Alunos.ShowDialog();
        }

        private void novoCadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Funcionario cadastro_Funcionario = new Tela_Cadastro_Funcionario();
            cadastro_Funcionario.ShowDialog();

        }

        private void bt_Novo_Aluno_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Aluno cadastro_Alunos = new Tela_Cadastro_Aluno();
            cadastro_Alunos.ShowDialog();
        }

        private void bt_Novo_Func_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Funcionario cadastro_Funcionario = new Tela_Cadastro_Funcionario();
            cadastro_Funcionario.ShowDialog();
        }


        private void novoCadastroToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Professor cadastro_Professores = new Tela_Cadastro_Professor();
            cadastro_Professores.ShowDialog();
        }

        private void novoCadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Modalidades cadastro_Modalidade = new Tela_Cadastro_Modalidades();
            cadastro_Modalidade.ShowDialog();
        }

        private void Tela_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
