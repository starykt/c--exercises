using AbstratoCliente.Models;

ClienteFisico cf = new ClienteFisico(1, "Ana",20,10);
cf.Mostrar();
ClienteJuridico cj = new ClienteJuridico(2, "Bia S/A",60,10);
cj.Mostrar();

Teste t = new Teste();
t.VerificaIdadeClasses(cf);

Teste t2 = new Teste();
t2.VerificaIdadeClasses(cj);
