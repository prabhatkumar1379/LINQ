using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp
{
    public class RefAndOut
    {
        //ref, out keyword
     
        public void AddRefOrOut(ref int refa , out int myout)
        {
            refa = refa + 1;
            myout = 10;
            Console.WriteLine($"refa value :{refa} , out value :{myout}");
        }
    }
}
