using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product1> pList = new List<Product1>();

            Product1 p1 = new Product1(111, "mobile", 12000);
            Product1 p2 = new Product1(112, "hp laptop", 60000);
            Product1 p3 = new Product1(113, "dell laptop", 50000);
            Product1 p4 = new Product1(114, "keyboard", 1200);
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            foreach (Product1 item in pList)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("============stack==========");
            Stack<Product1> st1 = new Stack<Product1>();

            Product1 p11 = new Product1(111, "mobile", 12000);
            Product1 p21 = new Product1(112, "hp laptop", 60000);
            Product1 p31 = new Product1(113, "dell laptop", 50000);
            Product1 p41 = new Product1(114, "keyboard", 1200);

            st1.Push(p11);
            st1.Push(p21);
            st1.Push(p31);
            st1.Push(p41);

            st1.Pop();

            foreach (Product1 item in st1)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("============queue==========");

            Queue<Product1> q11 = new Queue<Product1>();

            Product1 p111 = new Product1(111, "mobile", 12000);
            Product1 p211 = new Product1(112, "hp laptop", 60000);
            Product1 p311 = new Product1(113, "dell laptop", 50000);
            Product1 p411 = new Product1(114, "keyboard", 1200);

            q11.Enqueue(p111);
            q11.Enqueue(p211);
            q11.Enqueue(p311);
            q11.Enqueue(p411);

            q11.Dequeue();

            foreach (Product1 item in q11)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("=========dictionary=========");
            Dictionary<Product1, string> d = new Dictionary<Product1, string>();

            d.Add(p111, "electronic_equipment");
            d.Add(p211, "electronic_equipment");
            d.Add(p311, "electronic_equipment");
            d.Add(p411, "electronic_equipment");

            foreach (KeyValuePair<Product1, string> item5 in d)
            {
                Console.WriteLine(item5);
            }
            
        }
    }
}
