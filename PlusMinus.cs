using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Algorithms
{
    public class PlusMinus
    {
        public void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Algorithms.PlusMinus.plusMinus(arr);
        }
        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            int positives = 0, negatives = 0, zeros = 0;            

            foreach (var item in arr)
            {
                _ = item == 0 
                    ? zeros++ 
                    : item > 0 
                        ? positives++ 
                        : negatives++;           
            }

            NumberFormatInfo setPrecision = new NumberFormatInfo();
            setPrecision.NumberDecimalDigits = 6;

            int count = arr.Count();
            
            Console.WriteLine($"{((decimal)positives/(decimal)count).ToString("N", setPrecision)}");
            Console.WriteLine($"{((decimal)negatives/(decimal)count).ToString("N", setPrecision)}");
            Console.WriteLine($"{((decimal)zeros/(decimal)count).ToString("N", setPrecision)}");            
        }
    }
}
