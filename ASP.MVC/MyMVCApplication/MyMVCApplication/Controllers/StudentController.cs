using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApplication.Models;

namespace MyMVCApplication.Controllers
{
    public class StudentController : Controller
    {
        IList<Student> studentList = new List<Student>() {
                    new Student(){ StudentId=1, StudentName="John", Age = 18 },
                    new Student(){ StudentId=2, StudentName="Steve", Age = 21 },
                    new Student(){ StudentId=3, StudentName="Bill", Age = 25 },
                    new Student(){ StudentId=4, StudentName="Ram", Age = 20 },
                    new Student(){ StudentId=5, StudentName="Ron", Age = 31 },
                    new Student(){ StudentId=6, StudentName="Chris", Age = 17 },
                    new Student(){ StudentId=7, StudentName="Rob", Age = 19 }
                };

        // GET: Student
        public ActionResult Index()
        {
            //var studentList = new List<Student>{
            //                new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
            //                new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
            //                new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
            //                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
            //                new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
            //                new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
            //                new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
            //            };
            //// Get the students from the database in the real application

            return View(studentList);
        }

        public ActionResult Edit(int Id)
        {
            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application
            var std = studentList.Where(s => s.StudentId == Id).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            //write code to update student 

            return RedirectToAction("Index");
        }

        //[ActionName("find")]
        //public ActionResult GetById(int id)
        //{
        //    // get student from the database 
        //    return View();
        //}

        //[NonAction]
        //public Student GetStudent(int id)
        //{
        //    return Student.studentList.Where(s => s.StudentId == id).FirstOrDefault();
        //}

        //[HttpPost]
        //public ActionResult Edit(Student std)
        //{
        //    // update student to the database

        //    return RedirectToAction("Index");
        //}

        //[HttpDelete]
        //public ActionResult Delete(int id)
        //{
        //    // delete student from the database whose id matches with specified id

        //    return RedirectToAction("Index");
        //}

        //[HttpPost]
        //public ActionResult PostAction()
        //{
        //    return View("Index");
        //}


        //[HttpPut]
        //public ActionResult PutAction()
        //{
        //    return View("Index");
        //}

        //[HttpDelete]
        //public ActionResult DeleteAction()
        //{
        //    return View("Index");
        //}

        //[HttpHead]
        //public ActionResult HeadAction()
        //{
        //    return View("Index");
        //}

        //[HttpOptions]
        //public ActionResult OptionsAction()
        //{
        //    return View("Index");
        //}

        //[HttpPatch]
        //public ActionResult PatchAction()
        //{
        //    return View("Index");
        //}

        //[AcceptVerbs(HttpVerbs.Post | HttpVerbs.Get)]
        //public ActionResult GetAndPostAction()
        //{
        //    return RedirectToAction("Index");
        //}
    }
}