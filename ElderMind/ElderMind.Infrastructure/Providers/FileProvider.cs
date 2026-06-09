using ElderMind.Domain.Abstractions.Providers;

namespace ElderMind.Infrastructure.Providers;

public class FileProvider : IFileProvider
{
    public async Task<string> ReadAsync(string fileName, CancellationToken cancellationToken = default)
    {
        return await File.ReadAllTextAsync(fileName, cancellationToken);
    }

    public async Task WriteAsync(string fileName, string content, CancellationToken cancellationToken = default)
    {
        await File.WriteAllTextAsync(fileName, content, cancellationToken);
    }
}