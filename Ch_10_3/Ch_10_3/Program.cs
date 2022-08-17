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
            var employee = new Student()
            {
                Name = "v1",
                Age = 22
            };
            //эквивалентно
            var employee2 = new Student();
            employee2.Name = "v2";
            employee2.Age = 22;


            //создание и сразу применение 
            var empName = new Student() { Name = "v3", Age = 23 }.ToString().ToUpper();

            //вариант с параметром
            var emp4 = new Student("v4") { Age = 33 };

            var class1 = new ClassRoom() 
            { 
                //проблема в том что при большом количестве данный много накладных расходов
                // на каждого студента вызывается метод ADD
                //лучше использовать AddRange
                Students = 
                { 
                    new Student("Ivan"), 
                    new Student("Vasya") 
                } 
            };

        }
    }
}
