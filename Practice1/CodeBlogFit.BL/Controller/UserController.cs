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
    internal class UserController
    {
        /// <summary>
        ////Создание контроллера пользователя
        /// </summary>
        /// <param name="user">Пользователь приложения. </param>
        /// <exception cref="ArgumentNullException"></exception>
        public UserController(User user) 
        {
            User = user ?? throw new ArgumentNullException("Пользователь не может быть равен NULL!", nameof(user));
        }

        public User User { get; }
        /// <summary>
        /// Сохранить данные пользователя
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
        /// <summary>
        /// Загрузить данные пользователя
        /// </summary>
        /// <returns>Пользователь приложения.</returns>
        /// <exception cref="FileLoadException"></exception>
        public User Load()
        {
            var formatter = new BinaryFormatter();
            
            using(var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
             return formatter.Deserialize(fs) as User;
            }


        }
            
        

    }
}
