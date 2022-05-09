using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptography
{
    public static class CommonUsers
    {
        public static List<User> Get() 
        {
            var users = new List<User>();
            var user1 = new User()
            {
                Username = "User1",
                Password = "123456"
            };
            users.Add(user1);

            var user2 = new User()
            {
                Username = "User2",
                Password = "password"
            };
            users.Add(user2);

            var user4 = new User()
            {
                Username = "User4",
                Password = "111111"
            };
            users.Add(user4);

            var user5 = new User()
            {
                Username = "User5",
                Password = "12345678"
            };
            users.Add(user5);

            var user6 = new User()
            {
                Username = "User6",
                Password = "qwerty"
            };
            users.Add(user6);

            var user7 = new User()
            {
                Username = "User7",
                Password = "abc123"
            };
            users.Add(user7);
            return users;
        }
    }
}
