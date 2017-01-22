using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EvaluationController : Controller
    {
        public static List<ProjectEvaluation> ListOfProjectEvaluation = new List<ProjectEvaluation>
        {
            new ProjectEvaluation() {name="Evaluation 1", city = "Cluj-Napoca", country="Romania", rating= 10, id=1},
            new ProjectEvaluation() {name="Evaluation 2", city = "Baia Mare", country="Romania", rating= 5.4, id=2 },
            new ProjectEvaluation() {name="Evaluation 3", city = "<script> alert('xss'); </script>", country="Romania", rating= 8.4, id=3 }
        };

        // GET: Evaluation
        public ActionResult Index()
        {
            return View(ListOfProjectEvaluation);
        }

        // GET: Evaluation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evaluation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evaluation/Create
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

        // GET: Evaluation/Edit/5
        public ActionResult Edit(int id)
        {

            return View();
        }

        // POST: Evaluation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var evaluation = ListOfProjectEvaluation.Single(e => e.id == id);

            if (TryUpdateModel(evaluation))
            {
                return RedirectToAction("Index");
            }
            return View(evaluation);
            //try
            //{
            // TODO: Add update logic here

            // return RedirectToAction("Index");
            // }
            //catch
            //{
            // return View();
            //}
        }

        // GET: Evaluation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Evaluation/Delete/5
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
