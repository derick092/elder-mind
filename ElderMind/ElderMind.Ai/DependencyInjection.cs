using ElderMind.Ai.Agents;
using ElderMind.Ai.Factory;
using ElderMind.Ai.Providers;
using ElderMind.Domain.Abstractions;
using ElderMind.Domain.Abstractions.Agents;
using ElderMind.Domain.Abstractions.Factories;
using ElderMind.Domain.Abstractions.Providers;
using ElderMind.Domain.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace ElderMind.Ai;

public static class DependencyInjection
{
    public static IServiceCollection AddAgent(this IServiceCollection services)
    {
        services.AddTransient<IInstructionsProvider, FileInstructionsProvider>();
        services.AddSingleton<IChatClientFactory, ChatClientFactory>();
        services.AddKeyedTransient<IAgent<string,string>, CSharReviewerAgent>(AgentType.CSharReviewerAgent);

        return services;
    }
}