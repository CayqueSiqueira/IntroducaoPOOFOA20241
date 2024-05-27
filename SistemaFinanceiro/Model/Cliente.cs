using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    internal class Cliente
    {
        private string _nome;
        private string _cpf;
        private DateTime _dataNascimento;
        private List<Conta> _contas;
        public string Nome
        {
            get => _nome; 
            set => _nome = value; 
        }

        public string CPF
        {
            get => _cpf;
            set
            {
                if (value.Length == 11 && long.TryParse(value, out _))
                {
                    _cpf = value;
                }
                else
                {
                    throw new ArgumentException("CPF deve conter 11 dígitos.");
                }
            }
        }

        public DateTime DataNascimento
        {
            get => _dataNascimento;
            set
            {
                if ((DateTime.Now.Year - value.Year) >= 18)
                {
                    _dataNascimento = value;
                }
                else
                {
                    throw new ArgumentException("O cliente deve ter mais de 18 anos.");
                }
            }
        }

        public List<Conta> Contas
        {
            get => _contas; 
            set => _contas = value; 
        }

        public Cliente(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }

        public void AdicionarConta(Conta conta)
        {
            Contas.Add(conta);
        }

    }
}
