using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    delegate int CalcTest(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            FunctionsContainer funcList = new FunctionsContainer();

            funcList["Double"] = val => val * 2;
            funcList["Triple"] = val => val * 3;
            funcList["Square"] = val => val * val;
            funcList["Sqrt"] = val => Math.Sqrt(val);
            funcList["Plus2"] = val => val + 2;

            funcList["Double"].Invoke(5);
            CalcTest c = (x, y) => x * y;
            int t = c(4, 5);
            Console.WriteLine(funcList["Double"].Invoke(5));
            Console.Read();
        }


    }
}
