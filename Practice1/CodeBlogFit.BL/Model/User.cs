using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFit.BL.Model
{
    [Serializable]
    public class User
    {
        #region Свойства
        /// <summary>
        /// Имя юзера
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; set; } 

        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Рост
        /// </summary>
        public double Height { get; set; }

        public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }
        #endregion

        /// <summary>
        /// Создание нового юзера
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="birthDate">Дата рождения</param>
        /// <param name="weight">Вес</param>
        /// <param name="height">Рост</param>
        /// <exception cref="ArgumentNullException"></exception>
        public User(string name, Gender gender, DateTime birthDate, double weight, double height)
        {
            #region Проверка условий
            if (string.IsNullOrEmpty(name)) 
            { 
                throw new ArgumentNullException("name"); 
            }
            if (gender == null) 
            { 
                throw new ArgumentNullException("gender"); 
            }
            if (birthDate == null || birthDate < DateTime.Parse("01.01.1900") || birthDate > DateTime.Now) 
            { 
                throw new ArgumentNullException("bithDate"); 
            }

            if (weight<=0)
            {
                throw new ArgumentNullException("weght");

            }

            if (height <= 0)
            {
                throw new ArgumentNullException("height");

            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public User(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            Name= name;
        }

        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
