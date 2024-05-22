// See https://aka.ms/new-console-template for more information

using SistemaFinanceiro.Model;

Conta conta1 = new Conta(123);// o construtor default só é valido quando nao existe outro declarado ou quando é declarado junto com outro

Agencia agencia1 = new Agencia(123);
Agencia agencia2 = new Agencia(123, "PablinInvest", "24988998899");
Console.WriteLine($"{agencia1.Numero}");
Console.WriteLine($"{agencia2.Nome}");
Console.WriteLine($"{agencia2.Telefone}");

Console.WriteLine($"Conta: {conta1.Numero}");

conta1.consulta();
conta1.Saque(1000);
conta1.Deposito(-1000);
conta1.consulta();
conta1.Deposito(1000);
conta1.Saque(1000);