using ComposicaoNotaFiscal.Models;

ItemNotaFiscal it1 = new ItemNotaFiscal(20);
ItemNotaFiscal it2 = new ItemNotaFiscal(30);

List<ItemNotaFiscal> itens = new List<ItemNotaFiscal>(); // o vetor de itens é criado
itens.Add(it1);
itens.Add(it2);

NotaFiscal nf = new NotaFiscal(1, "19/10/2022", itens); // aqui se cria a Notafiscal já com os itens


// Destruindo um objeto
nf = null;
GC.Collect(); // coleta da memória objetos inutilizados