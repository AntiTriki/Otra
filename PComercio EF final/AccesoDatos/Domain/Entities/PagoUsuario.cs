using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Domain.Entities
{
   public class PagoUsuario
    {
        public int id;
        public int? id_trans;
        public Nullable<System.DateTime> fecha_pago ;
        
        public int? monto ;
        public string factura ;
        public int valido ;
    }
    public class PagoUsuarioAbmDTO
    {
        public List<TransaccionPrevia> TransaccionPrevias;
        public List<PagoUsuario> PagoUsuarios;
   
    }
}
