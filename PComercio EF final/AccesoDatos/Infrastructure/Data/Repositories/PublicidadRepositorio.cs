using System;
using System.Collections.Generic;
using System.Linq;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.DataModels;

namespace AccesoDatos.Infrastructure.Data.Repositories
{
    public class PublicidadRepositorio : EFRepositorio<publicidad>
    {
        public int GuardarPublicidad(string imagen, string descripcion_larga, string descripcion_corta, int id_evento, int valido, int id_empresa)
        {
            publicidad usr = new publicidad()
            {
                imagen = imagen,
                descripcion_larga = descripcion_larga,
                descripcion_corta = descripcion_corta,
                id_evento = id_evento == 0 ? (int?)null : id_evento,
                id_empresa = id_empresa == 0 ? (int?)null : id_empresa,
                valido = valido
            };
            Add(usr);
            SaveChanges();
            return usr.id;
        }
        public void ModificarPublicidad(int id, string imagen, string descripcion_larga, string descripcion_corta, int id_evento, int valido, int id_empresa)
        {
            publicidad usr = this.Get(id);
            
            usr.imagen = imagen;
            usr.descripcion_larga = descripcion_larga;
            usr.descripcion_corta = descripcion_corta;
            usr.id_evento = (int?)id_evento;
            usr.id_empresa = (int?)id_empresa;
            usr.valido = valido;
            Update(usr);
            SaveChanges();
        }

        public void EliminarPublicidad(int id)
        {
            publicidad usr = this.Get(id);
            Remove(usr);
            SaveChanges();
        }

        public publicidad ObtenerPublicidad(int id)
        {
            return Get(id);
        }

        public List<publicidad> ObtenerPublicidads()
        {
            return GetAll();
        }
    }
}
