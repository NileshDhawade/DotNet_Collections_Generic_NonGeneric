using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Inheritance
{
     class Car
    { 
         
       // public virtual void run()
        public void run()
        {

            Console.WriteLine("Car is running");
        }

    }
    class Maruti : Car
    {
        //public override void run()
        public void run()
        {

            Console.WriteLine("Maruti Car is running");
        }
    }
}

