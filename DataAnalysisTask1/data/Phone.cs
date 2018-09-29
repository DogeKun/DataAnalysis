using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisTask1.data
{
    /// <Summary>
    /// This class works best if you read prerequisite data first
    /// </Summary>
    class Phone
    {
        public int phoneID;
        public string phoneName;
        public float phonePrice;
        public PhoneCPU cpu;
        public PhoneBattery battery;
        public PhoneBiometrics biometric;
        public PhoneCamera camera;
        public PhoneManifactiorer gamintojas;
        public PhoneMemory memory;
        public int osID;
        public int portsID; // To be the most correct version this hould be an array
        public PhoneScreen screen;
        public PhoneResoliution resoliution;
        public PhoneStorage storage;
        public float AnalysisLength = 0;

        public Phone(int phoneID, string phoneName, float phonePrice, PhoneCPU cpu,
            PhoneBattery battery, PhoneBiometrics biometric, PhoneCamera camera, PhoneManifactiorer gamintojas,
            PhoneMemory memory, int osID, int portsID, PhoneScreen screen, PhoneResoliution resoliution, PhoneStorage storage)
        {
            this.phoneID = phoneID;
            this.phoneName = phoneName;
            this.phonePrice = phonePrice;
            this.cpu = cpu;
            this.battery = battery;
            this.biometric = biometric;
            this.camera = camera;
            this.gamintojas = gamintojas;
            this.memory = memory;
            this.osID = osID;
            this.portsID = portsID;
            this.screen = screen;
            this.resoliution = resoliution;
            this.storage = storage;
        }
    }
}
