namespace API_TesteRegistro.Models
{
    public class Funcionario : Pessoa
    {
        public Funcionario(int id, string nome, string email, int idade, string telefone, string cpf, string funcao, string numeroCarteiraTrabalho) : base(id, nome, email, idade, telefone, cpf)
        {
            Funcao = funcao;
            NumeroCarteiraTrabalho = numeroCarteiraTrabalho;
        }

        private string Funcao {  get; set; }
        private string NumeroCarteiraTrabalho { get; set; }
    }
}
