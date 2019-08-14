using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int find_it(int[] seq)
        {
            //dictionary solution
            #region
            var items = new Dictionary<int, int>();

            foreach (var number in seq)
            {
                if (items.ContainsKey(number))
                {
                    items[number]++;
                }
                else
                    items.Add(number, 1);
            }
            var intNumbers = items.Keys.ToArray();
            var intOccurances = items.Values.ToArray();

            for (int c = 0; c < intOccurances.Count(); c++)
            {
                if (intOccurances[c] % 2 != 0)
                {
                    return intNumbers[c];
                }
            }
            #endregion
            // LINQ solution
            #region

            //return  seq.First(x => seq.Count(s => s == x) % 2 == 1); // not my answer, taken from the website
            //var linqGroup = seq.GroupBy(i => i)
            //    .Select(grp => new
            //    {
            //        number = grp.Key,
            //        total = grp.Count()
            //    })
            //    .ToArray();

            //for (int i = 0; i < linqGroup.Length; i++)
            //{
            //    if (linqGroup[i].total % 2 != 0)
            //    {
            //        return linqGroup[i].number;
            //    }
            //}
            #endregion

            return 0;
        }

        public static List<int> RemoveSmallest(List<int> numbers)
        {
            int lowVal = 0;
            if (numbers.Count() > 0)
            {
                for (int i = 0; i < numbers.Count() - 1; i++)
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                        if (numbers[lowVal] > numbers[i])
                        {
                            lowVal = i;
                        }
                    }
                }
                numbers.RemoveAt(lowVal);
            }
            return numbers;
        }
    }
}
