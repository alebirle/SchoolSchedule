using SchoolModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRepository.IRepositories
{
    public interface IStudentRepository
    {
        void Save(Student student);
        IList<Student> GetStudents();
    }
}
