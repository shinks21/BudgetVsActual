using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
