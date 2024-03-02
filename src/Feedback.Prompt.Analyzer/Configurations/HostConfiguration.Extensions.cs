using Feedback.Prompt.Analyzer.Benchmarks.Relevance;
using Microsoft.SemanticKernel;

namespace Feedback.Prompt.Analyzer.Configurations;

public static partial class HostConfiguration
{
    /// <summary>
    /// Configures exposers including controllers
    /// </summary>
    /// <param name="builder">Application builder</param>
    /// <returns></returns>
    private static WebApplicationBuilder AddSemanticKernelInfrastructure(this WebApplicationBuilder builder)
    {
        // Create kernel builder
        var kernelBuilder = Kernel.CreateBuilder();

        // Add OpenAI connector
        kernelBuilder.AddOpenAIChatCompletion(modelId: "gpt-3.5-turbo", apiKey: builder.Configuration["OpenAiApiSettings:ApiKey"]!);

        // Build kernel
        var kernel = kernelBuilder.Build();
        
        builder.Services.AddSingleton(kernel);

        return builder;
    }
    
    /// <summary>
    /// Configures exposers including controllers
    /// </summary>
    /// <param name="builder">Application builder</param>
    /// <returns></returns>
    private static WebApplicationBuilder AddPromptBenchmarkingInfrastructure(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<RelevanceBenchmarkService>();

        return builder;
    }

    /// <summary>
    /// Configures exposers including controllers
    /// </summary>
    /// <param name="builder">Application builder</param>
    /// <returns></returns>
    private static WebApplicationBuilder AddExposers(this WebApplicationBuilder builder)
    {
        builder.Services.AddRouting(options => options.LowercaseUrls = true);
        builder.Services.AddControllers();

        return builder;
    }

    /// <summary>
    /// Configures devTools including controllers
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    private static WebApplicationBuilder AddDevTools(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        return builder;
    }

    /// <summary>
    /// Add Controller middleWhere
    /// </summary>
    /// <param name="app">Application host</param>
    /// <returns>Application host</returns>
    private static WebApplication UseExposers(this WebApplication app)
    {
        app.MapControllers();

        return app;
    }

    /// <summary>
    /// Add Controller middleWhere
    /// </summary>
    /// <param name="app">Application host</param>
    /// <returns>Application host</returns>
    private static WebApplication UseDevTools(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        return app;
    }
}