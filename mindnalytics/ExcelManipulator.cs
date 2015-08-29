using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace mindnalytics
{
    class ExcelManipulator
    { 
        public static void saveOA(ObjetoAnalisis oa, String FilePath)
        {
            var csv = new StringBuilder();
            csv.Append("OA , Experiment , Grupo , Path , QRP, QRN , QRM , Raw Scores "+Environment.NewLine);
            csv.Append("" + oa.nombreOA + " , " + oa.nombreExperimento + " , " + oa.grupo + " , " + oa.path
                + " , " + oa.qrp + " , " + oa.qrn + " , " + oa.qrm + " , " + Environment.NewLine);

            File.AppendAllText(FilePath,csv.ToString());
                
        }

        public static ObjetoAnalisis readOA(String FilePath)
        {
            ObjetoAnalisis oa = new ObjetoAnalisis();
            var reader = new StreamReader(File.OpenRead(@""+FilePath+".csv"));
            int i = 1;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                if (i > 1) 
                {
                    oa.nombreOA = values[0];
                    oa.nombreExperimento = values[1];
                    oa.grupo = values[2];
                    oa.path = values[3];
                    oa.qrp = Int32.Parse(values[4]);
                    oa.qrn = Int32.Parse(values[5]);
                    oa.qrm = Int32.Parse(values[6]);
                    //oa.ScoreEngage = ScoreEngage;
                    //oa.ScoreExcitement = ScoreExcitement;
                    //oa.ScoreMeditation = ScoreMeditation;
                }
                i++;
            }
            
            return oa;
        }
    }
}
