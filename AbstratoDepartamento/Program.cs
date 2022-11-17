// Main

using AbstratoDepartamento.Models;

// Funcionario f = new Funcionario();
Assalariado a1 = new Assalariado(1, "Nicols", 1000);
Assalariado a2 = new Assalariado(2, "Nicole", 1000);

Comissionado c1 = new Comissionado(3, "Nicoly", 1000, 0.20);
Comissionado c2 = new Comissionado(4, "Nicola", 1000, 0.20);


Departamento d1 = new Departamento(101, "TI");
Departamento d2 = new Departamento(102, "RH");


d1.VetF = new List<Funcionario>(); // no departamento 1 terá uma nova lista de Funcionarios
d1.AdmitirFunc(a1);
d1.AdmitirFunc(c2);

d2.VetF = new List<Funcionario>(); // no departamento 2 terá uma nova lista de Funcionarios
d2.AdmitirFunc(a2);
d2.AdmitirFunc(c1);

d1.ListarFunc();
d2.ListarFunc();

System.Console.WriteLine("\n----------Folhas de Pagamento----------");

System.Console.WriteLine("Departamento " + d1.Descricao + 
    ": R$" + d1.CalcularFolhaPagamento(30));

System.Console.WriteLine("----------------------");

System.Console.WriteLine("Departamento " + d2.Descricao + 
    ": R$" + d2.CalcularFolhaPagamento(30) + "\n");

d1.DemitirFunc(1);
d1.ListarFunc();
