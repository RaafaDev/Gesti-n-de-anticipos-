using System;   
using System.Collections.Generic;

namespace GestionAnticiposApp.Models
{
    public class ProcesoVinculado
    {
        public int IdProcesoVinculado { get; set; }
        public int Codigo { get; set; }
        public string Estado { get; set; }
        public string Funcionario { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Autorizador { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }

        public int IdPersona { get; set; }
        public Persona Persona { get; set; }
        public int IdContrato { get; set; }
        public Contrato Contrato { get; set; }


        public ICollection<Notificacion> Notificaciones { get; set; }
        public ICollection<Aprobacion> Aprobaciones { get; set; }
        public ICollection<Documento> Documentos { get; set; }
    }
}
