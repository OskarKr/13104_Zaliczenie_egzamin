using _13104_Zaliczenie.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13104_Zaliczenie.Controllers
{
    public class TrasaController : Controller
    {
        private static IList<Trasa> trasa = new List<Trasa>()
        {
            new Trasa(){ NazwaTrasy = "Droga", DlugoscTrasy = 200, LiczbaSpalonychLitrow = 180, CenaZaLitr = 6}
        };

        // GET: TrasaController
        public ActionResult Index()
        {
            return View(trasa);
        }

        // GET: TrasaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TrasaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrasaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: TrasaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TrasaController/Edit/5
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

        // GET: TrasaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TrasaController/Delete/5
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
