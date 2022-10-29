using SchoolRepository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRepository.Repositories
{
    public class SubjectRepository: ISubjectRepository
    {
        private SchoolContext context;
        public SubjectRepository(SchoolContext schoolContext)
        {
            context = schoolContext;
        }
    }
}
