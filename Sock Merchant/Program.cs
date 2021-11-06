//Finished in 4 minutes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sock_Merchant
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().TrimEnd().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
        }

        static int sockMerchant(int n, int[] ar)
        {
            int pairs = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if(ar[i] != -1 && IsPair(ref ar,i+1, ar[i]))
                {
                    pairs++;
                }
            }

            return pairs;

        }

        static bool IsPair(ref int[] ar,int start,int pairOf)
        {
            for (int i = start; i < ar.Length; i++)
            {
                if (ar[i] == pairOf)
                {
                    ar[i] = -1;
                    return true;
                }
            }
            return false;
        }
    }
}
