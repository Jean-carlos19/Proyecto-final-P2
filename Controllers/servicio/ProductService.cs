using MiPrimerAPI.Controllers.Models;
using MiPrimerAPI.Controllers.servicio;
//using MiPrimerAPI.servicio;


namespace MiPrimerAPI.Services
{
    public class ProductServices (IProductRepository repository)
    {
        
        private readonly IProductRepository _repository = repository;

        internal IProductRepository Repository => _repository;

        internal IProductRepository Repository1 => _repository;

        public Task<IEnumerable<Product>> GetAllAsync() => _repository.GetAllAsync();
        public Task<Product?> GetByIdAsync(int id) => _repository.GetByIdAsync(id);
        public Task AddAsync(Product product) => _repository.AddAsync(product);
        public Task UpdateAsync(Product product) => _repository.UpdateAsync(product);
        public Task DeleteAsync(int id) => _repository.DeleteAsync(id);
    }
}