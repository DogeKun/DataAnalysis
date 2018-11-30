using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisTask1
{
    class Subsets
    {
        public List<List<string>> FindAllSubsets(List<string> ItemSets)
        {
            List<List<string>> allSubsets = new List<List<string>>();
            int subsetCount = (int) Math.Pow(2, ItemSets.Count);

            for (int i = 0; i < subsetCount; i++)
            {
                List<string> subset = new List<string>();
                for (int bitIndex = 0; bitIndex < ItemSets.Count; bitIndex++)
                {
                    if (GetBit(i, bitIndex) == 1)
                    {
                        subset.Add(ItemSets[bitIndex]);
                    }
                }
                allSubsets.Add(subset);
            }
            return allSubsets;
        }

        public static int GetBit(int value, int position)
        {
            int bit = value & (int) Math.Pow(2, position);
            return (bit > 0 ? 1 : 0);
        }
    }
}
