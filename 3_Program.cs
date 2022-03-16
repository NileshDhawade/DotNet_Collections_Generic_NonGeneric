using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_MyGeneric_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<int> obj1 = new MyGenericClass<int>(110);
            obj1.getData();
            Console.WriteLine(obj1);
            Console.WriteLine("=====================================");

            MyGenericClass<string> obj2 = new MyGenericClass<string>("nilesh");
            obj2.getData();
            Console.WriteLine(obj2);

            Console.WriteLine("=====================================");

            MyGenericClass<float> obj3 = new MyGenericClass<float>(12.33f);
            obj3.getData();
            Console.WriteLine(obj3);

            Console.WriteLine("====================================");

            MyGenericClass<bool> obj4 = new MyGenericClass<bool>(true);
            obj4.getData();
            Console.WriteLine(obj4);

        }
    }
}
