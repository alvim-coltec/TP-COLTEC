using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketThread
{
    internal class Consumer
    {
        ConcurrentStack<int> stack;

        public Consumer(ConcurrentStack<int> Stack)
        {
            this.stack = Stack;
        }

        public void Run()
        {
            int colorIdx = 0;
            for (int i = 0; i < 20; i++)
            {
                stack.TryPop(out colorIdx);

                Console.WriteLine("Usado: " + colorIdx);

                try
                {
                    Thread.Sleep(new Random().Next() % 5000);

                }
                catch (ThreadInterruptedException e){ }
            }

        }
    }
}
