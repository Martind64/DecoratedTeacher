using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratedTeach
{
    public class UnmodifiableTeacher : ITeacher
    {
        private readonly ITeacher _iTeacher;

        public string Name
        {
            get { return _iTeacher.Name; }
            set { throw new NotSupportedException("Name is unmodifiable");}
        }

        public int Salary
        {
            get { return _iTeacher.Salary; }
            set { throw new NotSupportedException("Salary is unmodifiable");}
        }




    }
}
