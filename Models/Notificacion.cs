using System;

namespace GestionAnticiposApp.Models
{
    public class Notificacion
    {
        public int NotificacionId { get; set; }
        public string Origen { get; set; }
        public string Tipo { get; set; }
        public string Mensaje { get; set; }

        public int PersonaId { get; set; }
        public Persona Persona { get; set; }

        public int ProcesoVinculadoId { get; set; }
        public ProcesoVinculado ProcesoVinculado { get; set; }

    }
}