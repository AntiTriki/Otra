using System.Collections.Generic;
using System.Linq;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.DataModels;
using System;

namespace AccesoDatos.Infrastructure.Data.Repositories
{
    public class UbicacionRepositorio : EFRepositorio<ubicacion_evento>
    {
        public int GuardarUbicacion(string nombre)
        {
            ubicacion_evento pais = new ubicacion_evento()
            {
                nombre = nombre,
                
            };
            Add(pais);
            SaveChanges();
            return pais.id;
        }
        public void ModificarUbicacion(int id, string nombre)
        {
            ubicacion_evento pais = this.Get(id);
            pais.nombre = nombre;
            
            Update(pais);
            SaveChanges();
        }

        public void EliminarUbicacion(int id)
        {
            ubicacion_evento pais = this.Get(id);
            Remove(pais);
            SaveChanges();
        }

        public ubicacion_evento ObtenerUbicacion(int id)
        {
            return Get(id);
        }

        public List<ubicacion_evento> ObtenerUbicaciones()
        {
            return GetAll();
        }
    }
}
