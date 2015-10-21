using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class CheckinController : Controller
    {
        // GET: Checkin
        public ActionResult Index(string company)
        {
            switch(company.ToLower())
            {
                case "moldpro":
                    ViewBag.Title = "moldPro";
                    break;
                case "oths":
                    ViewBag.Title = "Oak Tree Home Services";
                    break;
                case "otr":
                    ViewBag.Title = "Oak Tree Residential";
                    break;
                default:
                    return RedirectToAction("Index", "Home");
            }

            return View();
        }

        // GET: Checkin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Checkin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Checkin/Create
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

        // GET: Checkin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Checkin/Edit/5
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

        // GET: Checkin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Checkin/Delete/5
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
