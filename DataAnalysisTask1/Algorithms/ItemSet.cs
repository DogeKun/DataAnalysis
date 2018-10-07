using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisTask1
{
    class ItemSet : List<string>
    {
        public double Support { get; set; }

        public ItemSet()
        {
            Support = 0.0f;
        }

        public bool Contains(ItemSet itemset)
        {
            return (this.Intersect(itemset).Count() == itemset.Count());
        }

        public ItemSet Remove(ItemSet itemset)
        {
            ItemSet removed = new ItemSet();
            removed.AddRange(from item in this
                             where !itemset.Contains(item)
                             select item);
            return (removed);
        }

        public string Test()
        {
            return ("(" + string.Join(",", this.ToArray()) + "}");
        }

        public override string ToString()
        {
            return ("(" + string.Join(",", this.ToArray()) + "}" +
                    (this.Support > 0 ? " (support: " + Math.Round(this.Support, 2) + "%)" : string.Empty));
        }
    }
}
