using School.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastrucure.EF
{
    public class SchoolContext:DbContext
    {
        public SchoolContext():base("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SchoolDemo;Data Source=.")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
