using JWTTokens.Abstraction;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWTTokens
{
    public class GenerateJwtToken : IGenerateJwtToken
    {
        string _jwtKey;

        public GenerateJwtToken(IConfiguration configuration)
        {
            _jwtKey = configuration.GetValue<string>("JWT:Key")
                ?? throw new InvalidOperationException("JWT Key not found.");
        }

        public string Generate(string username)
        {
            var claims = new[]
            {
                    new Claim(JwtRegisteredClaimNames.Sub, username), 
                  // Subject claim (the username)
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()) 
                  // Unique token ID
             };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtKey));
            // Create key from the secret
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            // Sign the token using HMAC SHA256

            // Create the token
            var token = new JwtSecurityToken(
                issuer: null, // Not using issuer validation
                audience: null, // Not using audience validation
                claims: claims,
                expires: DateTime.Now.AddMinutes(30), // Token expiration time
                signingCredentials: creds // Include signing credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
            // Return the token as a string
        }
    }
}
