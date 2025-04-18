using Domain.ValueObjects;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public bool Active { get; set; }
        public DateCreated DateCreated { get; set; }
    }
}
