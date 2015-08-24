using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindnalytics
{
    static class QR
    {
        
        static Boolean emotionNeutral = false;
        static int countNeutral = 0;
        static Single neutralScore = 0;
        
        public static int exitementScore(List<double> valores, int numSamples)
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

        public static Boolean neutral(Single exitementScore) {
            neutralScore = exitementScore;
            if (neutralScore > 0.4 && neutralScore < 0.6)
                countNeutral++;
            else
                countNeutral = 0;

            
            emotionNeutral = countNeutral > 20 ? true : false;
            
            return emotionNeutral;
        }

        
    }
}
