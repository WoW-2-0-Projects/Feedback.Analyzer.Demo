using Feedback.Prompt.Analyzer.Exceptions;
using Feedback.Prompt.Analyzer.Prompts.Models;

namespace Feedback.Prompt.Analyzer.Benchmarks.Models;

public record PromptBenchmarkResult
{
    public SkPromptAction SkPromptAction { get; set; } = default!;

    public TimeSpan ExecutionTime { get; set; }
    
    public FuncResult<string> Result { get; set; } = default!;
}