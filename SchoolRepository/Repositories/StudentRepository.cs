using SchoolModel;
using SchoolRepository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRepository.Repositories
{
    public class StudentRepository: IStudentRepository
    {
        private SchoolContext context;
        public StudentRepository(SchoolContext schoolContext)
        {
            context = schoolContext;
        }

        public IList<Student> GetStudents()
        {
            return context.Students.ToList();
        }

        public void Save(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }
    }
}
