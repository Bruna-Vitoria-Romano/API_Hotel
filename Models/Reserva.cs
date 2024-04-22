namespace API_TesteRegistro.Models
{
    public class Reserva
    {
        public Reserva(Hospede idHospede, DateTime diaEHora, int numeroQuarto, Funcionario idFuncionarioResponsavel, string statusReserva)
        {
            IdHospede = idHospede;
            DiaEHora = diaEHora;
            NumeroQuarto = numeroQuarto;
            IdFuncionarioResponsavel = idFuncionarioResponsavel;
            StatusReserva = statusReserva;
        }

        private Hospede IdHospede {  get; set; }
        private DateTime DiaEHora { get; set; }
        private int NumeroQuarto { get; set; }
        private Funcionario IdFuncionarioResponsavel { get; set; }
        private string StatusReserva { get; set; }
    }
}
