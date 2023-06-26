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
    public partial class Tela_Cadastro_Usuario : Form
    {
        private int Cod_Usuario;
        public Tela_Cadastro_Usuario()
        {
            InitializeComponent();
        }   

        private void UpdateListView()
        {
            listViewUsuarios.Items.Clear();
            UsuarioCad usuarioCad = new UsuarioCad();

            List<Usuario> usuarios = usuarioCad.ListarUsuario();
            if (usuarios.Count > 0)
            {
                foreach (var colab in usuarios)
                {
                    ListViewItem lv = new ListViewItem(colab.Cod_Usuario.ToString());
                    lv.SubItems.Add(colab.Nome);
                    lv.SubItems.Add(colab.Usuarios);
                    lv.SubItems.Add(colab.Nivel);
                    listViewUsuarios.Items.Add(lv);
                }
            }

        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            string nome = txb_Nome_Usuario.Text;
            string usuarios = txb_Usuario.Text;
            string senha = txb_Senha_Usuario.Text;
            string conf_senha = txb_Conf_Senha.Text;
            string nivel = cmb_Nivel.Text;
            
            Usuario usuario = new Usuario(nome, usuarios, senha, conf_senha, nivel);

            try
            {
                UsuarioCad usuarioCad = new UsuarioCad();
                usuarioCad.Inserir(usuario);
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
            UsuarioCad usuCad = new UsuarioCad();

            try
            {
                usuCad.Excluir(Cod_Usuario);
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
            txb_Nome_Usuario.Clear();
            txb_Usuario.Clear();
            txb_Senha_Usuario.Clear();
            txb_Conf_Senha.Clear();
            txb_Nome_Usuario.Focus();
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
            this.Close();
        }

        private void listViewUsuarios_DoubleClick(object sender, EventArgs e)
        {
            int index = listViewUsuarios.FocusedItem.Index;
            Cod_Usuario = int.Parse(listViewUsuarios.Items[index].SubItems[0].Text);
            txb_Nome_Usuario.Text = listViewUsuarios.Items[index].SubItems[1].Text;
            txb_Usuario.Text = listViewUsuarios.Items[index].SubItems[2].Text;
            txb_Senha_Usuario.Text = listViewUsuarios.Items[index].SubItems[3].Text;
            txb_Conf_Senha.Text = listViewUsuarios.Items[index].SubItems[4].Text;
            cmb_Nivel.Text = listViewUsuarios.Items[index].SubItems[5].Text;

            bt_Cadastrar.Text = "EDITAR";
            bt_Excluir.Visible = true;

        }
    }
}
