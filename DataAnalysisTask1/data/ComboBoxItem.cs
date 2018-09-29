using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisTask1.data
{
    class ComboBoxItem
    {
        public int ItemID;
        public string ItemValue;

        public ComboBoxItem(int ItemID, string ItemValue)
        {
            this.ItemID = ItemID;
            this.ItemValue = ItemValue;
        }

        public override string ToString()
        {
            return ItemValue.ToString();
        }
    }
}
