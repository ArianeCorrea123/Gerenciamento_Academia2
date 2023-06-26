using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Academia2
{
    internal class Funcionario
    {

        private int _Cod_Func;
        private string _Nome;
        private string _Sexo;
        private string _Telefone;
        private string _Rg;
        private string _Cpf;
        private string _Data_Niver;
        private string _Senha;
        private string _Nivel_Acesso;
        private int _Cod_End;




        public Funcionario(string nome, string sexo, string tel, string rg,
            string cpf, string data_niver, string senha, string nivel_acesso, int cod_end)
        {

            _Nome = nome;
            _Sexo = sexo;
            _Telefone = tel;
            _Rg = rg;
            _Cpf = cpf;
            _Data_Niver = data_niver;
            _Senha = senha;
            _Nivel_Acesso = nivel_acesso;
            _Cod_End = cod_end;

        }


        public Funcionario(int cod_funcionario, string nome, string sexo, string tel, string rg,
            string cpf, string data_niver, string senha, string nivel_acesso, int cod_end)
            : this(nome, sexo, tel, rg, cpf, data_niver, senha, nivel_acesso, cod_end)
        {
            _Cod_Func = cod_funcionario;
        }
        public int Cod_Func
        {
            get { return _Cod_Func; }
            set { _Cod_Func = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; }
        }

        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

        public string Rg
        {
            get { return _Rg; }
            set { _Rg = value; }
        }

        public string Cpf
        {
            get { return _Cpf; }
            set
            {
                if (!Seguranca.ValidarCpf(value))
                    throw new Exception("Cpf Inválido!");
                _Cpf = value;
            }
        }

        public string Data_niver
        {
            get { return _Data_Niver; }
            set { _Data_Niver = value; }
        }
        public string Senha
        {
            get { return _Senha; }
            set
            {
                if (!Seguranca.ValidarSenha(value))
                    throw new Exception("Senha não atende aos requisitos mínimos!");
                _Senha = value;
            }
        }

        public string Nivel_Acesso
        {
            get { return _Nivel_Acesso; }
            set { _Nivel_Acesso = value; }
        }

        public int Cod_End
        {
            get { return _Cod_End; }
            set { _Cod_End = value; }
        }
    }
}
