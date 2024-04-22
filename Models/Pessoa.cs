namespace API_TesteRegistro.Models
{
    public class Pessoa
    {
        public Pessoa(int id, string nome, string email, int idade, string telefone, string cpf)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Idade = idade;
            Telefone = telefone;
            Cpf = cpf;
        }

        private int Id { get; set; }
        private string Nome { get; set; }
        private string Email { get; set; }
        private int Idade { get; set; }
        private string Telefone { get; set; }
        private string Cpf { get; set; }
    }
}
