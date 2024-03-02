using Microsoft.SemanticKernel;

namespace Feedback.Prompt.Analyzer.Prompts.Models;

public class SkPromptAction
{
    public SkPrompt SkPrompt { get; set; } = default!;
    
    public KernelArguments KernelArguments { get; set; } = default!;
}