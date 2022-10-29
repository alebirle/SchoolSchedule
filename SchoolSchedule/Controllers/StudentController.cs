using Microsoft.AspNetCore.Mvc;
using SchoolBL.IServices;
using SchoolModel;
using SchoolSchedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSchedule.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService studentService;
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        public IActionResult Index()
        {
            var studentList = new List<StudentViewModel>();
            var students = studentService.GetStudents();

            foreach(var student in students)
            {
                studentList.Add(new StudentViewModel()
                {
                    FirstName = student.FirstName,
                    LastName = student.LastName
                });
            }

            return View(studentList);
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(StudentViewModel studentViewModel)
        {
            var student = new Student()
            {
                FirstName = studentViewModel.FirstName,
                LastName = studentViewModel.LastName
            };

            studentService.Save(student);

            return View("Index");
        }
    }
}
