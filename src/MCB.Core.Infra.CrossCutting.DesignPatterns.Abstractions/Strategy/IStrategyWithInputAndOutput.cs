namespace MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Strategy;

public interface IStrategyWithInputAndOutput<in TInput, out TOutput>
{
    TOutput? Execute(TInput? input);
}
