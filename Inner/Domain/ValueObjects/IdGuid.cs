using CSharpFunctionalExtensions;

namespace Domain.ValueObjects
{
    public record IdGuid(Guid Value)
    {
        public static Result<IdGuid> Create()
        {
            return new IdGuid(Guid.CreateVersion7());
        }
    }
}
