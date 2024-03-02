using Feedback.Prompt.Analyzer.Benchmarks.Relevance;
using Feedback.Prompt.Analyzer.Configurations;
using Feedback.Prompt.Analyzer.Data.Models;
using Feedback.Prompt.Analyzer.Data.TrainingData;
using Feedback.Prompt.Analyzer.Prompts.Models;

var builder = WebApplication.CreateBuilder(args);

await builder.ConfigureAsync();

var app = builder.Build();

await app.ConfigureAsync();

var relevanceAnalysisPrompts = new List<SkPrompt>
{
    new()
    {
        Name = "Test_01",
        PromptContent = """
                        ## Instructions"

                        Analyze user feedback and provide a relevance with the service in true or false format

                        Conditions :
                        1. feedback must include at least 1 sentence about the service
                        2. even feedbacks that have non-related content counts if the rule 1 is satisfied

                        ## Data
                        
                        {{$productDescription}}

                        ## Input

                        {{$customerFeedback}}

                        ## Result

                        """
    }
};

var relevanceExtractionPrompts = new List<SkPrompt>
{
    new()
    {
        Name = "Test_02",
        PromptContent = """
                        ## Instructions"

                        Extract only relevant parts of the customer feedback for the product

                        Requirements :
                        1. if feedback contains relevant content in different parts of the feedback, all relevant parts must be extracted and appended
                        2. try to extract as a readable sentence, not just words

                        ## Data

                        {{$productDescription}}

                        ## Input

                        {{$customerFeedback}}

                        ## Result

                        """
    }
};

var redactPiiPrompts = new List<SkPrompt>
{
    new()
    {
        Name = "Test_02",
        PromptContent = """
                        ## Instructions"

                        Redact personal information from the customer feedback
                        
                        Requirements :
                        1. redact only words that is considered as personal information, not the whole sentence
                        2. replace the redacted words with asterisks
                        3. make sure sentences are still readable

                        ## Data

                        {{$productDescription}}

                        ## Input

                        {{$customerFeedback}}

                        ## Result

                        """
    }
};

var recognizeLanguagePrompts = new List<SkPrompt>
{
    new()
    {
        Name = "Test_02",
        PromptContent = """
                        ## Instructions"
                        
                        Recognize languages from the customer feedback

                        Requirements :
                        1. list language if something readable or like a sentence written in it, not just a word
                        2. list all languages feedback contains multiple languages

                        ## Data

                        {{$productDescription}}

                        ## Input

                        {{$customerFeedback}}

                        ## Result

                        """
    }
};


var trainingData = new TrainingDataModel
{
    Product = new Product
    {
        Name = "Razer Viper Ultimate",
        Description = """
                      Razor Viper Ultimate - wireless gaming mouse
                      
                      Sensitivity: 20,000DPI 
                      Tracking Speed : 650IPS
                      Resolution accuracy : 99.6%
                      
                      74G LIGHTWEIGHT DESIGN
                      Enjoy faster and smoother control with a lightweight wireless mouse designed for esports. Weighing just 74g, it achieves its weight without compromising on the build strength of its ambidextrous form factor.
                      
                      70 HOURS OF BATTERY LIFE
                      Improved wireless power efficiency keeps it running at peak performance for up to 70 continuous hours—charge it just once a week to power 10 hours of daily gameplay.
                      
                      5 ON-BOARD MEMORY PROFILES
                      Bring your settings anywhere and be match-ready in no time. Activate up to 5 profile configurations from its onboard memory or custom settings via cloud storage.
                      
                      8 PROGRAMMABLE BUTTONS
                      Fully configurable via Razer Synapse 3, the 8 programmable buttons let you access macros and secondary functions so you can execute extended moves with ease.
                      """
    },
    Reviews =
    [
        new CustomerFeedback
        {
            UserName = "John",
            Comment = "I really like computer gaming and gaming keyboards. This mouse feels awesome! Super light and moves so smoothly. Definitely happy with my purchase. Last month my friend Mike also bought this mouse and recommended to me. ¡Este ratón es increíblemente rápido y preciso! Una verdadera ventaja para los juegos competitivos."
        }
    ]
};

await using var servicesScope = app.Services.CreateAsyncScope();
var relevanceBenchmarkService = servicesScope.ServiceProvider.GetRequiredService<RelevanceBenchmarkService>();

// var relevance = await relevanceBenchmarkService.AnalyzeRelevanceResultAsync(relevanceAnalysisPrompts, trainingData);

// var extractedRelevantContent = await relevanceBenchmarkService.AnalyzeRelevanceResultAsync(relevanceExtractionPrompts, trainingData);

// var redactedPersonalInformation = await relevanceBenchmarkService.AnalyzeRelevanceResultAsync(redactPiiPrompts, trainingData);

var recognizedLanguages = await relevanceBenchmarkService.AnalyzeRelevanceResultAsync(recognizeLanguagePrompts, trainingData);

await app.RunAsync();

// var configurationBuilder = new ConfigurationBuilder();
// configurationBuilder.AddUserSecrets<Program>();
// var configuration = configurationBuilder.Build();
//
// // Create kernel builder
// var kernelBuilder = Kernel.CreateBuilder();
//
// // Add OpenAI connector
// kernelBuilder.AddOpenAIChatCompletion(modelId:"gpt-3.5-turbo", apiKey: configuration["OpenAiApiSettings:ApiKey"]!);
//
// // Build kernel
// var kernel = kernelBuilder.Build();
//
// var serviceDescription = """
//                     
//                          """;
// var customerFeedback = "This mouse feels awesome! Super light and moves so smoothly. Definitely happy with my purchase.";
//
// #region Relevance test
//
//

//
// var relevanceResult = await kernel.InvokePromptAsync<string>(
//     relevancePrompt,
//     new KernelArguments
//     {
//         { "serviceDescription", serviceDescription },
//         { "customerFeedback", customerFeedback }
//     }
// );
//
//
// #endregion 
//
//
// #region Test
//
// #endregion 
//
//
// #region Test
//
// #endregion 
//
//
// #region Test
//
// #endregion 
//
//
// #region Test
//
// #endregion 
//
//
// #region Test
//
// #endregion 
//
// Console.ReadLine();