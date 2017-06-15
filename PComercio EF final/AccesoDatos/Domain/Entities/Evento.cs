using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Domain.Entities
{
    public class Evento
    {
        public int id;
        public DateTime fecha_inicio_evento;
        public DateTime fecha_fin_evento;
        public DateTime fecha_inicio_publicacion;
        public DateTime fecha_fin_publicacion;
        public int? id_categoria_evento;
        public string nombre;
        public int? id_empresa;
        public string imagen;
        public string descripcion;
        public int? id_ubicacion;
        public int stock;
        public int stock_inicial;
        public int valido;

        public object IdPais { get; internal set; }
    }
    public class EventoAbmDTO
    {
        public List<Empresa> Empresas;
        public List<Evento> Eventos;
        public List<Ubicacion> Ubicacions;
        public List<CategoriaEvento> CategoriaEventos;
    }
}

