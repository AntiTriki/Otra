using AccesoDatos.Infrastructure.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Domain.Entities
{
    public class TransaccionPrevia
    {
        public int id ;
        public Nullable<System.DateTime> fecha ;
        public int? id_usuario ;
        public int? cantidad ;
        public int? id_tipoentrada ;
        public int valido ;
    }
    public class TransaccionPreviaAbmDTO
    {
        public List<transaccion_previa> TransaccionPrevias;
        public List<tipoentrada> TipoEntradas;
        public List<usuarioe> Usuarioes;
    }
}
