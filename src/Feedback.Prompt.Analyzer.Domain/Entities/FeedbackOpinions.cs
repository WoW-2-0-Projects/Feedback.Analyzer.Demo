using Feedback.Prompt.Analyzer.Domain.Common.Feedbacks;

namespace Feedback.Prompt.Analyzer.Domain.Entities;

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