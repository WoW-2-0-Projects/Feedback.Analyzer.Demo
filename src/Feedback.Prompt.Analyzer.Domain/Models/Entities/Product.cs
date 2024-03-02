namespace Feedback.Prompt.Analyzer.Domain.Models.Entities;

/// <summary>
/// Represents product purchased by customer  
/// </summary>
public class Product
{
    public string Name { get; set; } = default!;
    
    public string Description { get; set; } = default!;
}