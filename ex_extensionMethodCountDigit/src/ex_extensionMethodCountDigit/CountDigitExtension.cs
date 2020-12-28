using System;

namespace ex_extensionMethodCountDigit
{
    static class CountDigitExtension
    {
        public static int getDigit(this int num)
        {
            int count = 0;
            while(num!=0)
            {
                count+=1;
                num = num/10;
            }
            return count;
        }
    }
}