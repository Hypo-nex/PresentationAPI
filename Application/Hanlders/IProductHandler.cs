using WWS_API.Domain.Entities;

namespace WWS_API.Application.Hanlders
{
    /// <summary>
    /// Interface for handling product logic using the chain of responsibility pattern.
    /// </summary>
    public interface IProductHandler
    {
        /// <summary>
        /// Sets the next handler in the chain.
        /// </summary>
        /// <param name="handler">The next product handler.</param>
        /// <returns>The next handler.</returns>
        IProductHandler SetNext(IProductHandler handler);

        /// <summary>
        /// Processes the product asynchronously.
        /// </summary>
        /// <param name="product">The product to process.</param>
        Task HandleAsync(Product product);
    }
}
