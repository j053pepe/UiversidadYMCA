//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CancelacionDocenteEstudio
    {
        public int CancelacionDocenteEstudio1 { get; set; }
        public int DocenteEstudioPeriodoId { get; set; }
        public string Comentario { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.TimeSpan Hora { get; set; }
        public int UsuarioId { get; set; }
    
        public virtual DocenteEstudioPeriodo DocenteEstudioPeriodo { get; set; }
    }
}
