using System;   
using System.Collections.Generic;

namespace GestionAnticiposApp.Models
{
    public class ProcesoVinculado
    {
        public int ProcesoVinculadoId { get; set; }
        public int Codigo { get; set; }
        public string Estado { get; set; }
        public string Funcionario { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Autorizador { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }

        public int PersonaId { get; set; }
        public Persona Persona { get; set; }

        public int ContratoId { get; set; }
        public Contrato Contrato { get; set; }

        public ICollection<Notificacion> Notificaciones { get; set; }
        public ICollection<Aprobacion> Aprobaciones { get; set; }
        public ICollection<Documento> Documentos { get; set; }
    }
}