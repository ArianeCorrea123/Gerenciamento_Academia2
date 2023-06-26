using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Academia2
{
    internal class Aluno
    {

        private int _cod_Aluno;
        private string _nome;
        private string _sexo;
        private string _telefone;
        private string _rg;
        private string _cpf;
        private string _data_niver;
        private string _senha;
        private int _cod_End;




        public Aluno(string nome, string sexo, string tel, string rg,
            string cpf, string data_niver, string senha, int cod_end)
        {

            _nome = nome;
            _sexo = sexo;
            _telefone = tel;
            _rg = rg;
            _cpf = cpf;
            _data_niver = data_niver;
            _senha = senha;
            _cod_End = cod_end;

        }


        public Aluno(int cod_aluno, string nome, string sexo, string tel, string rg,
            string cpf, string data_niver, string senha, int cod_end)
            : this(nome, sexo, tel, rg, cpf, data_niver, senha, cod_end)
        {
            _cod_Aluno = cod_aluno;
        }
        public int Cod_Aluno
        {
            get { return _cod_Aluno; }
            set { _cod_Aluno = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }


        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public string Rg
        {
            get { return _rg; }
            set { _rg = value; }
        }

        public string Cpf
        {
            get { return _cpf; }
            set
            {
                if (!Seguranca.ValidarCpf(value))
                    throw new Exception("Cpf Inválido!");
                _cpf = value;
            }
        }

        public string Data_niver
        {
            get { return _data_niver; }
            set { _data_niver = value; }
        }
        public string Senha
        {
            get { return _senha; }
            set
            {
                if (!Seguranca.ValidarSenha(value))
                    throw new Exception("Senha não atende aos requisitos mínimos!");
                _senha = value;
            }
        }

        public int Cod_End
        {
            get { return _cod_End; }
            set { _cod_End = value; }
        }

    }
}
