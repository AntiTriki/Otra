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
    
    public partial class transaccion_previa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public transaccion_previa()
        {
            this.pago_usuario = new HashSet<pago_usuario>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> id_usuario { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<int> id_tipoentrada { get; set; }
        public int valido { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pago_usuario> pago_usuario { get; set; }
        public virtual tipoentrada tipoentrada { get; set; }
        public virtual usuarioe usuarioe { get; set; }
    }
}
