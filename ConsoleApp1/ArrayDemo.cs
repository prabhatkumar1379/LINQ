using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp
{
    public class ArrayDemo
    {
       
        public static void DemoOfArray()
        {
            string[] fruits = new string[5];
            fruits[0] = "Apple";
            fruits[1] = "Mango";
            fruits[2] = "PLUM";
            fruits[3] = "Banana";
            fruits[4] = "Kiwi";
           //foreach
           foreach(var item in fruits)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---For Loop-----");
           for(int i =0;i< fruits.Length -1;i++)
            {
                Console.WriteLine(fruits[i]);
            }
            Console.WriteLine("------While Loop---------");

            int j = 0;
            while(j < fruits.Length -1)
            {
                Console.WriteLine(fruits[j]);
                j++;
            }
            Console.WriteLine("-----Do While Loop--------");
            int k = 0;
            do
            {
                Console.WriteLine(fruits[k]);
                k++;
            }
            while (k < fruits.Length - 1);


           

        }
    }
}
