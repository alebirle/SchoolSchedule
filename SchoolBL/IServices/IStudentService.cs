using SchoolModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBL.IServices
{
    public interface IStudentService
    {
        void Save(Student student);
        IList<Student> GetStudents();
    }
}
