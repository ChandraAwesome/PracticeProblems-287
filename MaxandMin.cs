using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class MaxandMin
    {
        public static void MaxMin()
        {


            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

            int max = arr[0];
            int min = arr[0];

            for (int i = 0;i<arr.Length;i++ )
            {
                if (arr[i]>max)
                {
                    arr[i] = max;
                }
                else if (arr[i]<min)
                {
                    arr[i] = min;
                }
            }

            Console.WriteLine("Maximum element of the array "+max);
            Console.WriteLine("Minimum element of the array "+min);
    } }

}
