using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccesoDatos.Domain.Services;
using AccesoDatos.Infrastructure.Data.DataModels;
using PagedList;
using PagedList.Mvc;

namespace PlantillaComercio.Controllers
{
    public class EventoController : Controller
    {
        readonly EventoServicio _paisServicio = new EventoServicio();
        ejmEntities4 db = new ejmEntities4();
        // GET: Evento
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEventos(string term)
        {
            List<string> prodNames = db.evento_empresa.Where(x => x.nombre.StartsWith(term)).Select(y => y.nombre).ToList();
            return Json(prodNames, JsonRequestBehavior.AllowGet);

        }
        public ActionResult GetEventosByCategory(string categorynombre, int? page)
        {
            ViewBag.Categories = db.categoria_evento.Select(x => x.nombre).ToList();
            

            

            var prods = db.evento_empresa.Where(x => x.categoria_evento.nombre == categorynombre).ToList();
            return View("Products", prods.ToPagedList(page ?? 1, 9));
        }
    }
}