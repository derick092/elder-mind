using ElderMind.Domain.Enums;

namespace ElderMind.Domain.Abstractions.Agents;

public interface IAgent<in TData, TResponse>
    where TData : class
    where TResponse : class
{
    Task<TResponse> RunAsync(TData prompt, LlmType llmType, CancellationToken cancellationToken);
}