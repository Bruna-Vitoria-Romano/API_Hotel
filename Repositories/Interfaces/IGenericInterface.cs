namespace API_TesteRegistro.Repositories.Interfaces
{
    public interface IGenericInterface<T>
    {
        Task<List<T>> BuscarTodos();
        Task<T> BuscarPorId(int id);
        Task<T> Adicionar(T entity);
        Task<T> Atualizar(T entity, int id);
        Task<bool> Excluir(int id);
    }
}
