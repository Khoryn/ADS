using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton<int> test = Singleton<int>.Instance;

            Console.ReadKey();
        }
    }
}
