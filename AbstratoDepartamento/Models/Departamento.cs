using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoDepartamento.Models
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int c, string d) {
            Codigo = c;
            Descricao = d;
        }

        public void AdmitirFunc(Funcionario f) {
            VetF.Add(f);
        }

        public void ListarFunc() {
            System.Console.WriteLine("-----------Listando Funcionários----------");
            foreach (Funcionario f in VetF) {
                f.MostrarDados();
                System.Console.WriteLine("------------------------------------------");
            }
        }

        public double CalcularFolhaPagamento(int diasUteis) {
            double folha = 0;
            for (int i=0; i<VetF.Count; i++) { // método count = quantos objetos tem no vetor
                Funcionario f =VetF.ElementAt<Funcionario>(i);
                // varível tipo Funcionário recebe o funcionário da posição i

                folha = folha + f.CalcularSalario(diasUteis);
            }
            return folha;
        }

        public void DemitirFunc(int codigo) {
            for (int i=0; i<VetF.Count; i++) { // método count = quantos objetos tem no vetor
                Funcionario f =VetF.ElementAt<Funcionario>(i);
                // varível tipo Funcionário recebe o funcionário da posição i

                if (f.Codigo == codigo) {
                    System.Console.WriteLine("-----------Demitindo Funcionário e Removendo do Sistema-----------");
                    VetF.Remove(f);
                    System.Console.WriteLine(f.Nome + " foi demitida do departamento!\n");
                }
            }
        }
    }
}