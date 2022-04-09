using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string nameUser, string lastNameUser, string login, int loginLength, bool hasPet, int ageUser, string[] colorUser ) User;

            int countUser=0;

            do
            {
                Console.WriteLine("Введите имя");

                User.nameUser = Console.ReadLine();

                Console.WriteLine("Введите фамилию");

                User.lastNameUser = Console.ReadLine();

                Console.WriteLine("Введите логин");

                User.login = Console.ReadLine();

                User.loginLength = User.login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");

                string Pet = Console.ReadLine();

                if (Pet == "Да" || Pet == "да")
                {
                    User.hasPet = true;
                }
                else
                    User.hasPet = false;

                Console.WriteLine("Введите возраст пользователя");

                User.ageUser = int.Parse(Console.ReadLine());


                User.colorUser = new string[3];

                Console.WriteLine("Введите три любимых цвета пользователя");

                for (int i = 0; i < User.colorUser.Length; i++)
                {
                    User.colorUser[i] = Console.ReadLine();
                }
                ++countUser;
            }
            while (countUser<3);
        }
        
    }
}
