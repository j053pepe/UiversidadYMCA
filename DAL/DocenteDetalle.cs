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
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string CURP { get; set; }
        public string NumeroMigracion { get; set; }
        public Nullable<int> GeneroId { get; set; }
        public Nullable<int> EstadoCivilId { get; set; }
        public Nullable<int> PaisId { get; set; }
        public Nullable<int> EntidadNacimientoId { get; set; }
        public Nullable<int> EntidadFederativaId { get; set; }
        public Nullable<int> MunicipioId { get; set; }
        public string CP { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoOficina { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string EmailUniversidad { get; set; }
        public string RFC { get; set; }
        public string RazonSocial { get; set; }
        public string NoCuenta { get; set; }
        public string ClabeInterbancaria { get; set; }
    }
}
