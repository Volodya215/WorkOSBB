﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga_Sharp
{
    class Inhabitant : User
    {
        // Розмір квартири
        public int Size { get; private set; }
        // Кількість мешканців
        public int Count_inhab { get; private set; }

        // Конструктор за замовчуванням
        public Inhabitant() : base()
        {
            Size = 0;
            Count_inhab = 0;
        }

        //// Конструктор копіювання
        //public Inhabitant(User other) : base(other)
        //{
        //}

        // Конструктор з параметрами
        public Inhabitant(string login, string password, string name, int sum, int size, int count_inhab) : base(login, password, name, sum)
        {
            Count_inhab = count_inhab;
            Size = size;
        }

        public override void Get_info() 
        {
            base.Get_info();
            Console.WriteLine($"Size: {Size}\nCount_inhab {Count_inhab}\n");
        }

    }
}