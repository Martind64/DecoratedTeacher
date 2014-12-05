using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratedTeach
{
    public class Teacher : ITeacher
    {
        public string Name { get; set; }
        public int Salary { get; set; }


        public Teacher(string name, int salary)
        {
            Name = name;
            Salary = salary;

        }

        public bool Equals(ITeacher other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Name, other.Name) && Salary == other.Salary;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            //if (obj.GetType() != this.GetType()) return false;
            if (!(obj is ITeacher)) return false;
            return Equals((ITeacher)obj);
        }

      

        public override string ToString()
        {
            string salary = Salary.ToString();


            return "Name: " + Name + "Salary: " + salary;
        }
    }
}
