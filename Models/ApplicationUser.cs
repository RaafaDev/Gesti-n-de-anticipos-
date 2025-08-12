
using Microsoft.AspNetCore.Identity;

namespace GestionAnticiposApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int? PersonaId { get; set; }
        public Persona? Persona { get; set; }
    }
}

