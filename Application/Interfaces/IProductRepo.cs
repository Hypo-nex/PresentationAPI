using WWS_API.Domain.Entities;

namespace WWS_API.Application.Interfaces
{
    public interface IProductRepo
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task AddAsync(Product product);
    }
}
