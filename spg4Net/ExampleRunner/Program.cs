using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using spg4Net;

namespace ExampleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Vangard vangard = new Vangard();
            vangard.RunStandardVangardTest();
            Console.ReadKey();
        }
    }
}
