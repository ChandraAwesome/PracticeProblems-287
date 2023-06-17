using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class DuplicateElementsinanArray
    {
        public static void CheckArray()
        {
            char[] chars = { 'a', 'b', 'c', 'd', 'a', 'b' };
            int count = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                bool duplicate = false;
                for (int j = i + 1; j < chars.Length; j++)
                {
                    if (chars[i] == chars[j])
                    {
                        Console.WriteLine("Duplicate Elements are " + chars[i]);
                        count++;
                        duplicate = true;
                        break;
                    }
                }
                if (!duplicate)
                {
                    Console.WriteLine("Unique elemets are " + chars[i]);
                }
            }
        Console.WriteLine("Number of Duplicate Elements in this array are "+count);
        } 
    }
}
