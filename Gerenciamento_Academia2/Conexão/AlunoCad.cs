using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Academia2
{
    internal class AlunoCad
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public AlunoCad()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Aluno aluno)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Aluno VALUES (@nome, @sexo, @tel, @rg, @cpf, @data_niver, @senha,@Cod_End)";

            Cmd.Parameters.AddWithValue("@nome", aluno.Nome);
            Cmd.Parameters.AddWithValue("@sexo", aluno.Sexo);
            Cmd.Parameters.AddWithValue("@tel", aluno.Telefone);
            Cmd.Parameters.AddWithValue("@rg", aluno.Rg);
            Cmd.Parameters.AddWithValue("@cpf", aluno.Cpf);
            Cmd.Parameters.AddWithValue("@data_niver", aluno.Data_niver);
            Cmd.Parameters.AddWithValue("@senha", aluno.Senha);
            Cmd.Parameters.AddWithValue("@Cod_End", aluno.Cod_End);



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


        public List<Aluno> ListarAluno()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Aluno";

            List<Aluno> listaDeAluno = new List<Aluno>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Aluno aluno = new Aluno((int)rd["Cod_Aluno"], (string)rd["Nome"], (string)rd["Sexo"],
                         (string)rd["Telefone"], (string)rd["Rg"], (string)rd["Cpf"],
                          (string)rd["Data_niver"], (string)rd["Senha"], (int)rd["Cod_End"]);

                    listaDeAluno.Add(aluno);
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

            return listaDeAluno;
        }

        public void Atualizar(Aluno aluno)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Aluno SET Nome = @nome, Sexo = @sexo,Ddd = @ddd,
                              Telefone = @tel,Rg =  @rg, Cpf =  @cpf, Data_niver = @data_niver,
                              Senha = @senha, Cod_End = @Cod_End, WHERE Cod_aluno = @Cod_Aluno)";

            Cmd.Parameters.AddWithValue("@Cod_Aluno", aluno.Cod_Aluno);
            Cmd.Parameters.AddWithValue("@nome", aluno.Nome);
            Cmd.Parameters.AddWithValue("@sexo", aluno.Sexo);
            Cmd.Parameters.AddWithValue("@tel", aluno.Telefone);
            Cmd.Parameters.AddWithValue("@rg", aluno.Rg);
            Cmd.Parameters.AddWithValue("@cpf", aluno.Cpf);
            Cmd.Parameters.AddWithValue("@data_niver", aluno.Data_niver);
            Cmd.Parameters.AddWithValue("@senha", aluno.Data_niver);
            Cmd.Parameters.AddWithValue("@Cod_End", aluno.Cod_End);
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
        public void Excluir(int alunoCod_Aluno)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE fROM Aluno WHERE Cod_Aluno = @Cod_Aluno";
            Cmd.Parameters.AddWithValue("@Cod_Aluno", alunoCod_Aluno);
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
