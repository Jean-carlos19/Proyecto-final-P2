using MiPrimerAPI.Controllers.Models;
using MiPrimerAPI.Controllers.servicio;

namespace MiPrimerAPI.Controllers.servicio
{
    internal interface IProductRepository
    {
        Task AddAsync(Product product);
        Task DeleteAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task UpdateAsync(Product product);
    }
}
