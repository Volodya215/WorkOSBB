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
        ///// <summary>
        ///// The main entry point for the application.
        ///// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new StartPage());
        //}


        static int Main()
        {

            //CreateUser.Add_user();


            try
            {
                using (StreamWriter sr = new StreamWriter("dsfsdd   ^*sfsdf  "))
                {

                }
                Console.WriteLine("OK");
            }
            catch(Exception )
            {
                Console.WriteLine("Can't open file!!!");
            }



            Console.ReadLine();
            return 0;
        }

    }

}
