namespace ElderMind.Domain.Abstractions.Providers;

public interface IFileProvider
{
    Task<string> ReadAsync(string fileName, CancellationToken cancellationToken = default);
    Task WriteAsync(string fileName, string content, CancellationToken cancellationToken = default);
}