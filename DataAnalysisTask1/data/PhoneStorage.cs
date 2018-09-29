using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisTask1.data
{
    class PhoneStorage
    {
        public int storageID;
        public int storageCapacity;

        public PhoneStorage(int storageID, int storageCapacity)
        {
            this.storageID = storageID;
            this.storageCapacity = storageCapacity;
        }

        public override string ToString()
        {
            return storageCapacity.ToString();
        }
    }
}
