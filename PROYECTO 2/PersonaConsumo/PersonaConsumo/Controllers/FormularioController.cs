using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonaConsumo.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario
        public ActionResult Index()
        {
            return View();
        }

        // GET: Formulario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Formulario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Formulario/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Formulario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Formulario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Formulario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Formulario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

  

    }
}
