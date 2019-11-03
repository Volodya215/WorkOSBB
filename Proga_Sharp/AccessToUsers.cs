using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proga_Sharp
{
    public static class AccessToUsers
    {
        public static void LoginTo()
        {
            Console.Write("Enter login: ");
            string login = Console.ReadLine();

            User temp = ReadDataUsers(login);
            if (temp.Login == "")
                return;

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if(password == temp.Password)
            {
                Console.WriteLine("Access is allowed:)");
                //temp.Get_info();
            }
            else
            {
                Console.WriteLine("Incorrect password!!! Access denied!");
                Console.ReadLine();
                return;
            }

            while (true)
            {
                int key = 0;
                Console.WriteLine("1. Get data.");
                Console.WriteLine("2. Enter indicators of counters.");
                Console.WriteLine("3. Calculate costs");
                Console.WriteLine("4. Pay");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter key: ");
                try
                {
                    key = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect key!!!");
                }
                Console.Clear();

                switch (key)
                {
                    case 1:
                        temp.Get_info();
                        break;
                    case 2:
                        temp.FillServices();
                        break;
                    case 3:
                        temp.DetermineTheAmount(1);
                        break;
                    case 4:
                        temp.Pay();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Incorrect enter key!!! Try again!");
                        break;
                }
                Console.Clear();
            }
        }

        private static User ReadDataUsers(string login)
        {
            int type = 0;
            long pos = 0;
            try
            {
                using (StreamReader sr = new StreamReader(login))
                {
                    type = Convert.ToInt32(sr.ReadLine());
                    pos = StreamReaderExtensions.GetPosition(sr);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Uncorrect enter login!!!");
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return new User();
            }

            if (type == 1)
            {
                Inhabitant temp = new Inhabitant();
                OpenInfUsers(temp, pos, login);
                return temp;
            }
            else if (type == 2)
            {
                UserBenefit temp = new UserBenefit();
                OpenInfUsers(temp, pos, login);
                return temp;
            }
            else if (type == 3)
            {
                Company temp = new Company();
                OpenInfUsers(temp, pos, login);
                return temp;
            }
            else
                Console.WriteLine("Can't get access!");
            return new User();
        }

        private static void OpenInfUsers(Inhabitant temp, long pos, string login)
        {
            using (StreamReader sr = new StreamReader(login))
            {
                StreamReaderExtensions.SetPosition(sr, pos);
                temp.Size = Convert.ToInt32(sr.ReadLine());
                temp.Count_inhab = Convert.ToInt32(sr.ReadLine());
                pos = StreamReaderExtensions.GetPosition(sr);
            }
            User.DownloadDataUser(login, pos, temp);
           // temp.Get_info();
        }

        private static void OpenInfUsers(UserBenefit temp, long pos, string login)
        {
            using (StreamReader sr = new StreamReader(login))
            {
                StreamReaderExtensions.SetPosition(sr, pos);
                temp.Reason = sr.ReadLine();
                temp.Discount = Convert.ToDouble(sr.ReadLine());
                pos = StreamReaderExtensions.GetPosition(sr);
            }
            User.DownloadDataUser(login, pos, temp);
           // temp.Get_info();
        }

        private static void OpenInfUsers(Company temp, long pos, string login)
        {
            using (StreamReader sr = new StreamReader(login))
            {
                StreamReaderExtensions.SetPosition(sr, pos);
                temp.Type = sr.ReadLine();
                temp.CountOfEmploye = Convert.ToInt32(sr.ReadLine());
                pos = StreamReaderExtensions.GetPosition(sr);
            }
            User.DownloadDataUser(login, pos, temp);
           // temp.Get_info();
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
