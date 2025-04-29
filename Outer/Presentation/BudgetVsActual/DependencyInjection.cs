namespace BudgetVsActual
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddAuthentication();
            services.AddAuthorization();

            services.AddEndpointsApiExplorer();

            //services.AddExceptionHandler<GlobalExceptionHandler>();
            //services.AddProblemDetails();

            services.AddRazorPages();

            return services;
        }
    }
}
