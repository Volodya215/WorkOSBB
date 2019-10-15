using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proga_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //User Bot = new User();

            //Bot.Get_info();

            //Inhabitant Bot_2 = new Inhabitant();
            //Bot_2.Get_info();

            //Company Bot_3 = new Company("lOX", "1111", "Vasya", 0, "middle", 5);
            //Bot_3.Get_info();

            //UserBenefit Bot_4 = new UserBenefit();
            //Bot_4.Get_info();

            CreateUser aaas = new CreateUser();
            aaas.Add_user();

            aaas.Add_user();
            aaas.Add_user();

            Console.ReadLine();
        }
    }
}
