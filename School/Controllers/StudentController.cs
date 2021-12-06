using Microsoft.AspNetCore.Mvc;
using School.Interface;
using School.Models;
using School.Repository;
using System;

namespace School.Controllers
{
    public class StudentController : Controller
    {
        
         private  readonly IStudentRepositoryInterface StudentRepository;


         public StudentController(IStudentRepositoryInterface StudentRepository)
         {
             this.StudentRepository = StudentRepository ?? throw new ArgumentNullException(nameof(StudentRepository));
         }
        

        // GET: StudentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StudentController/Details/5
        public ActionResult List()
        {
            StudentRepository.ListAll();
            return View();
        }

        [HttpPost]
        public void Create(Student student)
        {
            StudentRepository.Create(student);
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // PUT: StudentController/Update/5
        public ActionResult Update(int id)
        {
            return View();
        }
    }
}
