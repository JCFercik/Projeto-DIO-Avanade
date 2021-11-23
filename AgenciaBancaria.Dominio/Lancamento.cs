using System;

namespace AgenciaBancaria.Dominio
{
    public abstract class Lancamento
    {
        public Lancamento(decimal valor, DateTime data, ContaBancaria conta)
        {
            Data = data;
            Conta = conta ?? throw new ArgumentNullException(nameof(conta));
            Valor = (valor > 0) ? valor : throw new Exception("Valor do lançamento deve ser maior que zero.");
        }

        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public ContaBancaria Conta { get; set; }
    }
}
