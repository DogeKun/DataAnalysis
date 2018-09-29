using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisTask1.data
{
    class PhoneMemory
    {
        public int memoryID = -1;
        public int memoryAmount = -1;

        public PhoneMemory(int memoryID, int memoryAmount)
        {
            this.memoryID = memoryID;
            this.memoryAmount = memoryAmount;
        }

        public override string ToString()
        {
            return memoryAmount.ToString();
        }
    }
}
