using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class Conta
    {
        private long _numero;
        private decimal _saldo;

        //criando o construtor ctrl + .
        public Conta(long numero)
        {
            _numero = numero;
        }

        public Conta(long numero, decimal saldo)
        {
            _numero = numero;
            _saldo = saldo;
        }

        public long Numero
        {
            get => _numero;
            private set
            {
                _numero = value;
            }
        }

        public decimal Saldo
        {
            get => _saldo;

        }

        public void consulta()
        {
            Console.WriteLine($"{_saldo}");
        }

        public void saque(decimal valor)
        {   
            if (valor > _saldo) {
                Console.WriteLine("Valor do saque não pode ser maior que saldo em conta");
            }

            if (valor <= 0)
            {
                Console.WriteLine("Valor do saque deve ser positivo");
            }

            if (valor <= _saldo)
            {
                _saldo = _saldo - valor;
                Console.WriteLine($"Saque de {valor} executado com sucesso. Saldo atual {_saldo}");
            }

        }

        public void deposito(long valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
            if (valor > 0)
            {
                _saldo += valor;
                Console.WriteLine($"Deposito realizado com sucesso. Saldo atual {_saldo}");
            }

        }

        // crie o código de teste para testar o método de depósito e saque da conta
    }
}
