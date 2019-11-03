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
        public double Discount { get;  set; }
        // Причина отримання пільг
        public string Reason { get;  set; }

        // Конструктор за замовчуванням
        public UserBenefit() : base()
        {
            Discount = 0;
            Reason = "none";
        }

        // Конструктор з параметрами
        public UserBenefit(string login, string password, string name, int sum, double discount, string reason) : base(login, password, name, sum, 2)
        {
            Discount = discount;
            Reason = reason;
        }

        // Конструктор копіювання, на основі базового класу
        public UserBenefit(User other, double discount, string reason) : base(other)
        {
            this.Discount = discount;
            this.Reason = reason;
        }

        public override void Get_info()
        {
            base.Get_info();
            Console.WriteLine($"Discount (%): {Discount}\nReason: {Reason}\n");
            Console.ReadLine();
        }

        public override void DetermineTheAmount(double koef)
        {
            koef = 1 - Discount / 100;
            base.DetermineTheAmount(koef);
        }
    }
}
