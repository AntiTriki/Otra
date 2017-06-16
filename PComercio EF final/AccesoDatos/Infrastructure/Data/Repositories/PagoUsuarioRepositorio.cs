using System;
using System.Collections.Generic;
using System.Linq;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.DataModels;

namespace AccesoDatos.Infrastructure.Data.Repositories
{
    public class PagoUsuarioRepositorio : EFRepositorio<pago_usuario>
    {
        public int GuardarPagoUsuario(int id_trans, DateTime fecha_pago, int monto, string factura, int valido)
        {
            pago_usuario usr = new pago_usuario()
            {
                id_trans = id_trans,
                monto = monto,
                factura = factura,
                fecha_pago = fecha_pago,
                valido = valido
            };
            Add(usr);
            SaveChanges();
            return usr.id;
        }
        public void ModificarPagoUsuario(int id, int id_trans, DateTime fecha_pago, int monto, string factura, int valido)
        {
            pago_usuario usr = this.Get(id);
            usr.id_trans = id_trans;
            usr.monto = monto;
            usr.factura = factura;
            usr.valido = valido;
           
            Update(usr);
            SaveChanges();
        }

        public void EliminarPagoUsuario(int id)
        {
            pago_usuario usr = this.Get(id);
            Remove(usr);
            SaveChanges();
        }

        public pago_usuario ObtenerPagoUsuario(int id)
        {
            return Get(id);
        }

        public List<pago_usuario> ObtenerPagoUsuarios()
        {
            return GetAll();
        }
    }
}
