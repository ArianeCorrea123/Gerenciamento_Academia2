using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Academia2
{
    internal class Professores
    {

        private int _Cod_Prof;
        private string _Nome;
        private string _Modalidade;
        private string _Telefone;
        private int _Cod_Func;




        public Professores(string nome, string modalidade, string tel, int cod_func)
        {

            _Nome = nome;
            _Modalidade = modalidade;
            _Telefone = tel;
            _Cod_Func = cod_func;

        }


        public Professores(int cod_prof, string nome, string modalidade, string tel, int cod_func)
            : this(nome, modalidade, tel, cod_func)
        {
            _Cod_Prof = cod_prof;
        }
        public int Cod_Prof
        {
            get { return _Cod_Prof; }
            set { _Cod_Prof = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Modalidade
        {
            get { return _Modalidade; }
            set { _Modalidade = value; }
        }


        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

        
        public int Cod_Func
        {
            get { return _Cod_Func; }
            set { _Cod_Func = value; }
        }
    }
}
