using SchoolRepository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRepository.Repositories
{
    public class TeacherRepository: ITeacherRepository
    {
        private SchoolContext context;
        public TeacherRepository(SchoolContext schoolContext)
        {
            context = schoolContext;
        }
    }
}
