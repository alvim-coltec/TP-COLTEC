using System;
using System.Collections.Concurrent;

namespace MarketThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            Producer produtor = new Producer(stack);
            Consumer consumidor = new Consumer(stack);

            Thread p = new Thread(new ThreadStart(produtor.Run));
            Thread c = new Thread(new ThreadStart(consumidor.Run));
            p.Start();
            c.Start();
        }
    }
}