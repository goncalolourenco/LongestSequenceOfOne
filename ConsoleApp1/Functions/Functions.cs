using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Functions
{
    public class Functions
    {
        public static int LongestSequenceOfOneV1(int[] seq)
        {
            var resIndex = -1;
            var leftBlock = 0;
            var resCount = 0;
            var currentIndex = -1;
            var currentCount = 0;

            //Empty case
            if (seq.Length == 0) return -1;

            for (var i = 0; i < seq.Length; i++)
            {
                //Found 1
                if (seq[i] == 1) leftBlock++;
                //Found 0
                else
                {
                    currentCount += leftBlock;
                    if (currentCount > resCount)
                    {
                        resIndex = currentIndex;
                        resCount = currentCount;
                    }

                    currentIndex = i;
                    currentCount = leftBlock;
                    leftBlock = 0;
                }

            }

            //Last 0 appearance
            if (currentCount + leftBlock > resCount) resIndex = currentIndex;

            return resIndex;
        }
    }
}
