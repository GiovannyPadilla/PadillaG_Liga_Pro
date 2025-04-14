
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using PadillaG_Liga_Pro.Models;
//using PadillaG_Liga_Pro.Repositories;

//namespace PadillaG_Liga_Pro.Controllers
//{
//    public class EquipoController : Controller
//    {
//        private readonly EquipoRepository _repository;

//        public EquipoController()
//        {
//            _repository = new EquipoRepository();
//        }

//        public ActionResult View()
//        {
//            return View();
//        }

//        public ActionResult List()
//        {
//            var equipos = _repository.DevuelveListadoEquipos();
//            var ordenar = equipos.OrderByDescending(item => item.Puntos)
//                                .ThenByDescending(item => item.partidosGanados);
//            return View(ordenar);
//        }

//        public ActionResult Create()
//        {
//            return View();
//        }

//        // Vista de detalle del equipo
//        public ActionResult Detail(int Id)
//        {
//            var equipo = _repository.DevuelveEquipoPorID(Id);
//            return View(equipo);
//        }

//        public ActionResult Edit(int Id)
//        {
//            var equipo = _repository.DevuelveEquipoPorID(Id);
//            return View(equipo);
//        }

//        [HttpPost]
//        public ActionResult Edit(int Id, Equipo equipo)
//        {
//            try
//            {
//                //Proceso de guardado
//                _repository.ActualizarEquipo(Id, equipo);
//                return RedirectToAction(nameof(List));
//            }
//            catch
//            {
//                ModelState.AddModelError("", "Error al guardar los datos");
//                return View(equipo);
//            }
//        }

//        [HttpPost]
//        public ActionResult UpdateStats(int Id, Equipo equipo)
//        {
//            try
//            {
//                var equipoExistente = _repository.DevuelveEquipoPorID(Id);

//                // Actualizar solo los campos de estadísticas
//                equipoExistente.partidosJugados = equipo.partidosJugados;
//                equipoExistente.partidosGanados = equipo.partidosGanados;
//                equipoExistente.partidosEmpatados = equipo.partidosEmpatados;
//                equipoExistente.partidosPerdidos = equipo.partidosPerdidos;

//                _repository.ActualizarEquipo(Id, equipoExistente);

//                return RedirectToAction(nameof(List));
//            }
//            catch
//            {
//                ModelState.AddModelError("", "Error al guardar los datos");
//                return RedirectToAction(nameof(Detail), new { Id });
//            }
//        }
//        public ActionResult Delete(int id)
//        {
//            var equipo = _repository.DevuelveEquipoPorID(id);
//            if (equipo == null)
//            {
//                return NotFound();
//            }
//            return View(equipo);
//        }

//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            try
//            {
//                // Implementa la eliminación si es necesario
//                return RedirectToAction(nameof(List));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}


using Microsoft.AspNetCore.Mvc;
using PadillaG_Liga_Pro.Models;
using PadillaG_Liga_Pro.Repositories;

namespace PadillaG_Liga_Pro.Controllers
{
    public class EquipoController : Controller
    {
        private readonly EquipoRepository _repository;

        public EquipoController()
        {
            _repository = new EquipoRepository();
        }

        public ActionResult View()
        {
            return View();
        }

        public ActionResult List()
        {
            var equipos = _repository.DevuelveListadoEquipos();
            var ordenar = equipos.OrderByDescending(item => item.Puntos)
                                 .ThenByDescending(item => item.partidosGanados);
            return View(ordenar);
        }

        public ActionResult Create()
        {
            return View();
        }

        // Vista de detalle del equipo
        public ActionResult Detail(int Id)
        {
            var equipo = _repository.DevuelveEquipoPorID(Id);
            if (equipo == null)
            {
                return NotFound();
            }
            return View(equipo);
        }

        public ActionResult Edit(int Id)
        {
            var equipo = _repository.DevuelveEquipoPorID(Id);
            return View(equipo);
        }

        [HttpPost]
        public ActionResult Edit(int Id, Equipo equipo)
        {
            try
            {
                _repository.ActualizarEquipo(Id, equipo);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                ModelState.AddModelError("", "Error al guardar los datos");
                return View(equipo);
            }
        }

        [HttpPost]
        public ActionResult UpdateStats(int Id, Equipo equipo)
        {
            try
            {
                var equipoExistente = _repository.DevuelveEquipoPorID(Id);

                equipoExistente.partidosJugados = equipo.partidosJugados;
                equipoExistente.partidosGanados = equipo.partidosGanados;
                equipoExistente.partidosEmpatados = equipo.partidosEmpatados;
                equipoExistente.partidosPerdidos = equipo.partidosPerdidos;

                _repository.ActualizarEquipo(Id, equipoExistente);

                return RedirectToAction(nameof(List));
            }
            catch
            {
                ModelState.AddModelError("", "Error al guardar los datos");
                return RedirectToAction(nameof(Detail), new { Id });
            }
        }

        public ActionResult Delete(int id)
        {
            var equipo = _repository.DevuelveEquipoPorID(id);
            if (equipo == null)
            {
                return NotFound();
            }
            return View(equipo);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                _repository.EliminarEquipo(id); // Método que eliminara el equipo
                return RedirectToAction(nameof(List));
            }
            catch
            {
                ModelState.AddModelError("", "Error al eliminar el equipo");
                var equipo = _repository.DevuelveEquipoPorID(id);
                return View("Delete", equipo);
            }
        }
    }
}

