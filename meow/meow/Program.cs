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
<<<<<<< HEAD
            Console.WriteLine("exchage form 1/8");
        Console.Write("Please enter your exchange: ");
        string str = Console.ReadLine();
        int cost = 0;
=======
 
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
>>>>>>> dabc65be24b5adc27128a770515209d609dbd72d

        switch (str)
        {
            case "exchange1":
            case "exchange 1":
                cost += 1;
               break;
            case "exchange2":
            case "exchange 2":
                cost += 2;
                goto case "exchange 1";
            case "exchange3":
            case "exchange 3":
                cost += 3;
                goto case "exchange 1";
            case "exchange4":
            case "exchange 4":
                cost += 4;
                goto case "exchange 1";
            case "exchange5":
            case "exchange 5":
                cost += 5;
                goto case "exchange 1";
            case "exchange6":
            case "exchange 6":
                cost += 6;
                goto case "exchange 1";
            case "exchange7":
            case "exchange 7":
                cost += 7;
                goto case "exchange 1";
            case "exchange8":
            case "exchange 8":
                cost += 8;
                goto case "exchange 1";
            default:
                Console.WriteLine("Invalid selection. Please select 1, 2, 3, 4, 5, 6, 7 or 8");
                break;
        }

            if (cost != 0)
        {
            Console.WriteLine("{0} ", cost);
        }
        }
    }
}
