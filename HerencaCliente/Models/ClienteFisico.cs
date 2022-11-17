using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerencaCliente.Models
{
    public class ClienteFisico : Cliente // : herença
    {
        private int rg;
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        
        private int cpf;
        public int Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        
        public ClienteFisico()
        {
        }

        public ClienteFisico(int c, string n, string e, int r, int cpf) : base(c, n, e)
        {
            Rg = r;
            Cpf = cpf;
        }

        public void Mostrar()
        {
            base.Mostrar();
            System.Console.WriteLine("RG: " + Rg + "\tCPF: " + Cpf + "\n");
        }
    }
}