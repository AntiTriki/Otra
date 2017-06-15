using System;
using System.Collections.Generic;
using System.Linq;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.DataModels;

namespace AccesoDatos.Infrastructure.Data.Repositories
{
    public class EventoRepositorio : EFRepositorio<evento_empresa>
    {
        public int GuardarEvento(string nombre, string descripcion, DateTime fecha_inicio_evento, DateTime fecha_fin_evento, DateTime fecha_inicio_publicacion, DateTime fecha_fin_publicacion,int id_empresa, int id_categoria,int stock_inicial,int stock,int id_ubicacion, string imagen, int valido)
        {
            evento_empresa ev = new evento_empresa()
            {
                nombre = nombre,
                descripcion = descripcion,
                fecha_inicio_evento = fecha_inicio_evento,
                fecha_fin_evento = fecha_fin_evento,
                fecha_inicio_publicacion = fecha_inicio_publicacion,
                fecha_fin_publicacion = fecha_fin_publicacion,
                id_empresa = id_empresa,
                id_categoria = id_categoria,
                stock_inicial = stock_inicial,
                stock = stock,
                id_ubicacion = id_ubicacion,
                imagen = imagen,
                valido = valido
            };
            Add(ev);
            SaveChanges();
            return ev.id;
        }
        public void ModificarEvento(int id, string nombre, string descripcion, DateTime fecha_inicio_evento, DateTime fecha_fin_evento, DateTime fecha_inicio_publicacion, DateTime fecha_fin_publicacion, int id_empresa, int id_categoria, int stock_inicial, int stock, int id_ubicacion, string imagen, int valido)
        {
            evento_empresa ev = this.Get(id);
            
            ev.nombre = nombre;
            ev.descripcion = descripcion;
            ev.fecha_inicio_evento = fecha_inicio_evento;
            ev.fecha_fin_evento = fecha_fin_evento;
            ev.fecha_inicio_publicacion = fecha_inicio_publicacion;
            ev.fecha_fin_publicacion = fecha_fin_publicacion;
            ev.id_empresa = id_empresa;
            ev.id_categoria = id_categoria;
            ev.stock_inicial = stock_inicial;
            ev.stock = stock;
            ev.id_ubicacion = id_ubicacion;
            ev.imagen = imagen;
            ev.valido = valido;
            Update(ev);
            SaveChanges();
        }

        public void EliminarEvento(int id)
        {
            evento_empresa ev = this.Get(id);
            Remove(ev);
            SaveChanges();
        }

        public evento_empresa ObtenerEvento(int id)
        {
            return Get(id);
        }

        public List<Evento> ObtenerEventos()
        {
            return GetAll().Select(x => new Evento()
            {
                id = x.id,

                nombre = x.nombre,
                descripcion = x.descripcion,
                fecha_inicio_evento = x.fecha_inicio_evento.Value,
                fecha_fin_evento = x.fecha_fin_evento.Value,
                fecha_inicio_publicacion = x.fecha_inicio_publicacion.Value,
                fecha_fin_publicacion = x.fecha_fin_publicacion.Value,
                id_empresa = x.id_empresa,
                id_categoria_evento = x.id_categoria,
                stock_inicial = x.stock_inicial.Value,
                stock = x.stock.Value,
                id_ubicacion = x.id_ubicacion.Value,
                imagen = x.imagen,
                valido = x.valido
            }).ToList();
        }
    }
}
