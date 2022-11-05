namespace MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Strategy;

public interface IStrategyWithInput<in TInput>
{
    void Execute(TInput? input);
}
