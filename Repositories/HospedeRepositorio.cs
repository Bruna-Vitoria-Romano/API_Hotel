using API_TesteRegistro.Data;
using API_TesteRegistro.Models;
using API_TesteRegistro.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_TesteRegistro.Repositories
{
    public class HospedeRepositorio : IHospedeRepositorio
    {
        private readonly DataContext _dataContext;
        public HospedeRepositorio(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Hospede> Adicionar(Hospede hospede)
        {
            _dataContext.Hospedes.Add(hospede);
            await _dataContext.SaveChangesAsync();
            return hospede;
        }

        public async Task<Hospede> Atualizar(Hospede hospede, int id)
        {
            Hospede hospedePorId = await BuscarPorId(id);
            if(hospedePorId == null)
            {
                throw new Exception($"Hospede para o ID:{id} não foi encontrado.");
            }

            _dataContext.Hospedes.Update(hospedePorId);
            await _dataContext.SaveChangesAsync();
            return hospedePorId;
        }

        public async Task<Hospede> BuscarPorId(int id)
        {
            return await _dataContext.Hospedes.FirstOrDefaultAsync(x => x.IdReserva == id);
        }

        public Task<Hospede> BuscarReserva(int idReserva)
        {
            throw new NotImplementedException();
        }

        public Task<List<Hospede>> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Excluir(int id)
        {
            throw new NotImplementedException();
        }
    }
}
