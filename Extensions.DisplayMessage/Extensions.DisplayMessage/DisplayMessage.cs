using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.DisplayMessage
{
    public static class DisplayMessage
    {
        public static string message(this String str1, String str2)
        {
            return $"{str1} and {str2} are bestfriends!!!";
        }
    }
}
