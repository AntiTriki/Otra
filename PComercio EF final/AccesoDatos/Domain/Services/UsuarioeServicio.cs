using System;
using System.Collections.Generic;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.Repositories;

namespace AccesoDatos.Domain.Services
{
    public class UsuarioeServicio
    {
        private readonly UsuarioeRepositorio _usuarioRepositorio;
        private readonly PaisRepositorio _paisRepositorio;

        public UsuarioeServicio()
        {
            _usuarioRepositorio = new UsuarioeRepositorio();
            _paisRepositorio = new PaisRepositorio();
        }

        public int GuardarUsuarioe(int idUsuarioe, string usuario, string nombre, string correo, string clave, DateTime fechaNac, int sexo, int idPais)
        {
            if (idUsuarioe == 0)
                idUsuarioe = _usuarioRepositorio.GuardarUsuarioe(usuario, nombre, correo, clave, fechaNac, sexo, idPais);
            else
                _usuarioRepositorio.ModificarUsuarioe(idUsuarioe, usuario, nombre, correo, fechaNac, sexo, idPais);

            return idUsuarioe;
        }

        public void EliminarPais(int idUsuarioe)
        {
            _usuarioRepositorio.EliminarUsuarioe(idUsuarioe);
        }

        public List<UsuarioeDTO> ObtenerUsuarioes()
        {
            return _usuarioRepositorio.ObtenerUsuarioes();
        }

        public UsuarioeAbmDTO ObtenerUsuarioesAbm()
        {
            return new UsuarioeAbmDTO()
            {
                Usuarioes = _usuarioRepositorio.ObtenerUsuarioes(),
                Paises = _paisRepositorio.ObtenerPaises()
            };

        }

    }
}
