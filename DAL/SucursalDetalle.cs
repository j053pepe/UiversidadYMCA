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
    
    public partial class SucursalDetalle
    {
        public int SucursalId { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string Colonia { get; set; }
        public string Cp { get; set; }
        public string Delegacion { get; set; }
        public int PaisId { get; set; }
        public int EntidadFederativaId { get; set; }
        public string Telefono { get; set; }
    
        public virtual Pais Pais { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}
