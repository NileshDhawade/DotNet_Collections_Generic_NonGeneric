using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Properties_Set_Get
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department obj = new Department();
            obj.Id = 111;
            obj.Dname = "mechanical";
            Console.WriteLine(obj.Id+" "+obj.Dname);
        }
    }
}
