using System;

namespace extensionForReversingNumber
{
    public static class ReverseNo
    {
        public static int Reverse(this int num)
        {
            int last_digit;
            int reverse=0;
            while(num!=0)
            {
                last_digit = num % 10;
                reverse = reverse * 10 + last_digit;
                num /= 10;
            }
            return reverse;
        }
    }

}