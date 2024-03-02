namespace Feedback.Prompt.Analyzer.Domain.Models.Entities;

/// <summary>
/// Represents feedback analysis result
/// </summary>
public class FeedbackAnalysisResult
{
    /// <summary>
    /// Gets or sets feedback relevance
    /// </summary>
    public FeedbackRelevance Relevance { get; set; } = new();
    
    /// <summary>
    /// Gets or sets extracted opinions
    /// </summary>
    public FeedbackOpinions Opinions { get; set; } = new();
}