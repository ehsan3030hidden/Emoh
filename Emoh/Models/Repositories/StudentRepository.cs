using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emoh.Models.Interfaces;
using Emoh.Data;

namespace Emoh.Models.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
