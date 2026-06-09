using ElderMind.Domain.Enums;
using Microsoft.Extensions.AI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElderMind.Domain.Abstractions.Factories;

public interface IChatClientFactory
{
    IChatClient CreateAIChatClient(string apiKey, LlmType llmType);
}
