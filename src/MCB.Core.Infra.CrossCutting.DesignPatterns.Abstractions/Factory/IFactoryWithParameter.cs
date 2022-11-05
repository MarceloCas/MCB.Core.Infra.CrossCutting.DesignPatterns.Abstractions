namespace MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Factory;

public interface IFactoryWithParameter<out T, in TParameter>
{
    T? Create(TParameter? parameter);
}
