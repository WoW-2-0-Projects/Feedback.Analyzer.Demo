namespace Feedback.Prompt.Analyzer.Domain.Models.Entities;

/// <summary>
/// Represents product purchased by customer  
/// </summary>
public class Product
{
    /// <summary>
    /// Gets or sets product name
    /// </summary>
    public string Name { get; set; } = default!;
    
    /// <summary>
    /// Gets or sets product description
    /// </summary>
    public string Description { get; set; } = default!;
}