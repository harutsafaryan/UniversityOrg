using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityOrg.Models
{
    public class Teacher
    {
        public Guid _id;
        public string _name;
        public int _age;
        public List<Student> _students;

        public Teacher()
        {
            _id = Guid.NewGuid();
        }

        public Teacher(string name, int age)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
            _students = new List<Student>();
        }


    }
}
