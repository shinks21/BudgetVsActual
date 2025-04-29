namespace JWTTokens.Abstraction
{
    public interface IGenerateJwtToken
    {
        string Generate(string username);
    }
}