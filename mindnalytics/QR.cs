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
        static public int countNeutral = 0;
        static Single neutralScore = 0;
        
        public static List<int[]> exitementScore(List<double> valores, int numSamples)
        {
            int[] exitementScore = new int[3];
            List<int[]> scores = new List<int[]>(); 
            valores.ForEach(i => Console.Write("{0},\t", i));
            for (int i = 0; (i + numSamples) <= valores.Count; i += numSamples/2)
            {
                double[] muestra = valores.GetRange(i, numSamples).ToArray();
                double media = MathNet.Numerics.Statistics.ArrayStatistics.MedianInplace(muestra);
                if (media > 0.6){
                    exitementScore = new int[] { 1,0,0 };
                }
                    
                else if(media < 0.4){
                    exitementScore = new int[] { 0,0,1 };

                }else{
                    exitementScore = new int[] { 0,1,0 };
                }
                scores.Add(exitementScore);
                //exitementScore += media > 0.6 ? 1 : media < 0.4 ? -1 : 0;
                
            }

            return scores;
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
