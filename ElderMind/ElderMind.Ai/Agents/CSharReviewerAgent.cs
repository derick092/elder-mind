using ElderMind.Ai.Models;
using ElderMind.Domain.Abstractions.Agents;
using ElderMind.Domain.Abstractions.Factories;
using ElderMind.Domain.Abstractions.Providers;
using ElderMind.Domain.Enums;
using Microsoft.Agents.AI;
using Microsoft.Extensions.AI;
using OllamaSharp;
using System.Reflection;

namespace ElderMind.Ai.Agents;

public class CSharReviewerAgent(
    IInstructionsProvider instructionsProvider, 
    IChatClientFactory chatClientFactory) : IAgent<string, string>
{
    private const string AgentName = "CSharpReviewerAgent";
    private const string Prompt = "Faça uma review do código a seguir:";
    private const float Temperature = 0.7f;

    public async Task<string> RunAsync(string code, LlmType llmType, CancellationToken cancellationToken)
    {
        var instructions = await instructionsProvider.GetInstructionAsync(AgentName, cancellationToken);

        const string ollamaUrl = "http://localhost:11434";

        var client = chatClientFactory.CreateAIChatClient(ollamaUrl, llmType);

        var codeReviewerAgent = client.AsAIAgent(new ChatClientAgentOptions
        {
            Name = AgentName,
            Description = "Agente especialista em code review para C# 14, focado em melhorias técnicas, performance e aplicação das especificações oficiais da Microsoft.",
            ChatOptions = new ChatOptions
            {
                ModelId = AiModels.Qwen25coder7b,
                Temperature = Temperature,
                Instructions =  instructions,
            }
        });

        var result = await codeReviewerAgent.RunAsync<string>($"{Prompt} {code}");

        return result.Text;
    }
}