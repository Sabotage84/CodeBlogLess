using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_10_3
{
    class ClassRoom
    {

       private readonly List<Student> students = new List<Student>();
        public List<Student> Students => students;
    }
}
