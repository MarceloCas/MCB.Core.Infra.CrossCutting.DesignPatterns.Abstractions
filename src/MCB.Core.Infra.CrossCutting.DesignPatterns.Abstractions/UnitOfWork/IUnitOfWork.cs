namespace MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.UnitOfWork;

public interface IUnitOfWork
{
    Task<bool> ExecuteAsync(Func<CancellationToken, Task> handler, CancellationToken cancellationToken);
    Task<bool> ExecuteAsync<TInput>(Func<TInput?, CancellationToken, Task> handler, TInput? input, CancellationToken cancellationToken);
    Task<(bool success, TOutput? output)> ExecuteAsync<TInput, TOutput>(Func<TInput?, CancellationToken, Task<TOutput?>> handler, TInput? input, CancellationToken cancellationToken);
}
