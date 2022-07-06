using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLess
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDBContext())
            {
                var group = new Group()
                {
                    Name = "Король и Шут",
                    Year = 1988
                };
                context.Groups.Add(group);
                context.SaveChanges();

                Console.WriteLine($"Id: {group.Id}, Name: {group.Name}, Year: {group.Year}");
                Console.ReadLine();
            }
        }
    }
}
