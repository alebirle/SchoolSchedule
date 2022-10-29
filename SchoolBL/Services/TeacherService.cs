using SchoolBL.IServices;
using SchoolRepository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBL.Services
{
    public class TeacherService: ITeacherService
    {
        private ITeacherRepository teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            this.teacherRepository = teacherRepository;
        }
    }
}
