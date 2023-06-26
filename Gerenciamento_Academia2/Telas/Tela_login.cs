using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gerenciamento_Academia2
{

    public partial class Tela_login : Form
    {
        
        public Tela_login()
        {
            InitializeComponent();
            
        }

        private void bt_Entrar_Click(object sender, EventArgs e)
        {
            //string usuario = txb_Login.Text;
            //string senha = txb_Senha.Text;
            //String User = "Admin";
            //String Password = "Admin";
             UsuarioCad usuarioCad = new UsuarioCad();
            Usuario usuarioLogado = usuarioCad.TestarLogin(txb_Login.Text, txb_Senha.Text);

            if (usuarioLogado!= null)
            {

                 MessageBox.Show("Acesso Liberado!");
                 Tela_Principal FormMain = new Tela_Principal(usuarioLogado.Usuarios, usuarioLogado.Nivel);
                 FormMain.Show();
                 this.Hide();

            }
            else
            {
                 MessageBox.Show("Usuário/Senha Incorretos!");
                 
            }
            
            
        }

        private void bt_Novo_Usuario_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Usuario cadastro_Usuario = new Tela_Cadastro_Usuario();
            cadastro_Usuario.ShowDialog();

        }

        private void bt_Cancelar_Login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }

}
