using System;

namespace GestionAnticiposApp.Models
{
    public class Aprobacion
    {
        public int AprobacionId { get; set; }
        public string Estado { get; set; }
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }

        public int PersonaId { get; set; }
        public Persona Persona { get; set; }

        public int ProcesoVinculadoId { get; set; }
        public ProcesoVinculado ProcesoVinculado { get; set; }
    }
}
