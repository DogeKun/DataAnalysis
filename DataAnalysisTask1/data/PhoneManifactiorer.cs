using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisTask1.data
{
    class PhoneManifactiorer
    {
        public int manifactiorerID = -1;
        public string manifactiorerName = "";

        public PhoneManifactiorer(int manifactiorerID, string manifactiorerName)
        {
            this.manifactiorerID = manifactiorerID;
            this.manifactiorerName = manifactiorerName;
        }
    }
}
