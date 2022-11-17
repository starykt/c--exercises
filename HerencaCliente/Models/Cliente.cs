using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerencaCliente.Models
{
    public class Cliente
    {
        protected int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        protected string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        protected string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }  

        public Cliente()
        {   
        }

        public Cliente(int c, string n, string e)
        {
            Codigo = c;
            Nome = n;
            this.Endereco = e;
        }

        public void Mostrar()
        {
            System.Console.WriteLine("--------------------" + "\nCódigo: " + Codigo +
                "\tNome: " + Nome +
                "\nEndereço: " + Endereco);
        }
    }
}