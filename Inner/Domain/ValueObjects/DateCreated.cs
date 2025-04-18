using CSharpFunctionalExtensions;

namespace Domain.ValueObjects
{
    public record struct DateCreated(DateTime Value)
    {
        public static Result<DateCreated> Create()
        {
            return new DateCreated(DateTime.UtcNow);
        }
    }
}
