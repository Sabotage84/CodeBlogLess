using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFit.BL.Model
{
    internal class User
    {
        public string Name { get; }

        public Gender Gender { get; }

        public DateTime BirthDate { get; } 

        public double Weight { get; set; }

        public double Height { get; set; }

        public User(string name, Gender gender, DateTime birthDate, double weight, double height)
        {
            if (string.IsNullOrEmpty(name)) 
            { 
                throw new ArgumentNullException("name"); 
            }
            if (gender == null) 
            { 
                throw new ArgumentNullException("gender"); 
            }
            if (birthDate == null || birthDate < DateTime.Parse("01.01.1900")) 
            { 
                throw new ArgumentNullException("bithDate"); 
            }

            if (weight<=0)
            {
                throw new ArgumentNullException("weght");
            }
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }
    }
}
