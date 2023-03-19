using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitiik
{
    internal class Program
    {
        static void NewFeature()
        {
            Console.WriteLine("this is new Feature");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("v2");
            Console.WriteLine("v3");
            NewFeature();
        }
    }
}
