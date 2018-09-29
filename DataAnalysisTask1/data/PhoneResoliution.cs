using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisTask1.data
{
    class PhoneResoliution
    {
        public int resoliutionID = -1;
        public int resoliutionXaxis = -1;
        public int resoliutionYaxis = -1;

        public PhoneResoliution(int resoliutinID, int resoliutionXaxis, int resoliutionYaxis)
        {
            this.resoliutionID = resoliutinID;
            this.resoliutionXaxis = resoliutionXaxis;
            this.resoliutionYaxis = resoliutionYaxis;
        }

        public string ResoliutionToString()
        {
            return resoliutionXaxis.ToString() + "x" + resoliutionYaxis.ToString();
        }
    }
}
