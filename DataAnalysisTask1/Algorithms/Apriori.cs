using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnalysisTask1.data;

namespace DataAnalysisTask1
{
    class Apriori
    {
        public ItemSetCollection DoApriori(ItemSetCollection db, double supportThreshold)
        {
            ItemSet I = db.GetUniqueItems();
            ItemSetCollection L = new ItemSetCollection(); //resultant large itemset
            ItemSetCollection Li = new ItemSetCollection(); //large itemset in each iteration
            ItemSetCollection Ci = new ItemSetCollection(); //pruned itemset in each iteration

            //first iteration (1-item itemsets)
            foreach (string item in I)
            {
                Ci.Add(new ItemSet() { item });
            }

            //next iterations
            int k = 2;
            while (Ci.Count != 0)
            {
                //set Li from Ci (pruning)
                Li.Clear();
                foreach (ItemSet itemset in Ci)
                {
                    itemset.Support = db.FindSupport(itemset);
                    if (itemset.Support >= supportThreshold)
                    {
                        Li.Add(itemset);
                        L.Add(itemset);
                    }
                }

                //set Ci for next iteration (find supersets of Li)
                Ci.Clear();
                Ci.AddRange(Bit.FindSubsets(Li.GetUniqueItems(), k)); //get k-item subsets
                k += 1;
            }

            return (L);
        }

        public List<AssociationRule> Mine(ItemSetCollection db, ItemSetCollection L, double confidenceThreshold)
        {
            List<AssociationRule> allRules = new List<AssociationRule>();

            foreach (ItemSet itemset in L)
            {
                ItemSetCollection subsets = Bit.FindSubsets(itemset, 0); //get all subsets
                foreach (ItemSet subset in subsets)
                {
                    double confidence = (db.FindSupport(itemset) / db.FindSupport(subset)) * 100.0;
                    if (confidence >= confidenceThreshold)
                    {
                        AssociationRule rule = new AssociationRule();
                        rule.X.AddRange(subset);
                        rule.Y.AddRange(itemset.Remove(subset));
                        rule.Support = db.FindSupport(itemset);
                        rule.Confidence = confidence;
                        if (rule.X.Count > 0 && rule.Y.Count > 0)
                        {
                            allRules.Add(rule);
                        }
                    }
                }
            }

            return (allRules);
        }
    }
}
