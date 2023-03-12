using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketThread
{
    internal class Producer
    {
        ConcurrentStack<int> stack;

        public Producer(ConcurrentStack<int> Stack)
        {
            this.stack = Stack;
        }

        public void Run()
        {
            int colorIdx = 0;
            for (int i = 0; i < 40; i++)
            {
                colorIdx = (new Random().Next() * i);
                stack.Push(colorIdx);

                Console.WriteLine(" Criado : " + colorIdx);

                try
                {
                    Thread.Sleep(new Random().Next() % 1000);
                }
                catch (ThreadInterruptedException e){ }
            }
        }
    }
}
