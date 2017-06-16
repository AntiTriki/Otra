using System;
using System.Collections.Generic;
using System.Linq;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.DataModels;

namespace AccesoDatos.Infrastructure.Data.Repositories
{
   public class TipoEntradaRepositorio : EFRepositorio<tipoentrada>
    {
        public int GuardarTipoEntrada(string nombre, string descripcion, string imagen, int valido, int id_evento, int capacidad)
        {
            tipoentrada usr = new tipoentrada()
            {
                
                nombre = nombre,
                descripcion = descripcion,
                imagen = imagen,
                id_evento = id_evento,
                valido = valido,
                capacidad = capacidad
            };
            Add(usr);
            SaveChanges();
            return usr.id;
        }
        public void ModificarTipoEntrada(int id, string nombre, string descripcion, string imagen, int valido, int id_evento, int capacidad)
        {
            tipoentrada usr = this.Get(id);
            
            usr.nombre = nombre;
            usr.descripcion = descripcion;
            usr.imagen = imagen;
            usr.id_evento = id_evento;
            usr.capacidad = capacidad;
            usr.valido = valido;
            Update(usr);
            SaveChanges();
        }

        public void EliminarTipoEntrada(int id)
        {
            tipoentrada usr = this.Get(id);
            Remove(usr);
            SaveChanges();
        }

        public tipoentrada ObtenerTipoEntrada(int id)
        {
            return Get(id);
        }

        public List<tipoentrada> ObtenerTipoEntradas()
        {
            return GetAll();
        }
    }
}
