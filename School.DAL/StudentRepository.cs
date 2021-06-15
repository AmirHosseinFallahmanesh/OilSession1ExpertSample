using School.Contract;
using School.Domain;
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
        IStudentPersist contex;
        public StudentRepository()
        {
            contex = new XMLFileConetxt();
        }
        public List<Student> GetStudents()
        {
            return contex.GetAllStudents(); 
        }

        public void AddStudent(string name,string surname,int age )
        {
            Student student = new Student()
            {
                Age = age,
                Name = name,
                SurName = surname
            };
            contex.AddStudent(student);
        }
    }
}
