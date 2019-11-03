using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Proga_Sharp
{
    public class User
    {
        public int type = 0;
        public string Login { get; private set; }
        private string password;
        private string name;
        private int ID, sum;
        private Services pokaznuku = new Services();

        public string Password { get { return password; } }
        // Конструкто за замовчуванням
        public User()
        {
            Login = "";
            password = "none";
            name = "no name";
            ID = Indent.GetID();  // забрати, щоб ід не проскакували, якщо буде потрібно
            sum = 0;
        }

        // Конструктор з параметрами
        public User(string login, string password, string name, int sum, int type)
        {
            this.Login = login;
            this.password = password;
            this.name = name;
            this.sum = sum;
            ID = Indent.GetID();
            this.type = type;
        }

        // Конструктор копіювання
        public User(User other)
        {
            this.Login = other.Login;
            this.password = other.password;
            this.name = other.name;
            this.sum = other.sum;
            this.ID = other.ID;
        }

        // Метод для виведення інформації про юзера 
        public virtual void Get_info()
        {
            Console.WriteLine("User: {0}\nID: {1}\nArrears: {2}", name, ID, sum);
        }

        // Метод для зміни пароля
        public void Change_password()
        {
            string new_parol, new_parol1;

            if (CheckPassword())
            {
                do
                {
                    Console.WriteLine("Enter your password: ");
                    new_parol = Console.ReadLine();
                    Console.WriteLine("Enter your password again: ");
                    new_parol1 = Console.ReadLine();

                    if (new_parol == new_parol1)
                    {
                        password = new_parol;
                        Console.WriteLine("Password was changed!");
                    }
                    else
                        Console.WriteLine("Uncorrect enter. Try again!!!");
                } while (new_parol != new_parol1);
            }
        }

        // Перевіряє пароль на достовірність
        private bool CheckPassword()
        {
            string oldParol;

            Console.WriteLine("Enter your old password: ");
            oldParol = Console.ReadLine();

            if (oldParol == password)
                return true;
            else
            {
                Console.WriteLine("Uncorrect enter old password. Access failed!!!");
                return false;
            }
        }

        public static void CreateFile(User temp)
        {
            using (var sw = new StreamWriter(temp.Login, true))
            {
                sw.WriteLine(temp.Login);
                sw.WriteLine(temp.password);
                sw.WriteLine(temp.ID);
                sw.WriteLine(temp.name);
                sw.WriteLine(temp.sum);
            }
        }


        public static void DownloadDataUser(string login, long position, User temp)
        {
            using (StreamReader sr = new StreamReader(login))
            {
                StreamReaderExtensions.SetPosition(sr, position);
                temp.Login = sr.ReadLine();
                temp.password = sr.ReadLine();
                temp.ID = Convert.ToInt32(sr.ReadLine());
                temp.name = sr.ReadLine();
                temp.sum = Convert.ToInt32(sr.ReadLine());
            }
        }

        public void FillServices()
        {
            Services temp = new Services();
            Console.WriteLine("Enter metrics:");
            Console.Write("Electricity = ");
            temp.Electricity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Warm = ");
            temp.Warm = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gas = ");
            temp.Gas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Water = ");
            temp.Water = Convert.ToDouble(Console.ReadLine());
            Console.Write("Home pay = ");
            temp.HomePay = Convert.ToDouble(Console.ReadLine());

            pokaznuku = pokaznuku + temp;
        }

        public virtual void DetermineTheAmount(double koef)
        {
            sum = Convert.ToInt32(koef * (pokaznuku.Electricity * 0.25 + pokaznuku.Warm * 25 + pokaznuku.Gas * 0.34 + (pokaznuku.Water * 13) + 200));
            Console.WriteLine("Bill: " + sum);
            Console.ReadLine();
        }

        public void Pay()
        {
            Console.WriteLine("Arrears = " + sum);
            Console.WriteLine("Successfully completed!");
            sum = 0;
            pokaznuku.Electricity = pokaznuku.Warm = pokaznuku.Gas = pokaznuku.Water = pokaznuku.HomePay = 0;
            Console.ReadLine();
        }
    }
}

namespace Proga_Sharp
{
    public static class Indent
    {
        private static int ID;

        public static int GetID()
        {
            using (var sr = new StreamReader(@"C:\Users\Hacker_Volodyka\source\repos\Proga_Sharp\Proga_Sharp\id.txt"))
            {
                ID = Convert.ToInt32(sr.ReadLine());
            }
            using (var sw = new StreamWriter(@"C:\Users\Hacker_Volodyka\source\repos\Proga_Sharp\Proga_Sharp\id.txt"))
            {
                sw.WriteLine(ID + 1);
            }

            return ID;
        }

    }
}

