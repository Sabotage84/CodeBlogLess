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
        
        public List<User> Users { get; }

        public User CurrentUser { get; }

        public bool IsNewUser { get; } = false;
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
            Users = new List<User>();
            Users.Add(user);
       
        }

        public UserController(string userName)
        {
            if(string.IsNullOrEmpty(userName))
            {
                throw new ArgumentException("Имя не может быть пустым!", nameof(userName));
            }

            Users = GetUsersData();

            CurrentUser = Users.SingleOrDefault(u => u.Name == userName);

            if(CurrentUser == null)
            {
                CurrentUser= new User(userName);
               
                Users.Add(CurrentUser);
                IsNewUser = true;
                Save();
            }

            
        }

      
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
                

                if(fs.Length>0 && formatter.Deserialize(fs) is List<User> users)
                {
                    return  users;
                }
                else
                {
                    return new List<User>();
                }
                
            }
        }
            
        public void SetNewUserData(string genderName, DateTime birthDate, double weight=1, double height=1)
        {
            CurrentUser.Gender = new Gender(genderName);
            CurrentUser.BirthDate = birthDate;
            CurrentUser.Weight = weight;    
            CurrentUser.Height = height;
        }

        public void TestSow()
        {
            Console.WriteLine($"Имя: {CurrentUser.Name}, пол: {CurrentUser.Gender}, дата рождения: {CurrentUser.BirthDate.ToShortDateString()}");
            Console.WriteLine($"Рост: {CurrentUser.Height} вес: {CurrentUser.Weight} ");
        }

        public void TestShowAll()
        {
            foreach (var item in Users)
            {
                Console.WriteLine($"Имя: {item.Name}, пол: {item.Gender}, дата рождения: {item.BirthDate.ToShortDateString()}");
                Console.WriteLine($"Рост: {item.Height} вес: {item.Weight} ");
            }
          
        }
    }
}
