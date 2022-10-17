using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

        public static int lonelyinteger(List<int> a)
        {
            a.Sort();

            for (int i = 1; i < a.Count -1; i++)
            {
                if (a[i] != a[i -1] && a[i] != a[i +1])
                {
                    return a[i];                    
                }
            }
            
            return a[a.Count - 1];
        }
    }
}