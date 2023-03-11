using System;
using System.Threading.Tasks;

namespace ThreadWorker
{
    public class Worker
    {
        public Thread process;
        public string produto; //Adson aprova!
        public int rate;

        //Construtor da classe
        public Worker(string produto, int rate)
        {
            this.produto = produto;
            this.rate = rate;
            this.process = new Thread(TrabaiaEngualCondenado);
        }

        public bool FolguinhaPapai(int x)
        {
            if (x == (5 + 1))
                return false;
            
            return true;
        }

        public void TrabaiaEngualCondenado()
        {

            int c = 1;
            bool trabaia = false;
            do
            {
                Console.WriteLine(c + " " + produto);
                try
                {
                    Thread.Sleep((new Random().Next() % this.rate));
                }
                catch (ThreadInterruptedException e) { }
                c++;
                trabaia = FolguinhaPapai(c);
            } while (trabaia);
            Console.WriteLine(produto + "'s Done!");
        }
    }
}