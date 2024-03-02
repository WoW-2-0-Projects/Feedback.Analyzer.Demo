using System.Diagnostics;
using Feedback.Prompt.Analyzer.Benchmarks.Models;
using Feedback.Prompt.Analyzer.Data.TrainingData;
using Feedback.Prompt.Analyzer.Prompts.Models;
using Microsoft.SemanticKernel;
using Feedback.Prompt.Analyzer.Exceptions;

namespace Feedback.Prompt.Analyzer.Benchmarks.Relevance;

public class RelevanceBenchmarkService(Kernel kernel)
{
    public async ValueTask<List<PromptBenchmarkResult>> AnalyzeRelevanceResultAsync(List<SkPrompt> promptActions, TrainingDataModel trainingDataModel)
    {
        var stopWatch = new Stopwatch();

        var executionActions = promptActions.Select(
                async promptAction =>
                {
                    stopWatch.Restart();
                    var kernelArguments = new KernelArguments
                    {
                        { "productDescription", trainingDataModel.Product.Description },
                        { "customerFeedback", trainingDataModel.Reviews.First().Comment }
                    };

                    var executePromptAction = () => kernel.InvokePromptAsync<string>(promptAction.PromptContent, kernelArguments);

                    var result = await executePromptAction.GetValueAsync();

                    stopWatch.Stop();

                    return new PromptBenchmarkResult
                    {
                        SkPromptAction = new SkPromptAction
                        {
                            SkPrompt = promptAction,
                            KernelArguments = kernelArguments
                        },
                        ExecutionTime = stopWatch.Elapsed,
                        Result = result!
                    };
                }
            )
            .ToList();

        return (await Task.WhenAll(executionActions)).ToList();
    }
    
    public async ValueTask<List<PromptBenchmarkResult>> AnalyzeRelevantContentExtractionAsync(List<SkPrompt> promptActions, TrainingDataModel trainingDataModel)
    {
        var stopWatch = new Stopwatch();

        var executionActions = promptActions.Select(
                async promptAction =>
                {
                    stopWatch.Restart();
                    var kernelArguments = new KernelArguments
                    {
                        { "productDescription", trainingDataModel.Product.Description },
                        { "customerFeedback", trainingDataModel.Reviews.First().Comment }
                    };

                    var executePromptAction = () => kernel.InvokePromptAsync<string>(promptAction.PromptContent, kernelArguments);

                    var result = await executePromptAction.GetValueAsync();

                    stopWatch.Stop();

                    return new PromptBenchmarkResult
                    {
                        SkPromptAction = new SkPromptAction
                        {
                            SkPrompt = promptAction,
                            KernelArguments = kernelArguments
                        },
                        ExecutionTime = stopWatch.Elapsed,
                        Result = result!
                    };
                }
            )
            .ToList();

        return (await Task.WhenAll(executionActions)).ToList();
    }
    
    
}