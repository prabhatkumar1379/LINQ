using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp
{
    public class ControlStatement
    {
        public static void IfStatement()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
        public static void ContinueMethod()
        {
            for (int i = 1; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        public static void WileLoop()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine($"While i:{i}");
                i++;
            }
        }
        public static void MyDoWhile()
        {
            int i = 1; //Initialization
            do
            {
                Console.WriteLine($"DO value of i :{i}");
                i++;
            }
            while (i < 5);
        }
      
    }
}