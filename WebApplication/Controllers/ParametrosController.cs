using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class ParametrosController : Controller
    {
        // GET: Parametros
        public ActionResult Index()
        {
            return View();
        }

        // GET: Parametros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Parametros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parametros/Create
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

        // GET: Parametros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Parametros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
               //metodo para redireccionar a la opcion edit
               return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Parametros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Parametros/Delete/5
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
