﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Academia2
{
    internal class Conexao
    {
        private readonly SqlConnection con;
        private readonly string DataBase = "Academia2";
        public Conexao()                            //LAPTOP-9TN8R1CF\SQLEXPRESS
        {
            string stringConnection = @"Data Source=" + Environment.MachineName +
                @"\SQLEXPRESS;Initial Catalog=" + DataBase + ";Integrated Security=true";

            con = new SqlConnection(stringConnection);
            con.Open();   //Abrir a conexão com o banco de dados
        }

        //Tenta fechar a conexão com o banco
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        //Retorna a conexão que foi aberta
        public SqlConnection ReturnConnection()
        {
            return con;
        }
    }
}
