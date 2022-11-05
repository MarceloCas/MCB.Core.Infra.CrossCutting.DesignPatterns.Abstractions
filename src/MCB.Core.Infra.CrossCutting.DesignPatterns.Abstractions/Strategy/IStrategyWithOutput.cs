namespace MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Strategy;

public interface IStrategyWithOutput<out TOutput>
{
    TOutput? Execute();
}
