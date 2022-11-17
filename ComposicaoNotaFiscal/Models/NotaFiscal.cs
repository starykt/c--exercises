using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal.Models
{
    public class NotaFiscal
    {
        public int NumeroNf { get; set; }
        public string Data { get; set; }
        public List<ItemNotaFiscal> Item { get; set; }
        public NotaFiscal(int n, string d,
            List<ItemNotaFiscal> vetItens)
        {
            NumeroNf = n;
            Data = d;
            Item = vetItens;
        }

        ~NotaFiscal() {
            System.Console.WriteLine("Destrutor de Nota Fiscal.");
        }
    }
}