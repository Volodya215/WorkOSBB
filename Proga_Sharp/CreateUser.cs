using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proga_Sharp
{
    public enum TypeOfUsers
    {
        Jutel = 1,
        Pilga,
        Orendar
    };
    class CreateUser
    { 
        // Додає нового користувача
        public void Add_user()
        {
            int type;
            Console.WriteLine("Choose your type of user: ");
            type = Convert.ToInt32(Console.ReadLine());

            switch (type)
            {
                case (int)TypeOfUsers.Jutel:
                    Create_Inhabitant();
                    break;
                case (int)TypeOfUsers.Pilga:
                    Create_User_benefit();
                    break;
                case (int)TypeOfUsers.Orendar:
                    Create_Company();
                    break;
                default:
                    Console.WriteLine("Incorrect input type of user!");
                    break;
            }
        }

        // Створює користувача - звичайного мешканця квартири
        private void Create_Inhabitant()
        {
            string password, login, name;
            int size, count_inhab;
            int type = 1;

            Console.WriteLine("Enter your login: ");
            login = Console.ReadLine();
            password = CheckPassword();
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
        }

        private void Create_Company()
        {

        }

        private void Create_User_benefit()
        {

        }


        // Перевіряє чи пароль введено вірно
        private string CheckPassword()
        {
            string password, repassword;
            do
            {
                Console.WriteLine("Enter your password: ");
                password = Console.ReadLine();
                Console.WriteLine("Enter your password again: ");
                repassword = Console.ReadLine();

                if(password != repassword)
                    Console.WriteLine("Uncorrect enter. Try again!!!");

            } while (password != repassword);
            return password;
        }
    }
}
