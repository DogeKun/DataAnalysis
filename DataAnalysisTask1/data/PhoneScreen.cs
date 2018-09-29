using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisTask1.data
{
    class PhoneScreen
    {
        public int screenID = -1;
        public string screenName = "";
        public int screenLength = -1;
        public int screenWidth = -1;
        public bool screenNotch = false;

        public PhoneScreen(int screenID, string screenName, int screenLength, int screenWidth, bool screenNotch)
        {
            this.screenID = screenID;
            this.screenName = screenName;
            this.screenLength = screenLength;
            this.screenWidth = screenWidth;
            this.screenNotch = screenNotch;
        }

        public float Istrizaine()
        {
            float z = (float)Math.Sqrt(Math.Pow(screenLength, 2) + Math.Pow(screenWidth, 2));
            return z;
        }
        public override string ToString()
        {
            return Math.Round(Istrizaine(), 2).ToString() + " inch";
        }
    }
}
