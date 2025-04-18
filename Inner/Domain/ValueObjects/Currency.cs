using CSharpFunctionalExtensions;

namespace Domain.ValueObjects
{
    public record struct Currency(decimal Value)
    {
        public static Result<Currency> Create(decimal Value)
        {
            return new Currency(Value);
        }

    }
}
