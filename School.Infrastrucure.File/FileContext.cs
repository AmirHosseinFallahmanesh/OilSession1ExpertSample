using School.Contract;
using School.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace School.Infrastrucure.File
{
    public class FileContext : IStudentPersist
    {

        private string path = "db.txt";
        public void AddStudent(Student student)
        {
            StreamWriter writer = new StreamWriter(path,true);
            string format = student.StudentId + "," + student.Name + "," + student.SurName + "," + student.Age;
            writer.WriteLine(format);
            writer.Flush();
            writer.Close();

        }

        public List<Student> GetAllStudents()
        {
            List<Student> result = new List<Student>();
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
               Student student=Student.CreateFromFile(reader.ReadLine());
               result.Add(student);
            }

            reader.Close();
            return result;
        }
    }
}
