using ElderMind.Domain.Abstractions.Factories;
using ElderMind.Domain.Enums;
using Microsoft.Extensions.AI;

namespace ElderMind.Ai.Factory;

public class ChatClientFactory : IChatClientFactory
{
    public IChatClient CreateAIChatClient(string apiKey, LlmType llmType)
    {
        return llmType switch
        {
            LlmType.Ollama => new OllamaSharp.OllamaApiClient(apiKey),
            LlmType.Google => new Google.GenAI.Client(apiKey: apiKey).AsIChatClient(),
            _=> throw new NotSupportedException($"The specified LLM type '{llmType}' is not supported.")
        };
    }
}
