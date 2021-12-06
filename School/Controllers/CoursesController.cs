using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class CoursesController : Controller
    {
        // GET: CoursesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CoursesController/Details/5
        public ActionResult List()
        {
            return View();
        }

        // GET: CoursesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: CoursesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: CoursesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // PUT: CoursesController/Update/5
        public ActionResult Update(int id)
        {
            return View();
        }
    }
}
