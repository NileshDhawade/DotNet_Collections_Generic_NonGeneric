using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_MyGeneric_collections
{
    internal class MyGenericClass <T>
    {
        private T data;
        public MyGenericClass(T data)
        {
            this.data = data;
                
        }
        public T getData()
        {
            return data;
        }
        public override string ToString()
        {
            return "data is " + data;
        }
    }
}
