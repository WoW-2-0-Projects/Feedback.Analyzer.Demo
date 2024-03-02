using Feedback.Prompt.Analyzer.Domain.Enums;
using Feedback.Prompt.Analyzer.Domain.Models.Common;

namespace Feedback.Prompt.Analyzer.Domain.Models.Entities;

/// <summary>
/// Represents a prompt for relevance analysis.
/// </summary>
public class RelevanceAnalysisPrompt : AnalysisPrompt
{
    /// <summary>
    /// Indicates the type of relevance analysis process to be performed
    /// </summary>
    public FeedbackRelevanceAnalysisProcess PromptType { get; set; }
}