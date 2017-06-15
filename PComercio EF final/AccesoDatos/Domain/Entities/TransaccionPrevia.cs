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
        public List<TransaccionPrevia> TransaccionPrevias;
        public List<TipoEntrada> TipoEntradas;
        public List<Usuarioe> Usuarioes;
    }
}
