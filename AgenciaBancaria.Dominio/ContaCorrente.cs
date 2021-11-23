using System;

namespace AgenciaBancaria.Dominio
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(Cliente cliente, decimal limite) : base(cliente)
        {
            Limite = limite;
            ValorTaxaManutencao = 0.05M;
        }

        // Sobreescrever o método Sacar 
        public override void Sacar(decimal valor, string senha)
        {
            if (senha != Senha)
            {
                throw new Exception("Senha incorreta.");
            }

            var saque = new Saque(valor, DateTime.Now, this);

            var valorMaximoSaque = Saldo + Limite;

            if (valorMaximoSaque < saque.Valor)
            {
                throw new Exception("O saldo + limite não são suficientes para realizar o saque.");
            }

            Saldo -= saque.Valor;
            Lancamentos.Add(saque); ;
        }

        public decimal Limite { get; private set; }
        public decimal ValorTaxaManutencao { get; private set; }
    }
}
