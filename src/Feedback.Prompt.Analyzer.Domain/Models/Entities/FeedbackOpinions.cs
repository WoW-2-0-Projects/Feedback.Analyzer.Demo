using Feedback.Prompt.Analyzer.Domain.Models.Common;

namespace Feedback.Prompt.Analyzer.Domain.Models.Entities;

/// <summary>
/// Represents feedback opinions
/// </summary>
public class FeedbackOpinions : IFeedbackAnalysisResult
{
    public bool IsProcessed { get; set; }
    
    /// <summary>
    /// Gets or sets collection of opinions
    /// </summary>
    public ICollection<OpinionViewpoint> Opinions { get; set; } = default!;
}