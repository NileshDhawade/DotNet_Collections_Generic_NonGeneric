using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_NonGeneric_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(22);
            list.Add("nilesh");
            list.Add(33.33);
            list.Add(null);
            list.Add(true);

            Console.WriteLine("=====display of arrayList=====");
            foreach (object item in list)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("========different methods in use=======");
            list.Insert(1, 55);
            list.Remove(true);
            list.RemoveAt(3);
            foreach (object item1 in list)
            {
                Console.WriteLine(item1);

            }
            Console.WriteLine("============stack==========");
            Stack st = new Stack();
            st.Push(10);
            st.Push("nilesh");
            st.Push(22.22);
            st.Push(true);
            st.Push(1.22);

            st.Pop();
            foreach (object item22 in st)
            {
                Console.WriteLine(item22);

            }

            Console.WriteLine("========queue========");
            Queue q = new Queue();
            q.Enqueue(111);
            q.Enqueue("nilesh");
            q.Enqueue(12.11);
            q.Enqueue("rahul");

            q.Dequeue();

            foreach (object item44 in q)
            {
                Console.WriteLine(item44);
            }

            Console.WriteLine("========HashTable=============");
            Hashtable h = new Hashtable();
            h.Add(1, "INDIA");
            h.Add(2, "USA");
            h.Add(3,"RUSSIA");
            h.Add(4, "AUSTRALIA");

            h.Remove(4);
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key+" "+item.Value);

            }


           

        }
    }
}
