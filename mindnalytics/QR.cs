using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindnalytics
{
    class QR
    {
        public int exitementScore(List<double> valores, int numSamples)
        {
            int exitementScore = 0;

            for (int i = 0; i + numSamples < valores.Count(); i += numSamples)
            {
                double[] muestra = valores.GetRange(i, numSamples).ToArray();
                double media = MathNet.Numerics.Statistics.ArrayStatistics.Mean(muestra);
                exitementScore += media > 0.6 ? 1 : media < 0.4 ? -1 : 0;
            }

            return exitementScore;
        }
    }
}
