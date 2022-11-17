
using HerencaCliente.Models;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Rodrigo";
c.Endereco = "Rua Lilili Hahaha, 13";

ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Lili";
cf.Endereco = "Rua Brasil, 100";
cf.Rg = 49201;
cf.Cpf = 46799132;

ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 3;
cj.Nome = "Kekeu & CIA";
cj.Endereco = "Rua Almeida, 34";
cj.Cnpj = 274613;
cj.Ie = 12; 

Cliente c2 = new Cliente(4, "Lulu", "Rua Verde, 3");
c2.Mostrar();
ClienteFisico cf2 = new ClienteFisico(5, "Manu", "Rua Laranja, 4", 13567, 784652);
cf2.Mostrar();
ClienteJuridico cj2 = new ClienteJuridico(6, "Tico&Teco", "Rua Roxo, 19", 12563, 66);
cj2.Mostrar();