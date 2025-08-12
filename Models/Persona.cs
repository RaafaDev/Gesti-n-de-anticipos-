using System;
using System.Collections.Generic;   

namespace GestionAnticiposApp.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string TipoDocumento { get; set; } 
        public string NumeroDocumento { get; set; } 
        public string Nombres { get; set; }  
        public string Apellidos { get; set; } 
        public decimal Telefono { get; set; }
        public string LugarExpedicion { get; set; } 
        public DateTime FechaExpedicion { get; set; }
        public string Nacionalidad { get; set; }
        public string Direccion { get; set; }
        public string LugarNacimiento { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }

        public ICollection<Aprobacion> Aprobaciones { get; set; } 
        public ICollection<Notificacion> Notificaciones { get; set; }
        public ICollection<Contrato> Contratos { get; set; }
        public ICollection<Documento> Documentos { get; set; }
        public ICollection<ProcesoVinculado> ProcesosVinculados { get; set; }
    }
}
