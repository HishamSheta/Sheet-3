using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Shape
    //class الاب
    {
        //الكونستراكتور الافتراضي
        public Shape()
        {
        }
        public virtual double getarea()
        // virtual عشان الاطفال هيورثوها من الاب حطيت 
        {
            return 0;
        }
        public virtual double getparimter()
        //         رايحة باية() -  اسمها اية - راجعة باية
        {
            return 0;
        }
    }

    class square : Shape
    //  الاب : الابن  
    {
        //الضلع 
        private double side { get; set; }
        public square(double s)
        {
            this.side = s;
        }
        public override double getarea()
        // override عشان اقدر اورثها حطيت  getareaفية صفة في الاب اسمها  
        {
            return side * side;
            //الضلع فنفسة
        }
        public override double getparimter()
        // override عشان اقدر اورثها حطيت  getparimter فية صفة في الاب اسمها  
        {
            return side * 4;
            //المحيط = الضلع *4
        }

    }
    class rectangle : Shape
    //  الاب : الابن  
    {
        private double width { get; set; }
        private double leigth { get; set; }
        public rectangle(double w, double l)
        //كونستراكتور 
        {
            this.width = w;
            this.leigth = l;
        }
        public override double getarea()
        // override عشان اقدر اورثها حطيت  getareaفية صفة في الاب اسمها 
        {
            return leigth * width;
        }
        public override double getparimter()
        // override عشان اقدر اورثها حطيت  getparimter فية صفة في الاب اسمها  
        {
            return 2 * (leigth + width);
        }
    }

    class circle : Shape
    //  الاب : الابن  
    {
        private double radius { get; set; }
        public circle(double r)
        //كونستراكتور 
        {
            this.radius = r;
        }
        public override double getarea()
        // override عشان اقدر اورثها حطيت  getareaفية صفة في الاب اسمها 
        {
            return (3.14 * radius * radius);
        }
        public override double getparimter()
        // override عشان اقدر اورثها حطيت  getparimter فية صفة في الاب اسمها  
        {
            return (2 * 3.14 * radius);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t \n\n\t\t\t under the supervision ENG : DINA SAIF\n \n\t\t\t\t hisham ebrahim sheta");
            square square = new square(6);
            //object
            Console.WriteLine("\n\t\t The area of the square        is   = " + square.getarea());
            Console.WriteLine("\n\t\t The parimter of the square    is   = " + square.getparimter());

            rectangle rectangle = new rectangle(4, 8);
            //object
            Console.WriteLine("\n\t\t The area of the rectangle     is   = " + rectangle.getarea());
            Console.WriteLine("\n\t\t The parimter of the rectangle is   = " + rectangle.getparimter());

            circle circle = new circle(4);
            Console.WriteLine("\n\t\t The area of the circle        is   = " + circle.getarea());
            Console.WriteLine("\n\t\t The parimter of the circle    is   = " + circle.getparimter());
            Console.ReadLine();
        }
    }
}

