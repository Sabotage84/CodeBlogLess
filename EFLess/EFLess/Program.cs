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
                context.Groups.RemoveRange(context.Groups);
                context.Songs.RemoveRange(context.Songs);
                context.SaveChanges();

                var group = new Group()
                {
                    
                    Name = "Король и Шут",
                    Year = 1988
                    
                };
                context.Groups.Add(group);

                var group2 = new Group()
                {
                    Name = "Наутилус",
                    Year = 1982
                };
                context.Groups.Add(group2);
                context.SaveChanges();


                var s = context.Groups.Single(x => x.Id == group2.Id);
                s.Year = 1983;
                context.SaveChanges();

                var songs = new List<Song>()
                {
                    new Song{Name="Камнем по голове", GroupId=group.Id },
                    new Song{Name="Крылья",GroupId=group2.Id},
                    new Song{ Name="Три царя",GroupId=group2.Id }
                };

                context.Songs.AddRange(songs);
                context.SaveChanges();

                foreach (var item in songs)
                {
                    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Group: {item.Group.Name}, Group Year: {item.Group.Year} ");
                }
                Console.ReadLine();
            }
        }
    }
}
