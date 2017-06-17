using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.Repositories;
using AccesoDatos.Infrastructure.Data.DataModels;

namespace AccesoDatos.Domain.Services
{
   public class TipoEntradaServicio
    {
        private readonly EventoRepositorio _eventoRepositorio;
        
        private readonly TipoEntradaRepositorio _tipoentradaRepositorio;

        public TipoEntradaServicio()
        {
            _eventoRepositorio = new EventoRepositorio();
            _tipoentradaRepositorio = new TipoEntradaRepositorio();

            
        }
        public int GuardarTipoEntrada(int id, string nombre, string descripcion, string imagen, int valido, int id_evento, int capacidad)
        {
            if (id == 0)
                id = _tipoentradaRepositorio.GuardarTipoEntrada(nombre,  descripcion,  imagen, valido,  id_evento, capacidad);
            else
                _tipoentradaRepositorio.ModificarTipoEntrada(id, nombre, descripcion, imagen, valido, id_evento, capacidad);

            return id;
        }

        public void EliminarEvento(int id)
        {
            _tipoentradaRepositorio.EliminarTipoEntrada(id);
        }
     


        public List<tipoentrada> ObtenerTipoEntradas()
        {
            return _tipoentradaRepositorio.ObtenerTipoEntradas();
        }

        public TipoEntradaAbmDTO ObtenerTipoEntradasAbm()
        {
            return new TipoEntradaAbmDTO()
            {
                Eventos = _eventoRepositorio.ObtenerEventos(),
               

                TipoEntradas = _tipoentradaRepositorio.ObtenerTipoEntradas()
            };

        }
    }
}
