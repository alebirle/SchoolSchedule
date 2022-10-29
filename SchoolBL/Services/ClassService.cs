using SchoolBL.IServices;
using SchoolRepository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBL.Services
{
    public class ClassService: IClassService
    {
        private IClassRepository classRepository;
        public ClassService(IClassRepository classRepository)
        {
            this.classRepository = classRepository;
        }
    }
}
