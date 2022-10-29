using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRepository
{
    public class SchoolContext: DbContext
    {
        public SchoolContext()
           : base()
        {
        }
        public SchoolContext(DbContextOptions<SchoolContext> options)
           : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Class> Classes { get; set; }
    }
}
