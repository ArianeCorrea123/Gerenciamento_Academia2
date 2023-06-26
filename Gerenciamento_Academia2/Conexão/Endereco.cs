using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Academia2
{
    internal class Endereco
    {
        private int _Cod_End;
        private string _Rua;
        private string _Numero;
        private string _Bairro;
        private string _Complemento;
        private string _Cidade;
        private string _Cep;
        private string _Estado;


        public Endereco(string rua, string numero, string bairro, string complemento, string cidade,
                        string cep, string estado)
        {

            _Rua = rua;
            _Numero = numero;
            _Bairro = bairro;
            _Complemento = complemento;
            _Cidade = cidade;
            _Cep = cep;
            _Estado = estado;

        }

        public Endereco(int cod_end, string rua, string numero, string bairro, string complemento,
                       string cidade, string cep, string estado)
                       : this(rua, numero, bairro, complemento, cidade, cep, estado)
        {
            _Cod_End = cod_end;
        }

        public int Cod_End
        {
            get { return _Cod_End; }
            set { _Cod_End = value; }
        }

        public string Rua
        {
            get { return _Rua; }
            set { _Rua = value; }
        }
        public string Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }
        public string Bairro
        {
            get { return _Bairro; }
            set { _Bairro = value; }
        }

        public string Complemento
        {
            get { return _Complemento; }
            set { _Complemento = value; }
        }

        public string Cidade
        {
            get { return _Cidade; }
            set { _Cidade = value; }
        }
        public string Cep
        {
            get { return _Cep; }
            set { _Cep = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }


    }
}
