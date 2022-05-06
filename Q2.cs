using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class vehicle
    {
        protected string color { get; set; }
        protected string model { get; set; }
        protected int wheels { get; set; }
        protected int licenseNumber { get; set; }
        protected int year { get; set; }
        protected int motor { get; set; }
        protected int doors { get; set; }
        // عشان علي مستوى الوراثة protected معمولين
        public vehicle(int W, string C, int L, string mod, int y, int mot, int d)
        //كونستراكتور 
        {
            this.wheels = W;
            this.color = C;
            this.licenseNumber = L;
            this.model = mod;
            this.year = y;
            this.motor = mot;
            this.doors = d;
        }
        public virtual string GetInfo()
        // virtual عشان الاطفال هيورثوها من الاب حطيت 
        {
            return
            " 1- The  vehicle wheels   = " + this.wheels +
            "\n\n 2- licenseNumber         = " + this.licenseNumber +
            "\n\n 3- number of doors       = " + this.doors +
            "\n\n 4- color is              : " + this.color +
            "\n\n 5- model                 : " + this.model +
            "\n\n 6- year                  : " + this.year +
            "\n\n 7- motor                 : " + this.motor + "\n---------------------------------";

        }
    }
    class car : vehicle
    //    الاب : الابن  
    {
        private double bagSize;
        public car(int W, string C, int L, string mod, int y, int mot, int d, double b)
            : base(W, C, L, mod, y, mot, d)
        //    الاب : الابن  
        //bagsizeهيبعت السبع متغيرات للاب ويفضل ال
        //كونستراكتور 
        {
            this.bagSize = b;
        }
        public override string GetInfo()
        // override عشان اقدر اورثها حطيت  GetInfo فية صفة في الاب اسمها  
        {
            return
             " 1- bag size             = " + this.bagSize +
             "\n\n 2- The car wheels        = " + this.wheels +
             "\n\n 3- licenseNumber         = " + this.licenseNumber +
             "\n\n 4- number of doors       = " + this.doors +
             "\n\n 5- color is              : " + this.color +
             "\n\n 6- model                 : " + this.model +
             "\n\n 7- year                  : " + this.year +
             "\n\n 8- motor                 : " + this.motor +
 "\n---------------------------------";
        }
    }
    class truck : vehicle
    {
        private double loadGoods;
        public truck(int W, string C, int L, string mod, int y, int mot, int d, double load)
            : base(W, C, L, mod, y, mot, d)
        //    الاب : الابن 
        //كونستراكتور 
        //loadGoodsهيبعت السبع متغيرات للاب ويفضل ال
        {
            this.loadGoods = load;
        }
        public override string GetInfo()
        // override عشان اقدر اورثها حطيت  GetInfo فية صفة في الاب اسمها 
        {
            return
             " 1- The Goods load        = " + this.loadGoods +
             "\n\n 2- The truck wheels      = " + this.wheels +
             "\n\n 3- licenseNumber         = " + this.licenseNumber +
             "\n\n 4- number of doors       = " + this.doors +
             "\n\n 5- color is              : " + this.color +
             "\n\n 6- model                 : " + this.model +
             "\n\n 7- year                  : " + this.year +
             "\n\n 8- motor                 : " + this.motor;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t \n\n\t\t\t under the supervision ENG : DINA SAIF\n \n\t\t\t\t hisham ebrahim sheta");

            vehicle v = new vehicle(4, " red ", 5, " Supra ", 2020, 2200, 2);
            //object
            car c = new car(4, " blue ", 7, " Aston Martin ", 2019, 2200, 2, 300);
            //object
            truck T = new truck(8, " orange ", 7, " Volkswagen ", 2000, 2200, 2, 5000);
            //object
            Console.WriteLine(v.GetInfo());
            Console.WriteLine(c.GetInfo());
            Console.WriteLine(T.GetInfo());
            Console.ReadLine();
        }
    }
}
