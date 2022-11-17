// main function
using InterfaceAutenticavel.Models;

Gerente g = new Gerente();
g.Senha = 4343;
System.Console.WriteLine("Gerente: " + g.Autenticar(4343) + "\n");

Diretor d = new Diretor();
d.Senha = 1212;
IAutenticavel iD = d; 
System.Console.WriteLine("Diretor: " + iD.Autenticar(333) + "\n");

Cliente c = new Cliente();
c.Senha = 1111;
IAutenticavel iC = c; 
System.Console.WriteLine("Cliente: " + iC.Autenticar(1111) + "\n");



 