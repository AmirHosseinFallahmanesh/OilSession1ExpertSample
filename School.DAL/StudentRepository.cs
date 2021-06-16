using School.Contract;
using School.Domain;
using School.Infrastrucure.EF;
using School.Infrastrucure.File;
using School.Infrastrucure.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DAL
{
    public class StudentRepository
    {
        SchoolContext contex;
        public StudentRepository()
        {
            contex = new SchoolContext();
        }
        public List<Student> GetStudents()
        {
            return contex.Students.ToList();
        }

        public void AddStudent(string name,string surname,int age )
        {
            Student student = new Student()
            {
                Age = age,
                Name = name,
                SurName = surname
            };
            contex.Students.Add(student);
            contex.SaveChanges();

        }
    }
}
