using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.MeanMedianMode
{
    public static class MeanMedian
    {
        public static Double Median(this int[] arr)
        {
            var temp = 0 ;
            for(int i =0; i < arr.Count(); i++)
            {
                for(int j=0;j<arr.Count() ;j++)
                {
                    if(arr[i]<arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            var length = arr.Count() / 2;
            if(arr.Count() % 2 == 0 )
            {
                var mean = (arr[length] + arr[length - 1]) / 2;
                return mean;
            }
            else
            {
                var mean = arr[length];
                return mean;
            }

            
        }
        public static Double Mean(this int[] arr)
        {
            var sum = 0.0;
            for(int i=0;i<arr.Count();i++)
            {
                sum += arr[i];
            }
            return sum / arr.Count();

        }

    }
}
