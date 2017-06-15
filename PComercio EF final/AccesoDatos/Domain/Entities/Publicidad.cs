using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Domain.Entities
{
    public class Publicidad
    {
        public int id ;
        public string imagen ;
        public string descripcion_larga ;
        public string descripcion_corta ;
        public int? id_evento ;
        public int valido ;
        public int? id_empresa ;
    }
    public class PublicidadAbmDTO
    {
        public List<Empresa> Empresas;
        public List<Evento> Eventos;
        public List<Publicidad> Publicidads;
    }
}
