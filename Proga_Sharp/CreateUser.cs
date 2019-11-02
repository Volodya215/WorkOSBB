using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Proga_Sharp
{
    public enum TypeOfUsers
    {
        Jutel = 1,
        Pilga,
        Orendar
    };
    static class CreateUser
    { 
        // Додає нового користувача
        public static void Add_user()
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
        private static void Create_Inhabitant()
        {
            string password, login, name;
            int size, count_inhab;
            int type = 1;

            login = CheckLogin();
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
        private static void Create_User_benefit()
        {
            string password, login, name, reason;
            double discount;
            int type = 2;

            login = CheckLogin();
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
        private static void Create_Company()
        {
            string password, login, name, typeCompany;
            int countOfEmploye;
            int type = 3;

            login = CheckLogin();
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
        private static string CheckPassword()
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

        private static string CheckLogin()
        {
            string login = "";
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your login: ");
                    login = Console.ReadLine();

                    using (StreamReader sr = new StreamReader(login))
                    {

                    }
                    Console.WriteLine("Uncorrect enter login!!! Try again!");
                }
                catch (Exception)
                {
                    if(IsPossible(login))
                        return login;
                }
            }
        }

        private static bool IsPossible(string login)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(login))
                {

                }
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }

    // Клас для роботи з файлом: визначення позиції курсора та встановлення цієї позиції у файлі
    public static class StreamReaderExtensions
    {
        readonly static FieldInfo charPosField = typeof(StreamReader).GetField("charPos", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | BindingFlags.DeclaredOnly);
        readonly static FieldInfo byteLenField = typeof(StreamReader).GetField("byteLen", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | BindingFlags.DeclaredOnly);
        readonly static FieldInfo charBufferField = typeof(StreamReader).GetField("charBuffer", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | BindingFlags.DeclaredOnly);

        public static long GetPosition(this StreamReader reader)
        {
            int byteLen = (int)byteLenField.GetValue(reader);
            var position = reader.BaseStream.Position - byteLen;

            int charPos = (int)charPosField.GetValue(reader);
            if (charPos > 0)
            {
                var charBuffer = (char[])charBufferField.GetValue(reader);
                var encoding = reader.CurrentEncoding;
                var bytesConsumed = encoding.GetBytes(charBuffer, 0, charPos).Length;
                position += bytesConsumed;
            }
            return position;
        }

        public static void SetPosition(this StreamReader reader, long position)
        {
            reader.DiscardBufferedData();
            reader.BaseStream.Seek(position, SeekOrigin.Begin);
        }
    }
}
