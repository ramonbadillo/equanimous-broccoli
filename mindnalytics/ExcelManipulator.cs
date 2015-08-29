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

        public static void createOAExcel(String FilePath, String FileName)
        {
            var csv = new StringBuilder();
            csv.Append("OA , Experiment , Grupo , Path , QRP, QRN , QRM " + Environment.NewLine);

            File.WriteAllText(FilePath+FileName+".csv", csv.ToString());

        }
        
        public static void saveOA(ObjetoAnalisis oa, String FilePath, String FileName)
        {
            var csv = new StringBuilder();
            csv.Append("" + oa.nombreOA + " , " + oa.nombreExperimento + " , " + oa.grupo + " , " + oa.path
                + " , " + oa.qrp + " , " + oa.qrn + " , " + oa.qrm + Environment.NewLine);

            File.AppendAllText(FilePath+FileName+".csv",csv.ToString());
                
        }

        public static void saverRawOA(ObjetoAnalisis oa, String FilePath, String FileName)
        {
            saveRaw(oa.nombreOA, oa.nombreExperimento, oa.scoreEngage, 
                FilePath+FileName+"raw_engagement.cvs");
            saveRaw(oa.nombreOA, oa.nombreExperimento, oa.scoreExcitement, 
                FilePath+FileName+"raw_excitement.cvs");
            saveRaw(oa.nombreOA, oa.nombreExperimento, oa.scoreMeditation,
               FilePath+FileName+"raw_meditation.cvs");
            
        }

        private static void saveRaw(String Name, String Experiment, List<double> list, String file) 
        {
            var csv = new StringBuilder();
            csv.Append("" + Name + " , " + Experiment + " , ");

            foreach (double raw in list)
            {
                csv.Append(raw.ToString() + " , ");
            }
            csv.Append(Environment.NewLine);

            File.AppendAllText(file, csv.ToString());
        

        public static List<ObjetoAnalisis> readOA(String FilePath, String FileName)
        {
            List<ObjetoAnalisis> listOA = new List<ObjetoAnalisis>();
            ObjetoAnalisis oa = new ObjetoAnalisis();
            var reader = new StreamReader(File.OpenRead(@""+FilePath+FileName+".csv"));
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

                    listOA.Add(oa);
                }
                i++;
            }
            
            return listOA;
        }

        public static void testExcel()
        {
            var csv = new StringBuilder();
            csv.Append("OA , Experiment , Grupo , Path , QRP, QRN , QRM , Raw Scores " + Environment.NewLine);

            File.WriteAllText("C:/Users/DrManchas/Documents/prueba.csv", csv.ToString());

        }
    }
}
