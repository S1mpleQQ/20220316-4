using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220316_4
{
    class Program
    {
        static void Main(string[] args)
        { 
            for (int i = 10; i>0; i -= 2)
            {
                if (i == 3) continue;
                Console.Write("{0}", i);
            }
            Console.ReadLine();
        }
        
    }
}
