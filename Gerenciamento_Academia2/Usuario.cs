using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Academia2
{
    internal class Usuario
    {
        private int _Cod_Usuario;
        private string _Nome;
        private string _Usuarios;
        private string _Senha;
        private string _Conf_Senha;
        private string _Nivel;




        public Usuario(string nome, string usuarios, string senha, string conf_senha,
            string nivel)
        {

            _Nome = nome;
            _Usuarios = usuarios;
            _Senha = senha;
            _Conf_Senha = conf_senha;
            _Nivel = nivel;
        }


        public Usuario(int cod_usuario, string nome, string usuarios, string senha, string conf_senha,
            string nivel)
            : this(nome, usuarios, senha, conf_senha, nivel)
        {
            _Cod_Usuario = cod_usuario;
        }
        public int Cod_Usuario
        {
            get { return _Cod_Usuario; }
            set { _Cod_Usuario = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Usuarios
        {
            get { return _Usuarios; }
            set { _Usuarios = value; }
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

        public string Conf_Senha
        {
            get { return _Conf_Senha; }
            set
            {
                if (!Seguranca.ValidarSenha(value))
                    throw new Exception("Senha não atende aos requisitos mínimos!");
                _Conf_Senha = value;
            }
        }

        public string Nivel
        {
            get { return _Nivel; }
            set { _Nivel = value; }
        }

    

    }
}
