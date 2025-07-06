namespace ModelsAndModelBinding.Models;

/// <summary>
/// Represents an individual salable product
/// </summary>
public class Product
{
    /// <summary>
    /// A unique identifier for the product.
    /// The primary key of the product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// The consumer facing name of the product. May
    /// contain alphanumeric characters.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// The pre-tax sales price the customer must pay.
    /// </summary>
    public double Price { get; set; }

    /// <summary>
    /// The date and time that the product became
    /// available for sale
    /// </summary>
    public DateTime StartSalesDate { get; set; }
}