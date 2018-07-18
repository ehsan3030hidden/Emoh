using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emoh.Models.Interfaces;

namespace Emoh.Models.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(EmohContext db) : base(db)
        {
        }
    }
}
