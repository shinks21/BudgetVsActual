using BudgetVsActual.API.Categories;
using BudgetVsActual.API.ToDo;

namespace BudgetVsActual.API
{
    public static class EndPoints
    {
        public static void Map(WebApplication app)
        {
            TodoEndpoints.Map(app);
            CategoryEndpoints.Map(app);
        }
    }
}
