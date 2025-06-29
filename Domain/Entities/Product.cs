namespace WWS_API.Domain.Entities
{
    /// <summary>
    /// Represents a product entity.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the Id of the Product.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the product description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the available quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the product price per unit.
        /// </summary>
       
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the discount applied to the product.
        /// </summary>
        public decimal Discount { get; set; } = 0.0m; // Default discount is 0
    }
}
