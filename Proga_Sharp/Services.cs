using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga_Sharp
{
    public class Services
    {
        private double electricity;
        private double warm;
        private double gas;
        private double water;
        private double homePay;

        public double Electricity { get => electricity; set => electricity = value; }
        public double Warm { get => warm; set => warm = value; }
        public double Gas { get => gas; set => gas = value; }
        public double Water { get => water; set => water = value; }
        public double HomePay { get => homePay; set => homePay = value; }

        public Services() => Electricity = Warm = Gas = Water = HomePay = 0;

        public Services(double electricity, double warm, double gas, double water, double homePay)
        {
            Electricity = electricity;
            Warm = warm;
            Gas = gas;
            Water = water;
            HomePay = homePay;
        } 

        public static Services operator+ (Services temp1, Services temp2)
        {
            Services temp = new Services();
            temp.Electricity = temp1.Electricity + temp2.Electricity;
            temp.Warm = temp1.Warm + temp2.Warm;
            temp.Gas = temp1.Gas + temp2.Gas;
            temp.Water = temp1.Water + temp2.Water;
            temp.HomePay = temp1.HomePay + temp2.HomePay;

            return temp;
        }
    }
}
