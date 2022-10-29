using SchoolBL.IServices;
using SchoolModel;
using SchoolRepository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBL.Services
{
    public class StudentService: IStudentService
    {
        private IStudentRepository studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public IList<Student> GetStudents()
        {
            return studentRepository.GetStudents();
        }

        public void Save(Student student)
        {
            studentRepository.Save(student);
        }
    }
}
