// See https://aka.ms/new-console-template for more information

using SistemaFinanceiro.Model;

Conta conta1 = new Conta(123456, 1235.42m);
Conta conta2 = new Conta(654321, 2341.42m);

Agencia agencia1 = new Agencia(123);
Agencia agencia2 = new Agencia(123, "PablinInvest", "24988998899");

Console.WriteLine("Trabalho POO\n");
Console.WriteLine($"Saldo total da conta 1 é : R${conta1.Saldo}");
Console.WriteLine($"Saldo total da conta 1 é : R${conta2.Saldo}");

// Cálculo do saldo total
decimal saldoTotal = conta1.Saldo + conta2.Saldo;

// Identificação da conta com maior saldo
Conta contaMaiorSaldo = (conta1.Saldo > conta2.Saldo) ? conta1 : conta2;

// Saldo inicial total geral
conta1.Saque(100m);
conta2.Saque(100m);
decimal saldoInicialTotalGeral = conta1.Saldo + conta2.Saldo;

// Exibição dos resultados
Console.WriteLine($"Saldo total das duas contas: R${saldoTotal}");
Console.WriteLine($"Número da conta com maior saldo: {contaMaiorSaldo.Numero}");
Console.WriteLine($"Saldo inicial total geral: R${saldoInicialTotalGeral:C}");

// Manipulação da classe Cliente
Cliente cliente1 = new Cliente("João Silva", "12345678901", new DateTime(1990, 5, 20));
Cliente cliente2 = new Cliente("Maria Oliveira", "10987654321", new DateTime(1985, 8, 15));

// Vinculação da classe Conta com Cliente
Console.WriteLine($"Cliente: {cliente1.Nome}, CPF: {cliente1.CPF}, Data de Nascimento: {cliente1.DataNascimento.ToShortDateString()}");
Console.WriteLine($"Cliente: {cliente2.Nome}, CPF: {cliente2.CPF}, Data de Nascimento: {cliente2.DataNascimento.ToShortDateString()}");

// Caso não utilizássemos a orientação a objetos, precisaríamos de diversas variáveis para gerenciar as contas
// Se tivéssemos 10 contas, seria necessário 10 conjuntos de variáveis para número e saldo.
// O uso de classes e objetos facilita a manipulação e a organização dos dados.

