using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisTask1.data
{
    class PhoneBattery
    {
        public int batteryID = -1;
        public int batteryCapacity = -1;

        public PhoneBattery(int batteryID, int batteryCapacity)
        {
            this.batteryID = batteryID;
            this.batteryCapacity = batteryCapacity;
        }

        public override string ToString()
        {
            return batteryCapacity.ToString();
        }
    }
}
