using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Threads;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            //TicTac tt = new TicTac();
            //MyThread m0 = new MyThread("tic",tt);
            //MyThread m1 = new MyThread("tac", tt);

            //m0.thr.Join();
            //m1.thr.Join();
            //Process newProces =  Process.Start("wordpad.exe");

            //newProces.WaitForExit();
            //newProces.Close();

            //Console.ReadKey();
            Threads.Matrix m;

            for (int i = 0; i < 30; i++)
            {
                m = new Matrix(i*2);
                new Thread (m.Move).Start();
            }

            Console.ReadKey();

        }
    }
}
