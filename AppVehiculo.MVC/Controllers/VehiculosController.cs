using AppEmpresa.ConsumeAPI;
using AppVehiculos.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppVehiculo.MVC.Controllers
{
    public class VehiculosController : Controller
    {
        private string urlApi;

        public VehiculosController(IConfiguration configuration)
        {
            urlApi = configuration.GetValue("ApiUrlBase", "").ToString() + "/Vehiculos";
        }

        // GET: VehiculosController
        public ActionResult Index()
        {
            var data = Crud<Vehiculo>.Read(urlApi);
            return View(data);
        }

        // GET: VehiculosController/Details/5
        public ActionResult Details(int id)
        {
            var data = Crud<Vehiculo>.Read_ById(urlApi, id);
            return View(data);
        }

        // GET: VehiculosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehiculosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vehiculo data)
        {
            try
            {
                var newData = Crud<Vehiculo>.Create(urlApi, data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: VehiculosController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<Vehiculo>.Read_ById(urlApi, id);
            return View(data);
        }

        // POST: VehiculosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Vehiculo data)
        {
            try
            {
                Crud<Vehiculo>.Update(urlApi, id, data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: VehiculosController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Crud<Vehiculo>.Read_ById(urlApi, id);
            return View(data);
        }

        // POST: VehiculosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Vehiculo data)
        {
            try
            {
                Crud<Vehiculo>.Delete(urlApi, id);
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