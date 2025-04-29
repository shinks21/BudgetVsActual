namespace BudgetVsActual.API.JwtTokens
{
    public sealed class RequestCreate
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    //public static class JwtTokenEndpoints
    //{
    //    public static void Map(WebApplication app)
    //    {


    //        app.MapPost("login", async (RequestCreate request, IJWTService jwtService) =>
    //        {

    //            Result<IdGuid> result = await jwtService.GenerateJwtToken();

    //            return Results.Ok(result.Value.Value);
    //        }).RequireAuthorization();
    //    }
    //}
}
