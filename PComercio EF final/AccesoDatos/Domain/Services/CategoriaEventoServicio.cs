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
    public class CategoriaEventoServicio
    {
        private readonly CategoriaEventoRepositorio _catRepositorio;

        public CategoriaEventoServicio()
        {
            _catRepositorio = new CategoriaEventoRepositorio();
        }



        public List<CategoriaEvento> ObtenerCategoriaEventos()
        {
            return _catRepositorio.ObtenerCategoriaEventos();
        }
    }
}
