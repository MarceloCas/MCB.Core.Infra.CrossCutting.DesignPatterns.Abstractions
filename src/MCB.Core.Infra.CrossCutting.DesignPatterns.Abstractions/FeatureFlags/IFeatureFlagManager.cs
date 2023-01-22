namespace MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.FeatureFlags;

public interface IFeatureFlagManager
{
    bool GetFlag(string key);
    Task<bool> GetFlagAsync(string key, CancellationToken cancellationToken);

    void AddOrUpdateFlag(string key, bool value);
    Task AddOrUpdateFlagAsync(string key, bool value, CancellationToken cancellationToken);

    void RemoveFlag(string key);
    Task RemoveFlagAsync(string key, CancellationToken cancellationToken);
}

