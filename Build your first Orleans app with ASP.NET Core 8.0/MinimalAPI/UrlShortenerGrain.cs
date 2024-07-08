namespace MinimalAPI;

/// <summary>
/// A <see cref="Grain"/> that stores a shortened URL
/// </summary>
public sealed class UrlShortenerGrain : Grain, IUrlShortenerGrain
{
    private KeyValuePair<string, string> _cache;

    public Task SetUrl(string fullUrl)
    {
        _cache = new(
            key: this.GetPrimaryKeyString(),
            value: fullUrl);

        return Task.CompletedTask;
    }

    public Task<string> GetUrl() =>
        Task.FromResult(_cache.Value);
}