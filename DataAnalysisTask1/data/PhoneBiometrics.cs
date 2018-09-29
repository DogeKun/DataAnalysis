using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisTask1.data
{
    class PhoneBiometrics
    {
        public int biometricsID = -1;
        public bool biometricsBool = false;

        public PhoneBiometrics(int biometricsID, bool biometricsBool)
        {
            this.biometricsID = biometricsID;
            this.biometricsBool = biometricsBool;
        }

    }
}
