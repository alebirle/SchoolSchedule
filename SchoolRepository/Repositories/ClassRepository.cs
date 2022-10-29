using SchoolRepository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRepository.Repositories
{
    public class ClassRepository: IClassRepository
    {
        private SchoolContext context;
        public ClassRepository(SchoolContext schoolContext)
        {
            context = schoolContext;
        }
    }
}
