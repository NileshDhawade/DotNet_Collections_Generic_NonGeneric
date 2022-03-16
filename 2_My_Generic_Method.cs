using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_GenericMethod_Collections
{
    class My_Generic_Method
    {
        public void Swap<T>(ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        //public override string ToString()
        //{
        //  return base.ToString();
        //}

    }
}
