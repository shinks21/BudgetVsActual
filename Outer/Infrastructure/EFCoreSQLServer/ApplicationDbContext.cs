using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BudgetVsActual.Data
{
    public class ApplicationDbContext :
        IdentityDbContext<
            ApplicationUser,
            ApplicationRole, Guid,
            IdentityUserClaim<Guid>,
            IdentityUserRole<Guid>,
            IdentityUserLogin<Guid>,
            IdentityRoleClaim<Guid>,
            IdentityUserToken<Guid>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
