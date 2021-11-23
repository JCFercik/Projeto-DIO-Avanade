namespace AgenciaBancaria.Dominio
{
    public class Endereco
    {
        public Endereco(string logradouro, string cep, string cidade, string estado)
        {
            Logradouro = logradouro.ValidarStringVazia();
            this.cep = cep.ValidarStringVazia();
            Cidade = cidade.ValidarStringVazia();
            Estado = estado.ValidarStringVazia();
        }

        public string Logradouro { get; private set; }
        public string cep { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
    }
}
