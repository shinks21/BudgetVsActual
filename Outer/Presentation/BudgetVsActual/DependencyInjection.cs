using BudgetVsActual.Infrastructure;

namespace BudgetVsActual
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthorization();

            services.AddEndpointsApiExplorer();

            services.AddExceptionHandler<GlobalExceptionHandler>();
            services.AddProblemDetails();

            services.AddRazorPages();

            //services.AddAuthorization(options =>
            //    options.AddPolicy("user", policy =>
            //      policy.RequireClaim(JwtClaimTypes.Role, "admin")
            //    )
            //);

            return services;
        }
    }
}
