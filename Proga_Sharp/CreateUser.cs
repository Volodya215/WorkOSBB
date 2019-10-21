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
            Console.WriteLine("Enter size of your flat: "); 
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter count inhab: ");
            count_inhab = Convert.ToInt32(Console.ReadLine());

            Inhabitant temp = new Inhabitant(login, password, name, 0, size, count_inhab);

            using (var sw = new StreamWriter(temp.Login, true))
            {
                sw.WriteLine(type);
                sw.WriteLine(size);
                sw.WriteLine(count_inhab);
            }
            User.CreateFile(temp);

            temp.Get_info();
        }

        // Створює користувача - пільговика
        private void Create_User_benefit()
        {
            string password, login, name, reason;
            double discount;
            int type = 2;

            Console.WriteLine("Enter your login: ");
            login = Console.ReadLine();
            password = CheckPassword();
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter reason your benefit: ");
            reason = Console.ReadLine();
            Console.WriteLine("Enter count of the discount: ");
            discount = Convert.ToDouble(Console.ReadLine());

            UserBenefit temp = new UserBenefit(login, password, name, 0, discount, reason);

            using (var sw = new StreamWriter(temp.Login, true))
            {
                sw.WriteLine(type);
                sw.WriteLine(reason);
                sw.WriteLine(discount);
            }
            User.CreateFile(temp);

            temp.Get_info();
        }

        // Створюємо користувача - орендара
        private void Create_Company()
        {
            string password, login, name, typeCompany;
            int countOfEmploye;
            int type = 3;

            Console.WriteLine("Enter your login: ");
            login = Console.ReadLine();
            password = CheckPassword();
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter type of your company: ");
            typeCompany = Console.ReadLine();
            Console.WriteLine("Enter count of employe: ");
            countOfEmploye = Convert.ToInt32(Console.ReadLine());

            Company temp = new Company(login, password, name, 0, typeCompany, countOfEmploye);

            using (var sw = new StreamWriter(temp.Login, true))
            {
                sw.WriteLine(type);
                sw.WriteLine(typeCompany);
                sw.WriteLine(countOfEmploye);
            }
            User.CreateFile(temp);

            temp.Get_info();
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
