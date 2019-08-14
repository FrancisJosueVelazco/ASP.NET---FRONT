using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonaConsumo.ServiceReference1;

namespace PersonaConsumo.Controllers
{
    public class PersonaController : Controller
    {
        Service1Client cliente = new Service1Client();
        // GET: Persona
        public ActionResult Index()
            
        {
            List<E_Persona> lista = cliente.ListarPersona();
            return View(lista);
        }

        // GET: Persona/Details/5
        public ActionResult Details(int id)
        {
            E_Persona l= cliente.ListarxId(id);
            return View(l);
        }

        // GET: Persona/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Persona/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection,E_Persona request)
        {
            try
            {

                cliente.RegistrarPersona(request);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Persona/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View();
        }

        // POST: Persona/Edit/5
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

        // GET: Persona/Delete/5
        public ActionResult Delete(int id)
        {
            E_Persona l = cliente.ListarxId(id);
            return View(l);
        }

        // POST: Persona/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                cliente.EliminarPersona(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
