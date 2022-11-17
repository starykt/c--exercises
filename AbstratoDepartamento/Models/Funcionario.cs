using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoDepartamento.Models
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public abstract double CalcularSalario(int diasUteis); // implicitamente indica que o método será alterado

        public virtual void MostrarDados() {
            System.Console.WriteLine("Código: " + Codigo + "\nNome: " +
            Nome + "\nSalário: " + Salario);
        }
        public Funcionario(int c, string n, double s)
        {
            Codigo = c;
            Nome = n;
            Salario = s;
        }
    }
}