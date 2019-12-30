using ReactCore.Data;
using ReactCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactCore.Repository
{
    public class StudentManager : IDataRepository<Student>
    {
        readonly ReactCoreAppContext _context;
        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }
    }
}
