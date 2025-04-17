using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public Guid CreatedBy { get; set; }
        public string CreatingUser { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; }
    }
}
