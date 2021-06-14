using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain
{
    public class Student
    {
        //1234156-231451-153,amir,amiri,12
        public static Student CreateFromFile(string stringFormat)
        {
            List<string> data = stringFormat.Split(',').ToList();
            Student student = new Student()
            {
                StudentId =Guid.Parse(data[0]),
                Name = data[1],
                SurName = data[2],
                Age = int.Parse(data[3])
            };
            return student;


        }
        public Student()
        {
            StudentId = Guid.NewGuid();
        }
        public Guid StudentId { get;private  set; }

        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }


    }
}
