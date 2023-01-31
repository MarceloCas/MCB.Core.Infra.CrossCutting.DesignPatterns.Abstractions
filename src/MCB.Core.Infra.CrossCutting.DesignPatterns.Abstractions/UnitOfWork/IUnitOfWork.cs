namespace MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.UnitOfWork;

public interface IUnitOfWork
{
    Task<bool> ExecuteAsync(Func<(bool OpenTransaction, bool IsBulkInsertOperation, CancellationToken CancellationToken), Task<bool>> handler, bool openTransaction, bool isBulkInsertOperation, CancellationToken cancellationToken);
    Task<bool> ExecuteAsync<TInput>(Func<(TInput? Input, bool OpenTransaction, bool IsBulkInsertOperation, CancellationToken CancellationToken), Task<bool>> handler, TInput? input, bool openTransaction, bool isBulkInsertOperation, CancellationToken cancellationToken);
    Task<(bool Success, TOutput? Output)> ExecuteAsync<TInput, TOutput>(Func<(TInput? Input, bool OpenTransaction, bool IsBulkInsertOperation, CancellationToken CancellationToken), Task<(bool Success, TOutput? Output)>> handler, TInput? input, bool openTransaction, bool isBulkInsertOperation, CancellationToken cancellationToken);
}
