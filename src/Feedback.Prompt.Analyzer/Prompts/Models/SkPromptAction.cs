using Microsoft.SemanticKernel;

namespace Test.Prompts.Models;

public class SkPromptAction
{
    public SkPrompt SkPrompt { get; set; } = default!;
    
    public KernelArguments KernelArguments { get; set; } = default!;
}