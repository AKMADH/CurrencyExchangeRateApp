using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRateApp
{
    class SortTheCurrency
    {
        public static int[] mergeSort(int[] lstCurrencies)
        {
            int[] left;
            int[] right;
            int[] result = new int[lstCurrencies.Length];
            
            if (lstCurrencies.Length <= 1)
                return lstCurrencies;
           
            int midPoint = lstCurrencies.Length / 2;
           
            left = new int[midPoint];

          
            if (lstCurrencies.Length % 2 == 0)
                right = new int[midPoint];
           
            else
                right = new int[midPoint + 1];
         
            for (int i = 0; i < midPoint; i++)
                left[i] = lstCurrencies[i];
          
            int x = 0;
            
            for (int i = midPoint; i < lstCurrencies.Length; i++)
            {
                right[x] = lstCurrencies[i];
                x++;
            }
    
            left = mergeSort(left);
        
            right = mergeSort(right);
        
            result = merge(left, right);
            return result;
        }

     //merge both the array value
        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;
           
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                  
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }

                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
               
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
             
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
    }
}
