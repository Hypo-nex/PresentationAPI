using WWS_API.Domain.Entities;

namespace WWS_API.Application.Hanlders
{
    /// <summary>
    /// Handler for applying discounts to a product.
    /// </summary>
    public class ProductDiscountHandler : ProductHandlerBase
    {
        public override async Task HandleAsync(Product product)
        {
            if(product.Price > 100)
            {
                product.Discount = 0.1m; // 10% discount for products over $100
            }
            else
            {
                product.Discount = 0.05m; // 5% discount for products $100 or less
            }
            await base.HandleAsync(product);
        }
    }
}
