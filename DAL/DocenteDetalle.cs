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
    
    public partial class DocenteDetalle
    {
        public int DocenteId { get; set; }
        public int GeneroId { get; set; }
        public int EstadoCivilId { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string RFC { get; set; }
        public string Email { get; set; }
        public string TelefonoCelular { get; set; }
        public string TelefonoCasa { get; set; }
    
        public virtual Docente Docente { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        public virtual Genero Genero { get; set; }
    }
}
