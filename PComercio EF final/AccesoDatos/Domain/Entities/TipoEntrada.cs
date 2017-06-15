using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Domain.Entities
{
    public class TipoEntrada
    {
        public int id ;
        public string nombre ;
        public string descripcion ;
        public int? id_evento ;
        public int? capacidad ;
        public string imagen ;
        public int valido ;
    }
    public class TipoEntradaAbmDTO
    {
        public List<Evento> Eventos;
        public List<TipoEntrada> TipoEntradas;

    }
}
