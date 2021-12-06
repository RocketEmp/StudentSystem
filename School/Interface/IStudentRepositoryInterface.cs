using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Interface
{
    public interface IStudentRepositoryInterface
    {
        public List<Student> ListAll();
        public void Create(Student student);
        public Student Edit(Student student);
        public void Delete(Student student);
    }
}
