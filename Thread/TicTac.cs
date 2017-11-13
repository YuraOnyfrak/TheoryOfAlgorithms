using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class TicTac
    {
        object turnOff = new object();

        public void Tic( bool flag)
        {
            lock (turnOff)
            {
                if (flag)
                {
                    return;
                }
                Console.WriteLine("Tic");
                Monitor.Pulse(turnOff);
                Monitor.Wait(turnOff);
            }
        }

        public void Tac(bool flag)
        {
            lock (turnOff)
            {
                if (flag)
                {
                    return;
                }
                Console.WriteLine("Tac");
                Monitor.Pulse(turnOff);
                Monitor.Wait(turnOff);
            }
        }

    }
}
