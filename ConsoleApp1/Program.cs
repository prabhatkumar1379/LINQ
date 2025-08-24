using BasicCSharp;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace ConsoleApp1
{
    public class Program
    {
        

        static void Main(string[] args)
        {
           
            Console.WriteLine("My Basic CSharp Program!");
            MyDataType  d = new MyDataType();
            //Console.WriteLine(d.a);
            //Console.WriteLine(d.name);

            //Console.WriteLine(MyDataType.age);
            //if (d.Myage.HasValue)
            //{
            //    Console.WriteLine($" myage :{d.Myage}");
            //}
            //else
            //{
            //    Console.WriteLine($"No age available for Myage:{d.Myage}");
            //}

            //calling ControlStatement.IfStatement 
            ControlStatement.IfStatement();
            Console.WriteLine("calling ContinueMethod");
            ControlStatement.ContinueMethod();
            Console.WriteLine("calling MyDoWhile");
            ControlStatement.MyDoWhile();
            Console.WriteLine("calling WileLoop");
            ControlStatement.WileLoop();
            Console.WriteLine("-----------ArrayDEMO---------------");
            ArrayDemo.DemoOfArray();
            Console.WriteLine("calling BoxingUnBoxing -------");
            BoxingAndUnBoxing.BoxingUnBoxing();

            Console.WriteLine("--------Ref and out-------");
            RefAndOut  ro = new RefAndOut();
            int refa = 5;//must be initialize
            int myout;// may or may not be initialize
            ro.AddRefOrOut(ref refa, out myout);
            Console.WriteLine($"refa:{refa}, out :{myout}");


        }
    }
}
