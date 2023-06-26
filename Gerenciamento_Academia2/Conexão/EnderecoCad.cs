using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Academia2
{
    internal class EnderecoCad
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public EnderecoCad()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Endereco colab)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Endereco VALUES (@rua, @numero, @bairro, @complemento,
                               @cidade,@cep, @estado)";

            Cmd.Parameters.AddWithValue("@rua", colab.Rua);
            Cmd.Parameters.AddWithValue("@numero", colab.Numero);
            Cmd.Parameters.AddWithValue("@bairro", colab.Bairro);
            Cmd.Parameters.AddWithValue("@complemento", colab.Complemento);
            Cmd.Parameters.AddWithValue("@cidade", colab.Cidade);
            Cmd.Parameters.AddWithValue("@cep", colab.Cep);
            Cmd.Parameters.AddWithValue("@estado", colab.Estado);



            try
            {
                //Insere o cliente
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir endereço no banco.\n"
                    + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public int ListarUltimoId()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT MAX(Cod_End) as Cod_End FROM Endereco";

            int id = -1;
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    id = (int)rd["Cod_End"];
                }
                if (!rd.IsClosed)
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

            return id;
        }
        public List<Endereco> ListarEndereco()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Endereco";

            List<Endereco> listaDeEnd = new List<Endereco>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Endereco end = new Endereco((int)rd["Cod_End"], (string)rd["Rua"], (string)rd["Numero"], (string)rd["Bairro"],
                                                 (string)rd["Complemento"], (string)rd["Cidade"], (string)rd["Cep"], (string)rd["Estado"]);
                    // Endereco end = new Endereco((int)rd["Cod_End"], (string)rd["Rua"], (string)rd["Numero"], (string)rd["Bairro"],
                    //(string)rd["Complemento"], (string)rd["Cidade"]),(string)rd["Cep"], (string)rd["Estado"]);

                    listaDeEnd.Add(end);
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

            return listaDeEnd;
        }


        public void Excluir(int colabCod_End)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE fROM Endereco WHERE Cod_End = @Cod_End";
            Cmd.Parameters.AddWithValue("@Cod_End", colabCod_End);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir endereço no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
    }
}
