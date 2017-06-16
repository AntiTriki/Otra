using System;
using System.Collections.Generic;
using System.Linq;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.DataModels;

namespace AccesoDatos.Infrastructure.Data.Repositories
{
    public class UsuarioeRepositorio : EFRepositorio<usuarioe>
    {
        public int GuardarUsuario(string nombre, string correo, string contra, DateTime fecha_nac, string sexo, string apellidop, string apellidom, string direccion, string imagen, DateTime fecha_registro, string nombre_nit, string correo_nit, int valido , int telefono, int nit,string estado_civil, string ocupacion)        {
            usuarioe usr = new usuarioe()
            {

                nombre = nombre,
                correo = correo,
                apellidop = apellidop,
                apellidom = apellidom,
                contra = contra,
                valido = valido,
                telefono = telefono,
                direccion = direccion,
                imagen = imagen,
                ocupacion = ocupacion,
                estado_civil = estado_civil,
                fecha_nac = fecha_nac,
                fecha_registro = fecha_registro,
                sexo = sexo,
                nit = nit,
                nombre_nit = nombre_nit,
                correo_nit = correo_nit
                
            };
            Add(usr);
            SaveChanges();
            return usr.id;
        }
        public void ModificarUsuario(int id, string nombre, string correo, string contra, DateTime fecha_nac, string sexo, string apellidop, string apellidom, string direccion, string imagen, DateTime fecha_registro, string nombre_nit, string correo_nit, int valido, int telefono, int nit, string estado_civil, string ocupacion)
        {
            usuarioe usr = this.Get(id);
            
            usr.nombre = nombre;
            usr.apellidop = apellidop;
            usr.apellidom = apellidom;
            usr.correo = correo;
            usr.contra = contra;
            usr.valido = valido;
            usr.telefono = telefono;

            usr.direccion = direccion;
            usr.imagen = imagen;
            usr.sexo = sexo;
            usr.fecha_nac = fecha_nac;
            usr.ocupacion = ocupacion;
            usr.estado_civil = estado_civil;
            usr.fecha_registro = fecha_registro;
            usr.nit = nit;
            usr.nombre_nit = nombre_nit;
            usr.correo_nit = correo_nit;
            Update(usr);
            SaveChanges();
        }

        public void EliminarUsuario(int id)
        {
            usuarioe usr = this.Get(id);
            Remove(usr);
            SaveChanges();
        }

        public usuarioe ObtenerUsuario(int id)
        {
            return Get(id);
        }

        public List<usuarioe> ObtenerUsuarios()
        {
            return GetAll();
        }
    }
}
