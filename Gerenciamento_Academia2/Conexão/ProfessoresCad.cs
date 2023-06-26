using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Academia2
{
    internal class ProfessoresCad
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public ProfessoresCad()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Professores professores)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Professor VALUES (@nome, @modalidade, @tel,@Cod_Func)";

            Cmd.Parameters.AddWithValue("@nome", professores.Nome);
            Cmd.Parameters.AddWithValue("@sexo", professores.Modalidade);
            Cmd.Parameters.AddWithValue("@tel", professores.Telefone);
            Cmd.Parameters.AddWithValue("@Cod_Func", professores.Cod_Func);



            try
            {
                //Insere o cliente
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir professor no banco.\n"
                    + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }


        public List<Professores> ListarProfessor()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Professor";

            List<Professores> listaDeProfessor = new List<Professores>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Professores professores = new Professores((int)rd["Cod_Prof"], (string)rd["Nome"], (string)rd["Modalidade"],
                         (string)rd["Telefone"],(int)rd["Cod_Func"]);

                    listaDeProfessor.Add(professores);
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

            return listaDeProfessor;
        }

        public void Atualizar(Professores professor)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Professor SET Nome = @nome, Modalidade= @modalidade,
                              Telefone = @tel,Cod_Func = @Cod_Func, WHERE Cod_Prof = @Cod_Prof)";

            Cmd.Parameters.AddWithValue("@Cod_Aluno", professor.Cod_Prof);
            Cmd.Parameters.AddWithValue("@nome", professor.Nome);
            Cmd.Parameters.AddWithValue("@sexo", professor.Modalidade);
            Cmd.Parameters.AddWithValue("@tel", professor.Telefone);
            Cmd.Parameters.AddWithValue("@Cod_Func", professor.Cod_Func);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public void Excluir(int professoresCad_Professsores)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE fROM Professor WHERE Cod_Prof = @Cod_Prof";
            Cmd.Parameters.AddWithValue("@Cod_Prof", professoresCad_Professsores);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir aluno no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

        }
    }
}
