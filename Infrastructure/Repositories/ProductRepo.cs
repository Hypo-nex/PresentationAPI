using Microsoft.EntityFrameworkCore;
using WWS_API.Application.Interfaces;
using WWS_API.Domain.Entities;
using WWS_API.Infrastructure.Data;

namespace WWS_API.Infrastructure.Repositories
{
    /// <summary>
    /// Interface for accessing product data.
    /// </summary>
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext _context;
        public ProductRepo(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all products asynchronously.
        /// </summary>
        /// <returns>A collection of products.</returns>
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        /// <summary>
        /// Adds a new product asynchronously.
        /// </summary>
        /// <param name="product">The product to add.</param>
        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }
    }
}