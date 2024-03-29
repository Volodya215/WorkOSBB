﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga_Sharp
{
    class Company : User
    {
        public string Type { get;  set;}
        public int CountOfEmploye { get;  set;}

        public Company() : base()
        {
            Type = "none";
            CountOfEmploye = 0;
        }

        //public Company(User other) : base(other)
        //{
        //}

        public Company(string login, string password, string name, int sum, string type, int count_of_employe) : base(login, password, name, sum, 3)
        {
            Type = type;
            CountOfEmploye = count_of_employe;
        }

        // Конструктор копіювання, на основі базового класу
        public Company(User other, string type, int countOfEmploye) : base(other)
        {
            this.Type = type;
            this.CountOfEmploye = countOfEmploye;
        }

        public override void Get_info()
        {
            base.Get_info();
            Console.WriteLine($"Type: {Type}\nCount Of Employe: {CountOfEmploye}\n");
            Console.ReadLine();
        }

        public override void DetermineTheAmount(double koef)
        {
            koef = 1 + CountOfEmploye / 100;
            base.DetermineTheAmount(koef);
        }
    }
}
