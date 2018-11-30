using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisTask1
{
    class AssociationRule
    {
        public ItemSet X { get; set; }
        public ItemSet Y { get; set; }

        public double Support { get; set; }
        public double Confidence { get; set; }

        public AssociationRule()
        {
            this.X = new ItemSet();
            this.Y = new ItemSet();
            this.Support = 0.0;
            this.Confidence = 0.0;
        }

        public override string ToString()
        {
            return (X + "=>" + Y + " (support: " + Math.Round(Support, 2) + "%, confidence: " +
                    Math.Round(Confidence, 2) + "%)");
        }
    }
}
