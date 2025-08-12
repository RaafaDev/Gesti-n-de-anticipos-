using System;

namespace GestionAnticiposApp.Models
{
    public class Documento
    {
        public int IdDocumento { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Archivo { get; set; } 
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
        
        public int ProcesoVinculadoId { get; set; }
        public ProcesoVinculado ProcesoVinculado { get; set; }
    }
}
