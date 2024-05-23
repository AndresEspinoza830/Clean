
namespace Clean.Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
       Task<List<T>> FindAll();
    }
}
