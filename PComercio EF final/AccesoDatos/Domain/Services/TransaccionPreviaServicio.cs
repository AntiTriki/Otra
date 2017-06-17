using System;
using System.Collections.Generic;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.Repositories;
using AccesoDatos.Infrastructure.Data.DataModels;

namespace AccesoDatos.Domain.Services
{
    public class TransaccionPreviaServicio
    {

        private readonly UsuarioeRepositorio _usuarioeRepositorio;

        private readonly TipoEntradaRepositorio _tipoentradaRepositorio;
        private readonly TransaccionPreviaRepositorio _transaccionpreviaRepositorio;
        public TransaccionPreviaServicio()
        {
            _usuarioeRepositorio = new UsuarioeRepositorio();
            _transaccionpreviaRepositorio = new TransaccionPreviaRepositorio();
            _tipoentradaRepositorio = new TipoEntradaRepositorio();


        }
        public int GuardarTransaccionPrevia(int id, int id_usuario, int cantidad, DateTime fecha, int id_tipoentrada, int valido)
        {
            if (id == 0)
                id = _transaccionpreviaRepositorio.GuardarTransaccionPrevia(id_usuario, cantidad, fecha, id_tipoentrada, valido);
            else
                _transaccionpreviaRepositorio.ModificarTransaccionPrevia(id, id_usuario, cantidad, fecha, id_tipoentrada, valido);

            return id;
        }

        public void EliminarUsuarioe(int id)
        {
            _transaccionpreviaRepositorio.EliminarTransaccionPrevia(id);
        }
        public void EliminarTipoEntrada(int id)
        {
            _transaccionpreviaRepositorio.EliminarTransaccionPrevia(id);
        }


        public List<transaccion_previa> ObtenerTransaccionPrevias()
        {
            return _transaccionpreviaRepositorio.ObtenerTransaccionPrevias();
        }

        public TransaccionPreviaAbmDTO ObtenerTransaccionPreviasAbm()
        {
            return new TransaccionPreviaAbmDTO()
            {
                Usuarioes = _usuarioeRepositorio.ObtenerUsuarioes(),
                TransaccionPrevias = _transaccionpreviaRepositorio.ObtenerTransaccionPrevias(),

                TipoEntradas = _tipoentradaRepositorio.ObtenerTipoEntradas()
            };

        }
    }
}
