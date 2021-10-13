using co.Saludtotal.Aplication;
using co.Saludtotal.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace co.Saludtotal.UI.Mvc.Controllers
{
    public class RequerimientoController : Controller
    {
        RequerimientosFac requerimientosFac = new RequerimientosFac();
        // GET: RequerimientoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RequerimientoController/Details/5
        public ActionResult Details(int id)
        {
            return View(requerimientosFac.GetAll());
        }

        // GET: RequerimientoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RequerimientoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Requerimiento requer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Requerimiento req = new Requerimiento();

                    if (requerimientosFac.Create(requer))
                    {
                        ViewBag.Message = "Requerimiento se Adicionó";
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: RequerimientoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RequerimientoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RequerimientoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RequerimientoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
