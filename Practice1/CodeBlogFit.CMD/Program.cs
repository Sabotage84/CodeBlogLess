﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBlogFit.BL.Controller;

namespace CodeBlogFit.CMD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа Fitness!");
            Console.WriteLine("Введите имя:");

            var name = Console.ReadLine();

            var userController = new UserController(name);

            if (userController.IsNewUser)
            {
                Console.WriteLine("Введите пол:");
                var gender = Console.ReadLine();

                DateTime bithDate;
                double weight=ParseDouble("вес");
                double height=ParseDouble("рост");

                while (true)
                {
                    Console.Write("Введите дату рождения(dd.MM.yyyy): ");
                    if (DateTime.TryParse(Console.ReadLine(), out bithDate))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Не верный формат даты рождения!");
                    }
                }


                userController.SetNewUserData(gender, bithDate, weight, height);
                userController.Save();
            }



            //Console.WriteLine("Введите дату рождения:");
            //var birthDate = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine("Введите вес:");
            //var weight = double.Parse(Console.ReadLine());

            //Console.WriteLine("Введите рост:");
            //var height = double.Parse(Console.ReadLine());

            //var userController = new UserController(name, gender, birthDate, weight, height);
            //userController.Save();

            UserController testUserController = new UserController("Иван");

            testUserController.TestShowAll();
            Console.ReadLine();
        }

        private static double ParseDouble(string name)
        {
            while (true)
            {


                Console.Write($"Введите {name}: ");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"Не верный формат {name}!");
                }
            }
        }
    }
}
