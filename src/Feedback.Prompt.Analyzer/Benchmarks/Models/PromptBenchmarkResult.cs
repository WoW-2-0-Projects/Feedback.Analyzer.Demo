using Test.Prompts.Models;

namespace Test.Benchmarks.Models;

public record PromptBenchmarkResult
{
    public TimeSpan ExecutionTime { get; set; }
    
    public SkPromptAction SkPromptAction { get; set; } = default!;

    public Exception Exception { get; set; } = default!;
    
    
}