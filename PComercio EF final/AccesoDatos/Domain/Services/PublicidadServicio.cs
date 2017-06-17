using System;
using System.Collections.Generic;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.Repositories;
using AccesoDatos.Infrastructure.Data.DataModels;

namespace AccesoDatos.Domain.Services
{
    public class PublicidadServicio
    {
        private readonly EventoRepositorio _eventoRepositorio;
        private readonly EmpresaRepositorio _empresaRepositorio;
        private readonly PublicidadRepositorio _publicidadRepositorio;
       
        public PublicidadServicio()
        {
            _eventoRepositorio = new EventoRepositorio();
            _publicidadRepositorio = new PublicidadRepositorio();
            
            _empresaRepositorio = new EmpresaRepositorio();
        }
        public int GuardarPublicidad(int id, string imagen, string descripcion_larga, string descripcion_corta, int id_evento, int valido, int id_empresa)
        {
            if (id == 0)
                id = _publicidadRepositorio.GuardarPublicidad( imagen, descripcion_larga,  descripcion_corta, id_evento, valido,  id_empresa);
            else
                _publicidadRepositorio.ModificarPublicidad(id, imagen, descripcion_larga, descripcion_corta, id_evento, valido, id_empresa);

            return id;
        }

        public void EliminarEvento(int id)
        {
            _publicidadRepositorio.EliminarPublicidad(id);
        }
        public void EliminarEmpresa(int id)
        {
            _publicidadRepositorio.EliminarPublicidad(id);
        }
      

        public List<publicidad> ObtenerPublicidads()
        {
            return _publicidadRepositorio.ObtenerPublicidads();
        }

        public PublicidadAbmDTO ObtenerPublicidadsAbm()
        {
            return new PublicidadAbmDTO()
            {
                Eventos = _eventoRepositorio.ObtenerEventos(),
                Empresas = _empresaRepositorio.ObtenerEmpresas(),
                
                Publicidads = _publicidadRepositorio.ObtenerPublicidads()
            };

        }
    }
}
