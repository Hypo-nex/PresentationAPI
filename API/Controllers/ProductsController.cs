using Microsoft.AspNetCore.Mvc;
using WWS_API.Application.Hanlders;
using WWS_API.Application.Interfaces;
using WWS_API.Domain.Entities;

namespace WWS_API.API.Controllers
{
    /// <summary>
    /// API controller for managing product operations.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepo _repo;
        private readonly IServiceProvider _provider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsController"/> class.
        /// </summary>
        /// <param name="repo">The product repository.</param>
        /// <param name="provider">The service provider for resolving handlers.</param>
        public ProductsController(IProductRepo repo, IServiceProvider provider)
        {
            _repo = repo;
            _provider = provider;
        }

        /// <summary>
        /// Creates a new product with validation, discount, and logging handlers.
        /// </summary>
        /// <param name="product">The product to be created.</param>
        /// <returns>HTTP response with the created product.</returns>
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            var validation = _provider.GetRequiredService<IProductHandler>();
            var discount = _provider.GetRequiredService<ProductDiscountHandler>();
            var logger = _provider.GetRequiredService<ProductLoggingHandler>();

            validation.SetNext(discount).SetNext(logger);

            await validation.HandleAsync(product);
            await _repo.AddAsync(product);

            return Ok(product);
        }

        /// <summary>
        /// Retrieves all products.
        /// </summary>
        /// <returns>HTTP response with the list of products.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _repo.GetAllAsync());
    }
}
