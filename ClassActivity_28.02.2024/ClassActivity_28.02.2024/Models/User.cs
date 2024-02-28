
namespace ClassActivity_28._02._2024.Models
{
    internal class User
    {
        public string name;
        public string surname;
        public int age;
        private string password;
        public User(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string value)
        {
            this.password = value;
        }

    }
}
