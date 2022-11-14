namespace MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Observer;

public interface IPublisher
{
    void Subscribe(Type subscriberType, Type subjectType);
    void Subscribe<TSubscriber>(Type subjectType);
    void Subscribe<TSubscriber, TSubject>() where TSubscriber : ISubscriber<TSubject>;
    Task PublishAsync<TSubject>(TSubject subject, CancellationToken cancellationToken);
    Task PublishAsync<TSubject>(TSubject subject, Type subjectCustomType, CancellationToken cancellationToken);
}
