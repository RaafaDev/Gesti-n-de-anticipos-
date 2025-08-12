using System;   
using System.Collections.Generic;

namespace GestionAnticiposApp.Models
{
    public class Contrato
    {
        public int IdContrato { get; set; }
        public string Codigo { get; set; }
        public string Estado { get; set; }
        public string Servicio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Empresa { get; set; }
        public string Referencia { get; set; }

        public int PersonaId { get; set; }
        public Persona Persona { get; set; }

        public ICollection<ProcesoVinculado> ProcesosVinculados { get; set; }
    }
}
