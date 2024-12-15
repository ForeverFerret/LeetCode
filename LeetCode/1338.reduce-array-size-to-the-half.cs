using Microsoft.Testing.Platform.Extensions.Messages;
using System.Reflection.Metadata.Ecma335;

namespace LeetCode
{
    public class Solution
    {
        /*
         * 1338. 数组大小减半
         *
         * 给你一个整数数组 arr。你可以从中选出一个整数集合，并删除这些整数在数组中的每次出现。
         * 返回 至少 能删除数组中的一半整数的整数集合的最小大小。
         *
         * 示例 1：
         * 输入：arr = [3,3,3,3,5,5,5,2,2,7]
         * 输出：2
         * 解释：选择 {3,7} 使得结果数组为 [5,5,5,2,2]、长度为 5（原数组长度的一半）。
         * 大小为 2 的可行集合有 {3,5},{3,2},{5,2}。
         * 选择 {2,7} 是不可行的，它的结果数组为 [3,3,3,3,5,5,5]，新数组长度大于原数组的二分之一。
         *
         * 示例 2：
         * 输入：arr = [7,7,7,7,7,7]
         * 输出：1
         * 解释：我们只能选择集合 {7}，结果数组为空。
         *
         * 提示：
         * 1 <= arr.length <= 10^5
         * arr.length 为偶数
         * 1 <= arr[i] <= 10^5
         */

        public int MinSetSize(int[] arr)
        {
            /*
             * 按照数字在数组中的占有比例来判断
             * 如果某两个数字的出现次数 大于 一半的数组长度
             * 那么这两个数字的数组即为满足条件的答案
             * 当然，不一定是两个数字，只要总出现次数 大于 一半的数组长度即可
             */

            List<int> list = new List<int>(arr);
            HashSet<int> set = new HashSet<int>(arr);
            Dictionary<int, int> countDict = new Dictionary<int, int>();

            foreach (int num in set)
            {
                int index = list.IndexOf(num);

                if (index != -1)
                {
                    if (countDict.ContainsKey(num))
                    {
                        countDict[num] += 1;
                    }
                    else
                    {
                        countDict.Add(num, 1);
                    }
                }

                Console.WriteLine();
            }

            throw new NotImplementedException();
        }
    }

    [TestClass]
    public sealed class TestClass
    {
        private readonly Solution solution = new Solution();

        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = [3, 3, 3, 3, 5, 5, 5, 2, 2, 7];
            Assert.Equals(solution.MinSetSize(arr), 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] arr = [7, 7, 7, 7, 7, 7];
            Assert.Equals(solution.MinSetSize(arr), 1);
        }
    }
}