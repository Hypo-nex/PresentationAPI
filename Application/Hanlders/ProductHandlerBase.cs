using WWS_API.Domain.Entities;

namespace WWS_API.Application.Hanlders
{
    /// <summary>
    /// Base class for implementing product handler logic.
    /// </summary>
    public abstract class ProductHandlerBase : IProductHandler
    {
        private IProductHandler _next;

        public IProductHandler SetNext(IProductHandler handler)
        {
            _next = handler;
            return handler;
        }

        public virtual async Task HandleAsync(Product product)
        {
            if(_next != null)
                await _next.HandleAsync(product);
        }
    }
}
