using Feedback.Prompt.Analyzer.Domain.Common.Feedbacks;

namespace Feedback.Prompt.Analyzer.Domain.Entities;

/// <summary>
/// Represents feedback relevance
/// </summary>
public class FeedbackRelevance : IFeedbackAnalysisResult
{
    public bool IsProcessed { get; set; }
    
    /// <summary>
    /// Indicates whether the feedback is relevant
    /// </summary>
    public bool IsRelevant { get; set; }

    /// <summary>
    /// Gets or sets feedback relevant content
    /// </summary>
    public string RelevantContent { get; set; } = default!;
    
    /// <summary>
    /// Gets or sets personal information redacted content
    /// </summary>
    public string PiiRedactedContent { get; set; } = default!;
}