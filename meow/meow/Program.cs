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


        string max = Console.ReadLine();

        if (max == "max even")
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
        }else if(max == "max odd")
        {
            for (int j = 0; j < n; j++)
            {
                if (arr[j] % 2 != 0)
                {
                    Console.WriteLine(arr[j] + " ");
                }
                   

            }
        }


    }
}
