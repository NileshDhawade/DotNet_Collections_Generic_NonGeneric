using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Inheritance
{
    public class Product
    {
        int pCode;
        string pName;
        double pPrice;

        public Product()
        {
            pCode = 0;
            pName = "";
            pPrice = 0;
        }
        public Product(int pc,string pn,double pp)
        {
            this.pCode = pc;
            this.pName = pn;
            this.pPrice = pp;

        }
        public void productDetails()
        {
            double finalPrice;
            if (pPrice>5000)
            {
                pPrice = pPrice * 0.90;
            }
            else
            {
                pPrice = pPrice;
                

            }
        }
        public override string ToString()
        {
            return " \nproduct code " + pCode + "\nproduct name is: " + pName + "\nproduct price is:" + pPrice;
        }
    }
}
