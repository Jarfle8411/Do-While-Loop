using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Sort_Method
{
    class simple_array_sort_method
    {
        static void Main(string[] args)
        {
            // Do_While construct is do{}while(test)
            string x;
            do
            { // q means to quit

                Console.WriteLine("Type an \"q\" to end program");
                Console.WriteLine("enter response:");
                x = Console.ReadLine();
                Console.WriteLine(x);
            }
            while (x != "q");
        }
    }
}
