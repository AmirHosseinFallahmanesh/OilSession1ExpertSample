using School.Contract;
using School.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace School.Infrastrucure.XML
{
    public class XMLFileConetxt : IStudentPersist
    {//DRY do not repeat your self
        public void AddStudent(Student student)
        {

            List<Student> data = GetAllStudents();
            FileStream fs = new FileStream("students.xml", FileMode.OpenOrCreate);
            XmlSerializer xs = new XmlSerializer(typeof(List<Student>));
            data.Add(student);
            xs.Serialize(fs, data);
            fs.Close();
        }

        public List<Student> GetAllStudents()
        {
            List<Student> data = new List<Student>();
           
            try
            {
                using (FileStream fs = new FileStream("students.xml", FileMode.Open))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Student>));
                    data = xs.Deserialize(fs) as List<Student>;
                }
      
               
            }
            catch (Exception ex)
            {

              
            }

            return data;
            
        }
    }
}
