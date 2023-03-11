using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadWorker
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Worker employee = new Worker("GTX 1660 ultra", 5000);
            employee.process.Start();
        }
    }
}
