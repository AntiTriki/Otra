using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.Repositories;

namespace AccesoDatos.Domain.Services
{
    public class EVentoServicio
    {
        private readonly EventoRepositorio _eventoRepositorio;
        private readonly CategoriaRepositorio _categoriaRepositorio;

        public EventoServicio()
        {
            _eventoRepositorio = new EventoRepositorio();
            _categoriaRepositorio = new CategoriaRepositorio();
        }
        public int GuardarEvento(int id, string correo, string nombre, string contra, string imagen, string descripcion, string direccion, string telefono, int valido, int id_categoria)
        {
            if (id == 0)
                id = _eventoRepositorio.GuardarEvento(correo, nombre, contra, imagen, descripcion, direccion, telefono, valido, id_categoria);
            else
                _eventoRepositorio.ModificarEvento(id, correo, nombre, contra, imagen, descripcion, direccion, telefono, id_categoria);

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
                Categorias = _categoriaRepositorio.ObtenerCategorias()
            };

        }

    }
}
