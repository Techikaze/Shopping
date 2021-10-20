using System;
using System.Collections.Generic;
using System.Linq;

class Shopping
{
    public static void Main() { }

    public int getMin(List<int> prices)
    {
        int total = 0;
        int firstMax = 0;
        int secondMax = 0;

        bool keepSearching = prices.Count() > 0;

        while (keepSearching)
        {
            Console.WriteLine();
            Console.WriteLine("Iteration started:");

            firstMax = prices.Max();
            prices.Remove(firstMax);

            Console.WriteLine("First: " + firstMax);

            if (prices.Count() > 0)
            {
                secondMax = prices.Max();
                prices.Remove(secondMax);
                Console.WriteLine("Second: " + secondMax);
            }
            else
            {
                secondMax = 0;
            }


            if (prices.Count() > 0)
            {
                int min = firstMax;

                if (secondMax != 0)
                {
                    min = Math.Min(firstMax, secondMax);
                }

                int gaga = prices.Where(p => p < min).OrderByDescending(p => p).FirstOrDefault();

                if (gaga != 0)
                {
                    Console.WriteLine("Gaga " + gaga);
                    prices.Remove(gaga);
                }
            }

            total = total + firstMax + secondMax;
            Console.Write(total);

            keepSearching = prices.Count() > 0;
        }

        return total;
    }
}
