namespace MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.UnitOfWork;

public interface IUnitOfWork
{
    Task<bool> ExecuteAsync(Func<(bool openTransaction, CancellationToken cancellationToken), Task> handler, bool openTransaction, CancellationToken cancellationToken);
    Task<bool> ExecuteAsync<TInput>(Func<(TInput? input, bool openTransaction, CancellationToken cancellationToken), Task> handler, TInput? input, bool openTransaction, CancellationToken cancellationToken);
    Task<(bool success, TOutput? output)> ExecuteAsync<TInput, TOutput>(Func<(TInput? input, bool openTransaction, CancellationToken cancellationToken), Task<TOutput?>> handler, TInput? input, bool openTransaction, CancellationToken cancellationToken);
}
