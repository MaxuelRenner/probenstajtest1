using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача
{
    class Program
    {
        static void Main(string[] args)
        {
 
  int n;

        int[] arr = new int[8];
        for (n = 0; n < 8; n++)
        {
            Console.Write(": ", n);
            arr[n] = Convert.ToInt32(Console.ReadLine());
        }



        Console.Write("\nElements in array are: ");
        for (n = 0; n < 8; n++)
        {
            Console.Write("{0} ", arr[n]);
        }

        }
    }
}
