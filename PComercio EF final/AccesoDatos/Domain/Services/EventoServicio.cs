using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.Repositories;

namespace AccesoDatos.Domain.Services
{
    public class EventoServicio
    {
        private readonly EventoRepositorio _eventoRepositorio;
        private readonly CategoriaEventoRepositorio _categoriaRepositorio;
        private readonly UbicacionRepositorio _ubicacionRepositorio;
        public EventoServicio()
        {
            _eventoRepositorio = new EventoRepositorio();
            _categoriaRepositorio = new CategoriaEventoRepositorio();
            _ubicacionRepositorio = new UbicacionRepositorio();
        }
        public int GuardarEvento(int id, string nombre, string descripcion, DateTime fecha_inicio_evento, DateTime fecha_fin_evento, DateTime fecha_inicio_publicacion, DateTime fecha_fin_publicacion, int id_empresa, int id_categoria, int stock_inicial, int stock, int id_ubicacion, string imagen, int valido)
        {
            if (id == 0)
                id = _eventoRepositorio.GuardarEvento( nombre, descripcion,  fecha_inicio_evento,  fecha_fin_evento, fecha_inicio_publicacion, fecha_fin_publicacion,  id_empresa,  id_categoria,  stock_inicial,  stock, id_ubicacion,imagen, valido);
            else
                _eventoRepositorio.ModificarEvento(id, nombre, descripcion, fecha_inicio_evento, fecha_fin_evento, fecha_inicio_publicacion, fecha_fin_publicacion, id_empresa, id_categoria, stock_inicial, stock, id_ubicacion, imagen, valido);

            return id;
        }

        public void EliminarCategoria(int id)
        {
            _eventoRepositorio.EliminarEvento(id);
        }

        public List<Evento> ObtenerEventos()
        {
            return _eventoRepositorio.ObtenerEventos();
        }

        public EventoAbmDTO ObtenerEventosAbm()
        {
            return new EventoAbmDTO()
            {
                Eventos = _eventoRepositorio.ObtenerEventos(),
                CategoriaEventos = _categoriaRepositorio.ObtenerCategoriaEventos()
            };

        }

    }
}
