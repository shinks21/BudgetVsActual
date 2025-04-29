using JWTTokens.Abstraction;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace JWTTokens
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure_JWTTokens(IServiceCollection services, IConfiguration configuration)
        {
            var jwtKey = configuration.GetValue<string>("JWT:Key")
                ?? throw new InvalidOperationException("JWT Key not found.");

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
               .AddJwtBearer(options =>
               {
                   options.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuer = true,
                       ValidateAudience = true,
                       ValidIssuer = "YourIssuer",
                       ValidAudience = "YourAudience",
                       IssuerSigningKey = new
                           SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey))
                   };
               });

            services.AddSingleton<IGenerateJwtToken, GenerateJwtToken>();

            return services;
        }
    }
}
