using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga_Sharp
{
    class UserBenefit : User
    {
        // Знижка для користувача цього типу
        public double Discount { get; private set; }
        // Причина отримання пільг
        public string Reason { get; private set; }

        // Конструктор за замовчуванням
        public UserBenefit() : base()
        {
            Discount = 0;
            Reason = "none";
        }

        // Конструктор з параметрами
        public UserBenefit(string login, string password, string name, int sum, int discount, string reason) : base(login, password, name, sum)
        {
            Discount = discount;
            Reason = reason;
        }

        public override void Get_info()
        {
            base.Get_info();
            Console.WriteLine($"Discount: {Discount}\nReason: {Reason}\n");
        }
    }
}
