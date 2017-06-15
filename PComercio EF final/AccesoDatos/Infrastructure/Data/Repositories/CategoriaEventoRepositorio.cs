using System.Collections.Generic;
using System.Linq;
using AccesoDatos.Domain.Entities;
using AccesoDatos.Infrastructure.Data.DataModels;

namespace AccesoDatos.Infrastructure.Data.Repositories
{
    public class CategoriaEventoEventoRepositorio : EFRepositorio<categoria_evento>
    {
        public categoria_evento ObtenerCategoriaEvento(int id)
        {
            return Get(id);
        }

        public List<CategoriaEvento> ObtenerCategoriaEventos()
        {
            return GetAll().Select(x => new CategoriaEvento()
            {
                id = x.id,
                nombre = x.nombre,
                id_subcategoria = x.id_subcategoria
            }).ToList();
        }
    }
}
