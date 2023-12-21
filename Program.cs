
using bytebank5.funcionários;
using bytebank5.utilitário;

funcionário Luiza = new funcionário("123456789", 2000);
Luiza.Nome = "Luiza Amaral";

Console.WriteLine(Luiza.Nome);
Console.WriteLine(Luiza.GetBonificacao());

Diretor Roberta = new Diretor("987654321", 5000);
Roberta.Nome = "Roberta Silva";

Console.WriteLine(Roberta.Nome);
Console.WriteLine(Roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(Luiza);
gerenciador.Registrar(Roberta);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalBonificacao);
Console.WriteLine("Total de funcionários: " + funcionário.TotalFuncionarios);

Luiza.AumentarSalario();
Roberta.AumentarSalario();

Console.WriteLine("Novo salário da Luiza: " + Luiza.Salario);
Console.WriteLine("Novo salário da Roberta: " + Roberta.Salario);