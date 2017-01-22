using MVCcourse8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCcourse8.Controllers
{
    public class EvaluationController : Controller
    {
        ProjectEvaluation list = new ProjectEvaluation();
        public static List<ProjectEvaluation> listOfProjects = new List<ProjectEvaluation>
        {
            new ProjectEvaluation() {name = "project1", city = "Cluj", country = "Romania", rating= 4.1},
            new ProjectEvaluation() {name = "project2", city = "Cluuj", country = "Romaniaa", rating= 1.7},
            new ProjectEvaluation() {name = "project3", city = "<script>alert('xss');</script>", country = "Romaniaaa", rating= 2.6}
        };



        // GET: Evaluation
        public ActionResult Index()
        {
            return View(listOfProjects);
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
