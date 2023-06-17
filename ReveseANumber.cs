using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class ReveseANumber
    {
        public static void reverse()
        {
            int number = 245;

            char[] chars = number.ToString().ToCharArray();

            for(int i=chars.Length-1;i<=0;i--)
            {
                Console.WriteLine(chars[i]);
            }
        }
        
    }

    class SumofNumbers
    {
        public static void Sum()
        {
            int number = 245;
            int sum = 0, remainder=0;

            while(number>0)
            {
                number = number % 10;
                sum = sum + remainder;
                number= number / 10;
            }

            Console.WriteLine("Sum of the numbers of the number is "+sum);
        }
    }

    class Triangle
    {
        public static void Stars()
        {
            Console.WriteLine("Enter the number of the rows");
            int N = Convert.ToInt32(Console.ReadLine());

            for(int i=N;i>=1;i--) 
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
