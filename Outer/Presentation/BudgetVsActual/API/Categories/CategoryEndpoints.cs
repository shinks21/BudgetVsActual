
using Application.Categories.Create;
using CSharpFunctionalExtensions;
using Domain.ValueObjects;
using MediatR;

namespace BudgetVsActual.API.Categories
{
    public sealed class RequestCreate
    {
        public string CategoryName { get; set; } = string.Empty;
    }

    public static class CategoryEndpoints
    {
        public static void MapCategoryEndpoints(this WebApplication app)
        {
            app.MapPost("category", async (RequestCreate request, ISender sender,
                CancellationToken cancellationToken) =>
            {
                var command = new CreateCategoryCommand
                {
                    CategoryName = request.CategoryName
                };

                Result<IdGuid> result = await sender.Send(command, cancellationToken);

                return Results.Ok(result.Value.Value);
            });
        }
    }
}
