using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_GenericMethod_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            My_Generic_Method obj = new My_Generic_Method();
            obj.Swap<int>(ref a, ref b);
            Console.WriteLine(a+" "+b);

            Console.WriteLine("=========================");
            string name1 = "INDIA", name2 = "NILESH";
            My_Generic_Method obj2= new My_Generic_Method();
            obj.Swap<String>(ref name1, ref name2);
            Console.WriteLine(name1 + " " + name2);

            Console.WriteLine("=========================");

            float a1  = 10.33f, b1 = 20.44f;
            My_Generic_Method obj3 = new My_Generic_Method();
            obj.Swap<float>(ref a1, ref b1);
            Console.WriteLine(a1 + " " + b1);

            Console.WriteLine("=========================");

            long a11= 444444444, b11 = 55555555555555;
            My_Generic_Method obj4 = new My_Generic_Method();
            obj.Swap<long>(ref a11, ref b11);
            Console.WriteLine(a11 + " " + b11);












        }
    }
}
