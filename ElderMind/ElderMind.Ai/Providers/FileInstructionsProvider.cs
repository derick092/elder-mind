using ElderMind.Domain.Abstractions.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElderMind.Ai.Providers;

public class FileInstructionsProvider : IInstructionsProvider
{
    public async Task<string> GetInstructionAsync(string agentName, CancellationToken cancellationToken)
    {
        var assembly = typeof(FileInstructionsProvider).Assembly;

        var resourceName = $"ElderMind.Ai.Instructions.{agentName}.yaml";
        await using var stream = assembly.GetManifestResourceStream((resourceName));

        if (stream is null)
            throw new FileNotFoundException($"Instruction for {agentName} not found: {resourceName}");

        using var reader = new StreamReader(stream);
        return await reader.ReadToEndAsync();
    }
}
