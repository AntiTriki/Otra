using System;
using System.Collections.Generic;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.Repositories;
using AccesoDatos.Infrastructure.Data.DataModels;

namespace AccesoDatos.Domain.Services
{
    public class UsuarioeServicio
    {
        private readonly UsuarioeRepositorio _usuarioRepositorio;
        

        public UsuarioeServicio()
        {
            _usuarioRepositorio = new UsuarioeRepositorio();
            
        }

        public int GuardarUsuarioe(int id = 0, string nombre, string correo, string contra, DateTime fecha_nac, string sexo, string apellidop, string apellidom, string direccion, string imagen, DateTime fecha_registro, string nombre_nit, string correo_nit, int valido, int telefono, int nit, string estado_civil, string ocupacion)
        {
            if (id == 0)
                id = _usuarioRepositorio.GuardarUsuarioe( nombre,  correo, contra,  fecha_nac,  sexo,  apellidop,  apellidom, direccion,  imagen, fecha_registro,  nombre_nit,  correo_nit,  valido,  telefono,  nit,  estado_civil, ocupacion);
            else
                _usuarioRepositorio.ModificarUsuarioe(id, nombre, correo, contra, fecha_nac, sexo, apellidop, apellidom, direccion, imagen, fecha_registro, nombre_nit, correo_nit, valido, telefono, nit, estado_civil, ocupacion);

            return id;
        }

        public void EliminarUsuarioe(int idUsuarioe)
        {
            _usuarioRepositorio.EliminarUsuarioe(idUsuarioe);
        }

        public List<usuarioe> ObtenerUsuarioes()
        {
            return _usuarioRepositorio.ObtenerUsuarioes();
        }

       

    }
}
