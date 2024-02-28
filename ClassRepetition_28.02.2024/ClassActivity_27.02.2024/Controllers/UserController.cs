
using ClassActivity_27._02._2024.Helpers.Constants;
using ClassActivity_27._02._2024.Services;

namespace ClassActivity_27._02._2024.Controllers
{
    internal class UserController
    {
        private readonly UserService userService;
        public UserController()
        {
            userService = new UserService();
        }

        public void GetAll()
        {
            var result = userService.GetAll();

            foreach(var item in result)
            {
                Console.WriteLine($"{item.fullName} - {item.age} - {item.email}");
            }
        }

        public void GetUserById()
        {
            UserId: Console.WriteLine("Enter user id:");
            string strId = Console.ReadLine();

            int id;

            bool isCorrectId = int.TryParse(strId, out id);

            if (isCorrectId)
            {
                var user = userService.GetUserById(userService.GetAll(), id);

                if (user == null)
                {
                    Console.WriteLine(ResponseMessages.NotFound);
                    return;
                }
                Console.WriteLine($"{user.fullName} - {user.age} - {user.email}");
            }
            else
            {
                Console.WriteLine(ResponseMessages.IncorrectNumberFormat);
                goto UserId;
            }
            
        }
    }

}
