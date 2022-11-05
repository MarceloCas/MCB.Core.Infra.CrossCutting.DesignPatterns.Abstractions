namespace MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Strategy;

public interface IAsyncStrategyWithOutput<TOutput>
{
    Task<TOutput> ExecuteAsync(CancellationToken cancellationToken);
}
