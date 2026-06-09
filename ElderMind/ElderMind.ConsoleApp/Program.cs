using ElderMind.Ai;
using ElderMind.Ai.Agents;
using ElderMind.Domain.Abstractions.Agents;
using ElderMind.Domain.Abstractions.Providers;
using ElderMind.Domain.Enums;
using ElderMind.Infrastructure;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.DependencyInjection;
using static OllamaSharp.OllamaApiClient;

var services = new ServiceCollection();
services.AddInfrastructure();
services.AddAgent();

var serviceProvider = services.BuildServiceProvider();
var fileProvider = serviceProvider.GetRequiredService<IFileProvider>();
var cSharReviewerAgent = serviceProvider.GetKeyedService<IAgent<string, string>>(AgentType.CSharReviewerAgent);

Console.WriteLine("Qual o caminho do arquivo?");
var codePath = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(codePath))
{
    var codeString = await fileProvider.ReadAsync(codePath);
    var result = await cSharReviewerAgent!.RunAsync(codeString, LlmType.Ollama, CancellationToken.None);

    Console.WriteLine(result);

    Console.ReadLine();
}