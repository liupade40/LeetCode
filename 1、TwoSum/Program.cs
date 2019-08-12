using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var ar = TwoSum(new int[] { 1, 2, 3, 4, 5 }, 3);
            if (ar.Length == 0)
            {
                Console.WriteLine("Not Found");//11111111
            }
            else
            {
                foreach (var item in ar)
                {
                    Console.WriteLine(item);//
                }
            }
            Console.ReadKey();
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] ar = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {

                    var sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        ar[0] = i;
                        ar[1] = j;
                        return ar;
                    }
                }
            }
            return ar;
        }
    }
}
