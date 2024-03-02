namespace Feedback.Prompt.Analyzer.Domain.Models.Common;

/// <summary>
/// Determines feedback analysis result properties
/// </summary>
public interface IFeedbackAnalysisResult
{
    /// <summary>
    /// Refers to whether the result is processed result or default values
    /// </summary>
    bool IsProcessed { get; set; }
}