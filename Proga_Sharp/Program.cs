using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks; 
using System.Windows.Forms;

namespace Proga_Sharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


        //static int Main()
        //{

        //    //CreateUser.Add_user();


        //    //try
        //    //{
        //    //    using (StreamWriter sr = new StreamWriter("dsfsdd   ^*sfsdf  "))
        //    //    {

        //    //    }
        //    //    Console.WriteLine("OK");
        //    //}
        //    //catch(Exception )
        //    //{
        //    //    Console.WriteLine("Can't open file!!!");
        //    //}

        //    //Console.Write("Enter login: ");
        //    //string login = Console.ReadLine();
        //    //AccessToUsers.ReadDataUsers(login);

        //   // AccessToUsers.LoginTo();

        //    int key = 0;
        //    while(true)
        //    {
        //        Console.WriteLine("Volodymyr Dolid IS-82 OSBB\n");
        //        Console.WriteLine("\t\tMenu");
        //        Console.WriteLine("1. Registration");
        //        Console.WriteLine("2. Authorization");
        //        Console.WriteLine("3. Exit the application");

        //        Console.Write("Enter key: ");
        //        try
        //        {
        //            key = Convert.ToInt32(Console.ReadLine());
        //        }
        //        catch(Exception)
        //        {
        //            Console.WriteLine("Incorrect key!!!");
        //        }
        //        Console.Clear();
        //        switch (key)
        //        {
        //            case 1:
        //                CreateUser.Add_user();
        //                break;
        //            case 2:
        //                AccessToUsers.LoginTo();
        //                break;
        //            case 3:
        //                return 0;
        //            default:
        //                Console.WriteLine("Uncorrect enter key!!! Try again!");
        //                break;
        //        }
        //        Console.Clear();
        //    }
        //}

    }

}
