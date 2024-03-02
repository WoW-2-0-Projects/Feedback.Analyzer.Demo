namespace Feedback.Prompt.Analyzer.AnalysisModels.Relevance;

public class RelevanceAnalysisResult
{
    public bool IsRelevant { get; set; }

    public string RelevantText { get; set; } = default!;

    public string Language { get; set; } = default!;
    
    public string PiiRedactedText { get; set; } = default!;
}