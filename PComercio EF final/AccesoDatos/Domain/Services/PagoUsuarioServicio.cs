using System;
using System.Collections.Generic;
using System.Linq;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.Repositories;
using AccesoDatos.Infrastructure.Data.DataModels;
namespace AccesoDatos.Domain.Services
{
    public class PagoUsuarioServicio
    {
        private readonly PagoUsuarioRepositorio _pagousuarioRepositorio;
        private readonly TransaccionPreviaRepositorio _transaccionpreviaRepositorio;
   
        public PagoUsuarioServicio()
        {
            _pagousuarioRepositorio = new PagoUsuarioRepositorio();
            _transaccionpreviaRepositorio = new TransaccionPreviaRepositorio();
  
        }
        public int GuardarPagoUsuario(int id, int id_trans, DateTime fecha_pago, int monto, string factura, int valido)
        {
            if (id == 0)
                id = _pagousuarioRepositorio.GuardarPagoUsuario( id_trans, fecha_pago,  monto, factura, valido);
            else
                _pagousuarioRepositorio.ModificarPagoUsuario(id, id_trans, fecha_pago, monto, factura, valido);

            return id;
        }

        public void EliminarTransaccionPrevia(int id)
        {
            _pagousuarioRepositorio.EliminarPagoUsuario(id);
        }
        

        public List<pago_usuario> ObtenerPagoUsuarios()
        {
            return _pagousuarioRepositorio.ObtenerPagoUsuarios();
        }

        public PagoUsuarioAbmDTO ObtenerPagoUsuariosAbm()
        {
            return new PagoUsuarioAbmDTO()
            {
                PagoUsuarios = _pagousuarioRepositorio.ObtenerPagoUsuarios(),
                TransaccionPrevias = _transaccionpreviaRepositorio.ObtenerTransaccionPrevias(),

            };

        }
    }
}
