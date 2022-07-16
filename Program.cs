using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ctr;
            char ch;

            Console.WriteLine("\nNumber Value\n");
            
            for (ctr = 63; ctr <= 94; ctr = ctr + 1)
            {
                ch = (char)ctr;
                Console.WriteLine("{0} is {1}", ctr, ch);
            }

        }
    }
}
