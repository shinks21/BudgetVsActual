namespace BudgetVsActual.API.ToDo
{
    public static class TodoEndpoints
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/todo/", async context =>
            {
                // Get all todo items
                await context.Response.WriteAsJsonAsync(new { Message = "All todo items" });
            });

            //app.MapGet("/todo/{id}", async context =>
            //{
            //    // Get one todo item
            //    await context.Response.WriteAsJsonAsync(new { Message = $"One todo item." });
            //});
        }
    }
}
