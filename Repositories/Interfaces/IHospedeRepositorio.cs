using API_TesteRegistro.Models;

namespace API_TesteRegistro.Repositories.Interfaces
{
    public interface IHospedeRepositorio : IGenericInterface<Hospede>
    {
        Task<Hospede> BuscarReserva(int idReserva);
    }
}
