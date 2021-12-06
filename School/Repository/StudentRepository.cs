using School.Interface;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Repository
{
    public class StudentRepository : IStudentRepositoryInterface
    {
        public List<Student> studentsList = new List<Student>();

        public List<Student> ListAll()
        {
            return studentsList;
        }

        public void Create(Student student)
        {
            studentsList.Add(student);
        }

        public Student Edit(Student student)
        {
            bool ifexists = studentsList.Exists(x => x.Id == student.Id);  
            if(ifexists == true)
            {
                studentsList.RemoveAll(x => x.Id == student.Id);
                studentsList.Add(student);
            }
            else
            {
                Create(student);
            }

            return student;
        }

        public void Delete(Student student)
        {
            studentsList.RemoveAll(x => x.Id == student.Id);
        }
    }
}
