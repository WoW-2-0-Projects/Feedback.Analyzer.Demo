var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();


using Microsoft.Extensions.Configuration;
using Microsoft.SemanticKernel;

var configurationBuilder = new ConfigurationBuilder();
configurationBuilder.AddUserSecrets<Program>();
var configuration = configurationBuilder.Build();

// Create kernel builder
var kernelBuilder = Kernel.CreateBuilder();

// Add OpenAI connector
kernelBuilder.AddOpenAIChatCompletion(modelId:"gpt-3.5-turbo", apiKey: configuration["OpenAiApiSettings:ApiKey"]!);

// Build kernel
var kernel = kernelBuilder.Build();

var serviceDescription = """
                         Razer Viper Ultimate is our fastest wireless mouse yet, designed to be a true extension of a gamer.

                         74G LIGHTWEIGHT DESIGN
                         Enjoy faster and smoother control with a lightweight wireless mouse designed for esports. Weighing just 74g, it achieves its weight without compromising on the build strength of its ambidextrous form factor.

                         70 HOURS OF BATTERY LIFE
                         Improved wireless power efficiency keeps it running at peak performance for up to 70 continuous hours—charge it just once a week to power 10 hours of daily gameplay.

                         5 ON-BOARD MEMORY PROFILES
                         Bring your settings anywhere and be match-ready in no time. Activate up to 5 profile configurations from its onboard memory or custom settings via cloud storage.

                         8 PROGRAMMABLE BUTTONS
                         Fully configurable via Razer Synapse 3, the 8 programmable buttons let you access macros and secondary functions so you can execute extended moves with ease.
                         """;
var customerFeedback = "This mouse feels awesome! Super light and moves so smoothly. Definitely happy with my purchase.";

#region Relevance test


var relevancePrompt = $"""
                      ## Instructions"

                      Analyze user feedback and provide a relevance with the service in true or false format

                      Conditions :
                      1. feedback must include at least 1 sentence about the service
                      2. even feedbacks that have non-related content counts if the rule 1 is satisfied

                      ## Data
                      
                      {serviceDescription}
                      
                      ## Input
                      
                      {customerFeedback}
                      
                      ## Result
                      
                      """;

var relevanceResult = await kernel.InvokePromptAsync<string>(
    relevancePrompt,
    new KernelArguments
    {
        { "serviceDescription", serviceDescription },
        { "customerFeedback", customerFeedback }
    }
);


#endregion 


#region Test

#endregion 


#region Test

#endregion 


#region Test

#endregion 


#region Test

#endregion 


#region Test

#endregion 

Console.ReadLine();