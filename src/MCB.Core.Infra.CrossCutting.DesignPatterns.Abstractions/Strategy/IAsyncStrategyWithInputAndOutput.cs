namespace MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Strategy;

public interface IAsyncStrategyWithInputAndOutput<in TInput, TOutput>
{
    Task<TOutput> ExecuteAsync(TInput input, CancellationToken cancellationToken);
}
