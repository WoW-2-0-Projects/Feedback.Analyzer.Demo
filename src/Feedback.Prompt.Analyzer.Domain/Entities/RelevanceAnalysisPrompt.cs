using Feedback.Prompt.Analyzer.Domain.Common.Prompts;
using Feedback.Prompt.Analyzer.Domain.Enums;

namespace Feedback.Prompt.Analyzer.Domain.Entities;

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