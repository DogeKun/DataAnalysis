using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisTask1.data
{
    class PhoneCamera
    {
        public int cameraID = -1;
        public string cameraOptics = "";
        public int cameraMPX = -1;
        public int cameraRecordQuality = -1;

        public PhoneCamera(int cameraID, string cameraOptics, int cameraMPX, int cameraRecordQuality)
        {
            this.cameraID = cameraID;
            this.cameraOptics = cameraOptics;
            this.cameraMPX = cameraMPX;
            this.cameraRecordQuality = cameraRecordQuality;
        }

        public override string ToString()
        {
            return cameraMPX.ToString() + "MPx";
        }
    }
}
