using System;

namespace extensionForString
{
    public static class ProperCaseString
    {
       
    
       public static string ToProperCase(this String str)
        {
            if(str.Trim().Length == 0)
            {
                return str;
            }
            String concat = "";
            string st = str.ToLower();

            String[] _Split = st.Split(' ');
            for(int i = 0; i < _Split.Length; i++)
            {
                char[] arr = _Split[i].ToCharArray();
               
                for(int j=0;j<arr.Length;j++)
                {
                    if(j==0)
                    {
                          String getAsString = arr[0].ToString();
                          getAsString = getAsString.ToUpper();
                          concat += getAsString;
                    }
                    else
                     {      String getAsString1 = arr[j].ToString();
                            concat += getAsString1;
                     }
                }
                concat+=" ";
            }
            return concat;
        }
    }
}
