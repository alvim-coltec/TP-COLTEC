using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MarketThread
{
    internal class SyncStack
    {
        private int index = 0;
        private int[] buffer = new int[10];

        public lock int pop()
        {
            while (index == 0)
            {
                try
                {
                    this.Wait();
                }
                catch (ThreadInterruptedException e) { }
            }
            this.Notify();
            index--;
            return buffer[index];
        }

        public  void push(int i)
        {
            while (index == buffer.length)
            {
                try
                {
                    this.wait();
                }
                catch (InterruptedException e) { }
            }
            this.notify();
            buffer[index] = i;
            index++;
        }
    }
}
