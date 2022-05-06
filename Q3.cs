using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class person
    {
        protected string FristName { get; set; }
        protected string FamilyName { get; set; }
        protected int age { get; set; }
        protected int Id { get; set; }
        protected string Department { get; set; }
        protected int BorrowoedBooks { get; set; }
        // عشان علي مستوى الوراثة protected معمولين
        public person(string F, string S, int a, int I, string Dep, int Bor)
        //كونستراكتور 
        {
            this.FristName = F;
            this.FamilyName = S;
            this.age = a;
            this.Id = I;
            this.Department = Dep;
            this.BorrowoedBooks = Bor;
        }
        public virtual string GetInfo()
        // virtual عشان الاطفال هيورثوها من الاب حطيت 
        {
            return
            " The FristName is  : " + this.FristName +
            "\n\n Family Name      : " + this.FamilyName +
            "\n\n age               : " + this.age +
            "\n\n Id                : " + this.Id +
            "\n\n Department        : " + this.Department +
            "\n\n Borrowoed Books   : " + this.BorrowoedBooks +
            "\n-------------------------------------------------------------";

        }
    }
    class student : person
    //    الاب : الابن  
    {
        private int StudentYear;
        public student(string F, string S, int a, int I, string Dep, int Bor, int Stu)
            : base(F, S, a, I, Dep, Bor)
        //    الاب : الابن  
        //StudentYearهيبعت ال6 متغيرات للاب ويفضل ال
        //كونستراكتور 
        {
            this.StudentYear = Stu;
        }
        public override string GetInfo()
        // override عشان اقدر اورثها حطيت  GetInfo فية صفة في الاب اسمها  
        {
            return
             " The FristName     : " + this.FristName +
             "\n\n Family Name       : " + this.FamilyName +
             "\n\n age               : " + this.age +
             "\n\n Id                : " + this.Id +
             "\n\n Department        : " + this.Department +
             "\n\n BorrowoedBooks    : " + this.BorrowoedBooks +
             "\n\n StudentYear       : " + this.StudentYear +

 "\n-------------------------------------------------------------";
        }
    }
    class lecturer : person
    {
        private string position;
        public lecturer(string F, string S, int a, int I, string Dep, int Bor, string po)
            : base(F, S, a, I, Dep, Bor)
        //    الاب : الابن 
        //كونستراكتور 
        //loadGoodsهيبعت السبع متغيرات للاب ويفضل ال
        {
            this.position = po;
        }
        public override string GetInfo()
        // override عشان اقدر اورثها حطيت  GetInfo فية صفة في الاب اسمها 
        {
            return
            " The FristName     :    " + this.FristName +
            "\n\n Family Name       :    " + this.FamilyName +
            "\n\n age               :    " + this.age +
            "\n\n Id                :    " + this.Id +
            "\n\n Department        :    " + this.Department +
            "\n\n BorrowoedBooks    :    " + this.BorrowoedBooks +
            "\n\n position          :    " + this.position;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t \n\n\t\t\t under the supervision ENG : DINA SAIF\n \n\t\t\t\t hisham ebrahim sheta");

            student student1 = new student(" hisham ", " sheta ", 22, 202001, "Electrical engineering department", 10, 1);
            //object
            student student2 = new student(" mohammed ", " batekhaa ", 21, 202002, "Electrical engineering department", 5, 1);
            //object
            lecturer lecturer = new lecturer(" sosoooooo ", " de ana ", 50, 1, "Electrical engineering department", 1, "boss");
            //object
            Console.WriteLine(student1.GetInfo());
            Console.WriteLine(student2.GetInfo());
            Console.WriteLine(lecturer.GetInfo());
            Console.ReadLine();
        }
    }
}
