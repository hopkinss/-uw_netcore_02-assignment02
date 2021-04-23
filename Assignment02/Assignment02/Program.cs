using Assignment02.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment02
{
    // Shawn Hopkins. Assignment 02 
    class Program
    {
        static void Main(string[] args)
        {
            var users = GetUsers();

            var passIsHello = users.Where(x => x.Password == "hello");
            Console.WriteLine($"Password = \"hello\"\n-------------------\n{string.Join("\n",passIsHello.Select(x=>x.Name))}");

            users.RemoveAll(x=> x.Name.ToLower() == x.Password);
            users.Remove(users.FirstOrDefault(x => x.Password == "hello"));

            Console.WriteLine($"\nSubset users\n-------------------\n{string.Join("\n", users.Select(x => new {Name=x.Name,PassWord=x.Password} ))}");
        }

        static List<User> GetUsers()
        {
            var users = new List<User>();
            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });
            return users;
        }
    }
}
