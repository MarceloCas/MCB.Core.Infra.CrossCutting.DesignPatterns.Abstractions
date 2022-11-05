namespace MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Strategy;

public interface IAsyncStrategyWithInput<in TInput>
{
    Task ExecuteAsync(TInput input, CancellationToken cancellationToken);
}
