using CodeBlogFit.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFit.BL.Controller
{       
    /// <summary>
    ////Контроллер пользователя
    /// </summary>
    public class UserController
    {
        /// <summary>
        ////Создание контроллера пользователя
        /// </summary>
        /// <param name="user">Пользователь приложения. </param>
        /// <exception cref="ArgumentNullException"></exception>
        public UserController(string userName, string gender, DateTime birthDate, double weight, double height) 
        {
            //TODO: Проверку вх параметров
            var genderT = new Gender(gender);
            var user = new User(userName, genderT, birthDate, weight, height);


            User = user;
        }
, string gender, DateTime birthDate, double weight, double height
        public UserController(string userName)
        {
            if(string.IsNullOrEmpty(userName))
            {
                throw new ArgumentException("Имя не может быть пустым!", nameof(userName));
            }

            Users = GetUsersData();
            
            
            var genderT = new Gender(gender);
            var user = new User(userName, genderT, birthDate, weight, height);


            User = user;
        }

        public List<User> Users { get; }
        /// <summary>
        /// Сохранить данные пользователя
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Users);
            }
        }
        /// <summary>
        /// Получить список пользователя
        /// </summary>
        /// <returns>Пользователь приложения.</returns>
        /// <exception cref="FileLoadException"></exception>
        private List<User> GetUsersData()
        {
            var formatter = new BinaryFormatter();
            
            using(var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                

                if(formatter.Deserialize(fs) is List<User> users)
                {
                    return  users;
                }
                else
                {
                    return new List<User>();
                }
                
            }
        }
            
        public void TestSow()
        {
            Console.WriteLine($"Имя: {User.Name}, пол: {User.Gender}, дата рождения: {User.BirthDate.ToShortDateString()}");
            Console.WriteLine($"Рост: {User.Height} вес: {User.Weight} ");
        }

    }
}
