using AppEmpresa.ConsumeAPI;
using AppVehiculos.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppVehiculo.MVC.Controllers
{
    public class MarcasController : Controller
    {
        private string urlApi;

        public MarcasController(IConfiguration configuration)
        {
            urlApi = configuration.GetValue("ApiUrlBase", "").ToString() + "/Marcas";
        }

        // GET: MarcasController
        public ActionResult Index()
        {
            var data = Crud<Marca>.Read(urlApi);
            return View(data);
        }

        // GET: MarcasController/Details/5
        public ActionResult Details(int id)
        {
            var data = Crud<Marca>.Read_ById(urlApi, id);
            return View(data);
        }

        // GET: MarcasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MarcasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Marca data)
        {
            try
            {
                var newData = Crud<Marca>.Create(urlApi, data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: MarcasController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<Marca>.Read_ById(urlApi, id);
            return View(data);
        }

        // POST: MarcasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Marca data)
        {
            try
            {
                Crud<Marca>.Update(urlApi, id, data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: MarcasController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Crud<Marca>.Read_ById(urlApi, id);
            return View(data);
        }

        // POST: MarcasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Marca data)
        {
            try
            {
                Crud<Marca>.Delete(urlApi, id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }
    }
}
