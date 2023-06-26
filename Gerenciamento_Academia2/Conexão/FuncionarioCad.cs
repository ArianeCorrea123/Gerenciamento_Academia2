using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Academia2
{
    internal class FuncionarioCad
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public FuncionarioCad()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Funcionario func)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Funcionario VALUES (@nome, @sexo, @tel, @rg, @cpf, @data_niver, @senha, @nivel_acesso,@Cod_End)";

            Cmd.Parameters.AddWithValue("@nome", func.Nome);
            Cmd.Parameters.AddWithValue("@sexo", func.Sexo);
            Cmd.Parameters.AddWithValue("@tel", func.Telefone);
            Cmd.Parameters.AddWithValue("@rg", func.Rg);
            Cmd.Parameters.AddWithValue("@cpf", func.Cpf);
            Cmd.Parameters.AddWithValue("@data_niver", func.Data_niver);
            Cmd.Parameters.AddWithValue("@senha", func.Senha);
            Cmd.Parameters.AddWithValue("@nivel_acesso", func.Nivel_Acesso);
            Cmd.Parameters.AddWithValue("@Cod_End", func.Cod_End);



            try
            {
                //Insere o cliente
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir funcionario no banco.\n"
                    + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public List<Funcionario> ListarFuncionario()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Funcionario";

            List<Funcionario> listaDeFunc = new List<Funcionario>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Funcionario funcionario = new Funcionario((int)rd["Cod_Func"], (string)rd["Nome"],
                        (string)rd["Sexo"], (string)rd["Telefone"], (string)rd["Rg"], (string)rd["Cpf"],
                          (string)rd["Data_niver"], (string)rd["Senha"], (string)rd["Nivel_Acesso"], (int)rd["Cod_End"]);

                    listaDeFunc.Add(funcionario);
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

            return listaDeFunc;
        }
        public void Excluir(int funcionarioCod_Funcionario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE fROM Funcionario WHERE Cod_Func = @Cod_Func";
            Cmd.Parameters.AddWithValue("@Cod_Func", funcionarioCod_Funcionario);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir Funcionário no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
    }
}
