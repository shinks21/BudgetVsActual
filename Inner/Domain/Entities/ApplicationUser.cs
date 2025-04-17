using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string CreatingUser { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; }
    }
}
