using System;

namespace BasicCSharp
{
    public class BoxingAndUnBoxing
    {
        public static  void BoxingUnBoxing()
        {
            int num = 10; // Value type, stored in Stack

            // Boxing: Value type (int) → Reference type (object)
            object obj = num; // num is boxed and stored in Heap

            Console.WriteLine($"Boxing: num = {num}, obj = {obj}");

            // UnBoxing: Reference type (object) → Value type (int)
            int newNum = (int)obj; // Explicit cast is required
            Console.WriteLine($"UnBoxing: newNum = {newNum}");

            //Type Casting :The process of converting from one type to another type is called Type Casting
            //its two type
            //1:Implicit 
            //2. explicit

            int a = 10;
            double d = a; //implicit

            double dd = 10.95;
            int res = (int)dd; // explicit chance of data loss


        }
    }
}
