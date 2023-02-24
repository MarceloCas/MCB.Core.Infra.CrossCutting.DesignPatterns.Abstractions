namespace MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.ExecutionInfo;
public readonly record struct ExecutionInfo
{
    // Properties
    public Guid CorrelationId { get; }
    public Guid TenantId { get; }
    public string ExecutionUser { get; }
    public string SourcePlatform { get; }

    // Constructors
    public ExecutionInfo(
        Guid correlationId,
        Guid tenantId,
        string executionUser,
        string sourcePlatform
    )
    {
        CorrelationId = correlationId;
        TenantId = tenantId;
        ExecutionUser = executionUser;
        SourcePlatform = sourcePlatform;
    }
}
