// See https://aka.ms/new-console-template for more information

using SistemaFinanceiro.Model;

var conta1 = new Conta(123);// o construtor default só é valido quando nao existe outro declarado ou quando é declarado junto com outro


Console.WriteLine($"Conta: {conta1}");