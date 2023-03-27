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
    internal class UserController
    {
        public UserController(User user) 
        {
            User = user ?? throw new ArgumentNullException("Пользователь не может быть равен NULL!", nameof(user));
        }

        public User User { get; }

        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }

        public User Load()
        {
            var formatter = new BinaryFormatter();
            
            using(var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if(formatter.Deserialize(fs) is User user)
                {
                    return user;
                }
                else
                {
                    throw new FileLoadException();
                }

            }
            
        }

    }
}
