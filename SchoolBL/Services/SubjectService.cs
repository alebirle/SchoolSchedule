using SchoolBL.IServices;
using SchoolRepository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBL.Services
{
    public class SubjectService: ISubjectService
    {
        private ISubjectRepository subjectRepository;
        public SubjectService(ISubjectRepository subjectRepository)
        {
            this.subjectRepository = subjectRepository;
        }
    }
}
