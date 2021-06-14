using School.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Contract
{
    public interface IStudentPersist
    {

        List<Student> GetAllStudents();

        void AddStudent(Student student);


    }
}
