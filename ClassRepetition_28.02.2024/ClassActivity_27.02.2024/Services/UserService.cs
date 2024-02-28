
using ClassActivity_27._02._2024.Models;

namespace ClassActivity_27._02._2024.Services
{
    internal class UserService
    {
        public User[] GetAll()
        {
            return new User[]
            {
                new User
                {
                    id = 1,
                    fullName = "User1 Userov",
                    age = 26,
                    email = "user1@gmail.com",
                    password = "password1",
                },
                new User
                {
                id = 2,
                fullName = "User2 Userov",
                age = 36,
                email = "user2@gmail.com",
                password = "password2",
                },
                new User
                {
                id = 3,
                fullName = "User3 Userov",
                age = 21,
                email = "user3@gmail.com",
                password = "password3"
                },
            };
        }

        public User GetUserById(User[] users, int id)
        {
            return users.FirstOrDefault(m => m.id == id);  
        }


    }


}
