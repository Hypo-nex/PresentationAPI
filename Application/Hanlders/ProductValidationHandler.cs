using WWS_API.Domain.Entities;

namespace WWS_API.Application.Hanlders
{
    /// <summary>
    /// Handler for validating product data.
    /// </summary>
    public class ProductValidationHandler : ProductHandlerBase
    {
        public override async Task HandleAsync(Product product)
        {
            if(string.IsNullOrWhiteSpace(product.Name) || product.Price < 0)
                throw new ArgumentException("Product contains invalid Data ");

            await base.HandleAsync(product);
        }
    }
}
