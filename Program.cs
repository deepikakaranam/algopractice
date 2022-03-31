using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    class Program
    {
        static void Main(string[] args)
        {
            Program bn = new Program();
            bn.binarySearch(new int[] { 2, 1, 5, 4, 3 }, 6);
            bn.lengthOfLongestSubstring("abcabcbb");

        }
        public char maxconsString(string a)
        {
            char result = a[0];
            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                int curr_count = 1;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] != a[j])
                        break;
                    curr_count++;
                }
                if (curr_count > count)
                {
                    count = curr_count;
                    result = a[i];
                }
            }
            return result;
        }

        public int binarySearch(int[] a, int num)
        {
            Array.Sort(a);
            int min = 0;
            int max = a.Length;
            int mid = (min + max) / 2;
            int result = -1;
            if (num == a[mid])
            {
                result = a[mid];
                
            }

            if (num < a[mid])
            {
                for (int i = 0; i < mid; i++)
                {
                    if (num == a[i])
                    {
                        result = a[i];

                    }
                }
            }

            if (num > a[mid])
            {
                for (int i = mid; i < a.Length; i++)
                {
                    if (num == a[i])
                    {
                        result = a[i];
                    }
                }

            }
            
            Console.WriteLine(result);
            return result;
        }

        public int lengthOfLongestSubstring(string s)
        {
            string a = s[0].ToString() ;
            
            int count = 0;
            for (var i = 0; i <= s.Length; i++)
            {
                if()


        }
    }
   


}
