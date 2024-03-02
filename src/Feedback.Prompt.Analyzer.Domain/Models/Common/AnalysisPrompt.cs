namespace Feedback.Prompt.Analyzer.Domain.Models.Common;

public abstract class AnalysisPrompt
{
    public string Prompt { get; set; } = default!;
    
    public int Version { get; set; }
}