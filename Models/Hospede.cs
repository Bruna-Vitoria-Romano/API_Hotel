namespace API_TesteRegistro.Models
{
    public class Hospede : Pessoa
    {
        public Hospede(int id, string nome, string email, int idade, string telefone, string cpf, int idReserva, string statusAtivo) : base(id, nome, email, idade, telefone, cpf)
        {
            IdReserva = idReserva;
            StatusAtivo = statusAtivo;
        }

        public int IdReserva {  get; set; }
        public string StatusAtivo {  get; set; }
        //TO DO: implementar Enum status e ID de reserva
    }
}
