using WWS_API.Domain.Entities;

namespace WWS_API.Application.Hanlders
{
    /// <summary>
    /// Handler for logging product details.
    /// </summary>
    public class ProductLoggingHandler : ProductHandlerBase
    {
        public override async Task HandleAsync(Product product)
        {
            // Log product details (for demonstration, using Console.WriteLine)
            Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price}, Discount: {product.Discount}");

            await base.HandleAsync(product);
        }
    }
}