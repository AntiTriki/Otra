using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Domain.Entities
{
    public class Usuarioe
    {
        public int id;
        public string nombre;
        public string apellidop;
        public string apellidom;
        public string correo;
        public string contra;
        public int? valido;
        public int? telefono;
        public string direccion;
        public string imagen;
        public string sexo;
        public Nullable<System.DateTime> fecha_nac;
        public string ocupacion;
        public string estado_civil;
        public Nullable<System.DateTime> fecha_registro;
        public int? nit;
        public string nombre_nit;
        public string correo_nit;
        public int? id_metodo_pago;
    }
}
