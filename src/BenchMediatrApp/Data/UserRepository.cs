using System;
using BenchMediatrApp.Users;
using BenchMediatrApp.Users.Repositories;

namespace BenchMediatrApp.Data
{
    public class UserRepository : IUserRepository
    {
        public void CreateUser(User user)
        {
            Console.WriteLine("User created to database");
            return;
        }

        public void UpdateUser(User user)
        {
            Console.WriteLine("User updated to database");
            return;
        }
    }
}