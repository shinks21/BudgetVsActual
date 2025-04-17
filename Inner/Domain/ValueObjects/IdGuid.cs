namespace Domain.ValueObjects
{
    public record struct IdGuid(Guid Value)
    {
        IdGuid New() => new IdGuid(Guid.CreateVersion7());
    }
}
