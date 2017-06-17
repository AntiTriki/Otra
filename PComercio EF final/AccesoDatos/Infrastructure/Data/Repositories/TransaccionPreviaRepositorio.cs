using System.Collections.Generic;
using System.Linq;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.DataModels;
using System;

namespace AccesoDatos.Infrastructure.Data.Repositories
{
    public class TransaccionPreviaRepositorio : EFRepositorio<transaccion_previa>
    {
        public int GuardarTransaccionPrevia(int id_usuario, int cantidad, DateTime fecha, int id_tipoentrada, int valido)
        {
            transaccion_previa usr = new transaccion_previa()
            {
                id_usuario = id_usuario,
                cantidad = cantidad,
                fecha = fecha,
                id_tipoentrada = id_tipoentrada,
               
                valido = valido
            };
            Add(usr);
            SaveChanges();
            return usr.id;
        }
        public void ModificarTransaccionPrevia(int id, int id_usuario, int cantidad, DateTime fecha, int id_tipoentrada, int valido)
        {
            transaccion_previa usr = this.Get(id);
            usr.id_usuario = id_usuario;
            usr.fecha = fecha;
            usr.cantidad = cantidad;
            usr.id_tipoentrada = id_tipoentrada;
           
            usr.valido = valido;
            Update(usr);
            SaveChanges();
        }

        public void EliminarTransaccionPrevia(int id)
        {
            transaccion_previa usr = this.Get(id);
            Remove(usr);
            SaveChanges();
        }

        public transaccion_previa ObtenerTransaccionPrevia(int idTransaccionPrevia)
        {
            return Get(idTransaccionPrevia);
        }

        public List<transaccion_previa> ObtenerTransaccionPrevias()
        {
            return GetAll();
        }
    }
}
