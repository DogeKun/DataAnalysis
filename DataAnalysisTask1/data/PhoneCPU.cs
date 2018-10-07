using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisTask1.data
{
    class PhoneCPU
    {
        public int cpuID =-1;
        public string cpuName = "";
        public int cpuCore = -1;
        public float cpuFrequency = -1;
        public string gpuName = "";


        public PhoneCPU(int cpuID, string cpuName, int cpuCore, float cpuFrequency, string gpuName)
        {
            this.cpuID = cpuID;
            this.cpuName = cpuName;
            this.cpuCore = cpuCore;
            this.cpuFrequency = cpuFrequency;
            this.gpuName = gpuName;
        }
        public PhoneCPU(int cpuID, string cpuName)
        {
            this.cpuID = cpuID;
            this.cpuName = cpuName;
        }
        public override string ToString()
        {
            return cpuCore.ToString() + " cores";
        }
    }
}
