using System;
using System.Collections.Generic;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.Repositories;
using AccesoDatos.Infrastructure.Data.DataModels;

namespace AccesoDatos.Domain.Services
{
    public class UbicacionServicio
    {
        private readonly UbicacionRepositorio _paisRepositorio;

        public UbicacionServicio()
        {
            _paisRepositorio = new UbicacionRepositorio();
        }

        public int GuardarUbicacion(string nombre,  int id= 0)
        {
            if (id == 0)
                id = _paisRepositorio.GuardarUbicacion(nombre);
            else
                _paisRepositorio.ModificarUbicacion(id, nombre);

            return id;
        }

        public void EliminarUbicacion(int id)
        {
            _paisRepositorio.EliminarUbicacion(id);
        }

        public List<ubicacion_evento> ObtenerUbicaciones()
        {
            return _paisRepositorio.ObtenerUbicaciones();
        }
    }
}
