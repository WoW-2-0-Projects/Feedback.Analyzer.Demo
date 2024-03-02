namespace Feedback.Prompt.Analyzer.Domain.Models.Entities;

/// <summary>
/// Represents customer feedback
/// </summary>
public class CustomerFeedback
{
    /// <summary>
    /// Gets or sets customer username
    /// </summary>
    public string UserName { get; set; } = default!;

    /// <summary>
    /// Gets or sets customer feedback comment
    /// </summary>
    public string Comment { get; set; } = default!;
}