using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Generic_Collections
{
    internal class Product1
    {
        int pCode;
        string pName;
        double pPrice;

        public Product1()
        {
            pCode = 0;
            pName = "";
            pPrice = 0;
        }
        public Product1(int pc, string pn, double pp)
        {
            this.pCode = pc;
            this.pName = pn;
            this.pPrice = pp;

        }
        public override string ToString()
        {
            return " \nproduct code " + pCode + "\nproduct name is: " + pName + "\nproduct price is:" + pPrice;
        }
    }
}
