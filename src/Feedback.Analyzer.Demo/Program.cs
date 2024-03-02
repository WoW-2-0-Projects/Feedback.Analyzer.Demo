//create configurations

using Microsoft.Extensions.Configuration;
using Microsoft.SemanticKernel;

var configurationBuilder = new ConfigurationBuilder();
configurationBuilder.AddUserSecrets<Program>();
var configuration = configurationBuilder.Build();

//create kernel builder 
var kernelBuilder = Kernel.CreateBuilder();

//Add OpenAI connector
kernelBuilder.AddOpenAIChatCompletion(modelId:"gpt-3.5-turbo", apiKey: configuration["OpenAiApiSettings:ApiKey"]!);

//Build kernel
var kernel = kernelBuilder.Build();