using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Academia2
{
    internal class UsuarioCad
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public UsuarioCad()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Usuario usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Usuario VALUES (@nome, @usuarios, @senha, @conf_senha, @nivel)";

            Cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@usuarios", usuario.Usuarios);
            Cmd.Parameters.AddWithValue("@senha", usuario.Senha);
            Cmd.Parameters.AddWithValue("@conf_senha", usuario.Conf_Senha);
            Cmd.Parameters.AddWithValue("@nivel", usuario.Nivel);
           



            try
            {
                //Insere o cliente
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir aluno no banco.\n"
                    + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }


        public List<Usuario> ListarUsuario()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Usuario";

            List<Usuario> listaDeUsuario = new List<Usuario>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Usuario usuario = new Usuario((int)rd["Cod_Usuario"], (string)rd["Nome"], (string)rd["Usuarios"],
                         (string)rd["Senha"], (string)rd["Conf_Senha"], (string)rd["Nivel"]);

                    listaDeUsuario.Add(usuario);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDeUsuario;
        }

        public Usuario TestarLogin(string usuario, string senha)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Usuario where Usuarios = @usuario and Senha = @senha";
            Cmd.Parameters.AddWithValue("@usuario", usuario);
            Cmd.Parameters.AddWithValue("@senha", senha);

            Usuario usuarioLogado = null;
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                     usuarioLogado = new Usuario((int)rd["Cod_Usuario"], (string)rd["Nome"], (string)rd["Usuarios"],
                         (string)rd["Senha"], (string)rd["Conf_Senha"], (string)rd["Nivel"]);

                    
                }

                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return usuarioLogado;
        }


        public void Excluir(int UsuarioCod_usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE fROM Usuarios WHERE Cod_Usuario = @Cod_Usuario";
            Cmd.Parameters.AddWithValue("@Cod_Usuario", UsuarioCod_usuario);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir Usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

        }

        
    }
}
