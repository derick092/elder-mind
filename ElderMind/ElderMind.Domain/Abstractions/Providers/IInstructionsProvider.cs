using System;
using System.Collections.Generic;
using System.Text;

namespace ElderMind.Domain.Abstractions.Providers;

public interface IInstructionsProvider
{
    Task<string> GetInstructionAsync(string agentName, CancellationToken cancellationToken);
}
