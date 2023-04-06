﻿using CodeBlogFit.BL.Model;
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
            Console.WriteLine($"Имя: {CurrentUser.Name}, пол: {CurrentUser.Gender}, дата рождения: {CurrentUser.BirthDate.ToShortDateString()}");
            Console.WriteLine($"Рост: {CurrentUser.Height} вес: {CurrentUser.Weight} ");
        }

    }
}
