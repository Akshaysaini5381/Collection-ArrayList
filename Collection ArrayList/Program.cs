using System;
using System.Collections;
namespace Collection_ArrayList
{

    class MyClass
    {
        private int empNo;
        private string empName;
        private double empSal;

        public MyClass(int EmpNo , string EmpName,double EmpSal)
        {
            this.empNo = EmpNo;
            this.empName = EmpName;
            this.empSal = EmpSal;
        }

        public override string ToString()
        {
            return empNo + " " + empName + " " + empSal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            obj.Add(12);
            obj.Add("akshay");
            obj.Add(true);
            obj.Add(90.0876);
            obj.Add(12);
            obj.Add("saini");
            foreach (var item in obj)
            {
                Console.WriteLine(" "+item);
            }
            Console.WriteLine(" Name :"+obj.Add("saini"));
            Console.WriteLine("Count total object : "+obj.Count);

            // class object 

            Console.WriteLine("  class object :");
            ArrayList o = new ArrayList();
            MyClass a = new MyClass(100, "ashi", 90.4578);
            o.Add(a);

            MyClass a1 = new MyClass(101, "sarkar", 90.578);
            o.Add(a1);
            foreach (MyClass item in o)
            {
                Console.Write(" "+item);
                Console.WriteLine();
            }
            Console.WriteLine("Count total object class : " + o.Count);
        }
    }
}
