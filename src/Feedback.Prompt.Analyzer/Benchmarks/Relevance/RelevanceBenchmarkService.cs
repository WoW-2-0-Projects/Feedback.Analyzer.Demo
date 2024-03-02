using Microsoft.SemanticKernel;
using Test.Benchmarks.Models;
using Test.Data.TrainingData;
using Test.Prompts.Models;

namespace Test.Benchmarks.Relevance;

public class RelevanceBenchmarkService(Kernel kernel)
{
    public ValueTask<List<PromptBenchmarkResult>> AnalyzeRelevanceResultAsync(List<SkPrompt> promptActions, TrainingDataModel trainingDataModel)
    {
        return promptActions.Select(
                promptAction =>
                {
                    var executePromptAction = () => kernel.InvokePromptAsync<string>(
                        promptAction.PromptContent,
                        new KernelArguments
                        {
                            { "productDescription", trainingDataModel.Product.Description },
                            { "customerFeedback", trainingDataModel.Reviews.First().Comment }
                        }
                    );
                }
            )
            .ToList();
    }
}