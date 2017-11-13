using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleList<int> list = new SimpleList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(8);
            list.Add(5);
            list.Add(3);
            list.Add(4);

            //list.Ubdate(8,3, false);
            //list.Ubdate(3, 0, true);
            list.Insert(2,3);
            Console.WriteLine(list);

            //list.RemoveFirst();
            //list.Count();
            //list.Clear();
            //list.Add(3);
            //list.IndexOf(4);
            //list.Remove(4);
            //int[] a = new int[list.Count()];

            //a = list.ToArray();
            //for (int i = 0; i < list.Count(); i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            
            


            // List<int> r = new List<int>();

            Console.ReadLine();
        }
    }
}
