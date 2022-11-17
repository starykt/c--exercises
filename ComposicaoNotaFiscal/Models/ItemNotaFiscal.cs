using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal.Models
{
    public class ItemNotaFiscal
    {
        public int Qtde { get; set; }
        public ItemNotaFiscal(int qtde) {
            Qtde = qtde;
        }
        ~ItemNotaFiscal() {
            System.Console.WriteLine("Destrutor do Item de Nota Fiscal.");
        }
    }
}