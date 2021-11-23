namespace AgenciaBancaria.Dominio
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(Cliente cliente): base(cliente)
        {
            // 0,30%
            PercentualRendimentos = 0.003M;
        }

        public decimal PercentualRendimentos { get; private set;}
    }
}
