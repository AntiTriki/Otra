//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos.Infrastructure.Data.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuarioe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuarioe()
        {
            this.transaccion_previa = new HashSet<transaccion_previa>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidop { get; set; }
        public string apellidom { get; set; }
        public string correo { get; set; }
        public string contra { get; set; }
        public Nullable<int> valido { get; set; }
        public Nullable<int> telefono { get; set; }
        public string direccion { get; set; }
        public string imagen { get; set; }
        public string sexo { get; set; }
        public Nullable<System.DateTime> fecha_nac { get; set; }
        public string ocupacion { get; set; }
        public string estado_civil { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public Nullable<int> nit { get; set; }
        public string nombre_nit { get; set; }
        public string correo_nit { get; set; }
        public Nullable<int> id_metodo_pago { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transaccion_previa> transaccion_previa { get; set; }
    }
}
