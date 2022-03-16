using System;
//Write a program for creating Laptop.
//Name, Price, Processor, Ram and Hard drive should be defined in base class as constant.
//You need to inherit these functionalities in your program and Print Details.
//All the laptop should have different name, price, processor, ram and hard drive.

namespace TSystem_Inheritance
{
   
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Maruti();
            c.run();

            //Explanation: In fact, this is name hiding feature in C# language.
            //If base class and derived class have same method name and have not used virtual and override in base and derived class respectively
            //then on creating object of derived class and assigning to base reference will call base class method.

            Console.WriteLine("==================================================");
            Product p = new Product(111,"samsung mobile",7000);
            p.productDetails();
            Console.WriteLine(p);
            Console.WriteLine("==================================================");
            Product p1= new Product(111, "samsung mobile", 4700);
            p1.productDetails();
            Console.WriteLine(p1);

            Console.WriteLine("==================================================");
            Student s = new Student("nilesh",55.55);
            s.calculatePercentage();
            Console.WriteLine(s);
            Console.WriteLine("-------------------------------------------------");
            Student s1 = new Student("Rahul", 30.55);
            s1.calculatePercentage();
            Console.WriteLine(s1);

            //static method will be called by using class name
            Console.WriteLine("total students are"+Student.getCount());


        }
    }
}
