using API_TesteRegistro.Models;

namespace API_TesteRegistro.Repositories.Interfaces
{
    public interface IReservaRepositorio : IGenericInterface<Reserva>
    {
        Task<Reserva> BuscarHospede(int idHospede);
        //Se existir pode fazer uma reserva, se não hospede precisa de cadastro
    }
}
