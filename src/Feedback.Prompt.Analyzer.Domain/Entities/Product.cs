using Feedback.Prompt.Analyzer.Domain.Common.Entities;

namespace Feedback.Prompt.Analyzer.Domain.Entities;

/// <summary>
/// Represents product purchased by customer  
/// </summary>
public class Product : AuditableEntity
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