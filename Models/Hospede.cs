namespace API_TesteRegistro.Models
{
    public class Hospede : Pessoa
    {
        public Hospede(int id, string nome, string email, int idade, string telefone, string cpf, int numeroQuarto, string statusAtivo) : base(id, nome, email, idade, telefone, cpf)
        {
            NumeroQuarto = numeroQuarto;
            StatusAtivo = statusAtivo;
        }

        private int NumeroQuarto {  get; set; }
        private string StatusAtivo {  get; set; }
    }
}
