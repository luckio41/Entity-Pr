//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profesor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Nullable<int> Num_celular { get; set; }
        public string Correo { get; set; }
        public Nullable<System.DateTime> Fecha_contrato { get; set; }
        public Nullable<int> Asignatura { get; set; }
    
        public virtual Asignatura Asignatura1 { get; set; }
    }
}
