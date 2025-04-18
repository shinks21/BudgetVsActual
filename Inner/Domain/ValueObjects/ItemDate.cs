using CSharpFunctionalExtensions;

namespace Domain.ValueObjects
{
    public record struct ItemDate(DateOnly Value)
    {
        public static Result<ItemDate> Create(int Month, int Year)
        {
            return new ItemDate(DateOnly.Parse($"{Month}/1/{Year}"));
        }
    }
}
