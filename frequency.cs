using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class duplicatecount
    {
        public static void counting()
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'a', 'b' };
            Dictionary<char,int> dict = new Dictionary<char, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict[arr[i]] = 1;
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine("Element is " + kvp.Key + " Frequency is " + kvp.Value);
            }
        }
    }
}
