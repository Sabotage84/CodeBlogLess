using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee()
            {
                Name = "v1",
                Age = 22
            };
            //эквивалентно
            var employee2 = new Employee();
            employee2.Name = "v2";
            employee2.Age = 22;


            //создание и сразу применение 
            var empName = new Employee() { Name = "v3", Age = 23 }.ToString().ToUpper();

            //вариант с параметром
            var emp4 = new Employee("v4") { Age = 33 };

        }
    }
}
