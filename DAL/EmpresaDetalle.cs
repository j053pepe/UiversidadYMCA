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
    
    public partial class EmpresaDetalle
    {
        public int EmpresaId { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string EmailContacto { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public int PaisId { get; set; }
        public int EntidadFederativaId { get; set; }
        public int MunicipioId { get; set; }
        public string CP { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string Email { get; set; }
        public string Observacion { get; set; }
    
        public virtual Empresa Empresa { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
