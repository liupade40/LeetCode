using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LengthOfLongestSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            var max = new Solution().LengthOfLongestSubstring("aab");
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var sss = s;
            if (s=="")
            {
                return 0;
            }
            if (s.Trim().Length == 0)
            {
                return 1;
            }
            if (s.Length == 1)
            {
                return 1;
            }
            while (true)
            {
                if (s.Length==1)
                {
                    
                    return sss.Length;
                }
                var newstr = s.Substring(1, s.Length-1);
                if (!newstr.Contains(s[0]))
                {
                    s = newstr;
                }
                else
                {
                    break;
                }

            }
            var index = 0;//每次对比的位置
            int indexAdd = 0;//
            List<string> list = new List<string>();
            while (indexAdd != s.Length)
            {
                indexAdd += 1;
                if (indexAdd == s.Length)
                {
                    //index -= 1;
                    if (index == -1)
                    {
                        index = 0;
                    }
                    list.Add(s.Substring(index, indexAdd - index));
                    break;
                }
                var b = s[index] == s[indexAdd];
                if (b)
                {
                    if (index == indexAdd - 1)
                    {
                        list.Add(s.Substring(index, indexAdd - index));
                        list.Add(s.Substring(index + 1, indexAdd - index));
                    }
                    else
                    {
                        list.Add(s.Substring(index, indexAdd - index));
                    }

                    indexAdd += 1;
                    index = indexAdd;

                }
            }
            return list.Max(x => x.Length);
        }
    }
}
