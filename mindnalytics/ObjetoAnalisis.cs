using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindnalytics
{
   

    class ObjetoAnalisis
    {
        private string NombreOA;            //Nombre del objeto
        private string NombreExperimento;   //Nombre del experimento 
        private string Grupo;               //Grupo de assets
        private string Path;                //Ruta del asset
        private int QRP;                    //Valores positivos de la prueba
        private int QRN;                    //Valores neutrales de la prueba
        private int QRM;                    //Valores negativos de la prueba
        
        //Valores en bruto de la prueba
        private List<Double> ScoreEngage ;
        private List<Double> ScoreExcitement;
        private List<Double> ScoreMeditation;

        public ObjetoAnalisis()
        {
            this.NombreOA = "";
            this.NombreExperimento = "";
            this.Grupo = "";
            this.Path = "";
            this.QRP = 0;
            this.QRN = 0;
            this.QRM = 0;
            this.ScoreEngage = new List<double>();
            this.ScoreExcitement = new List<double>();
            this.ScoreMeditation = new List<double>();
        }

        public ObjetoAnalisis(string NombreOA, string NombreExperimento, string Grupo, string Path, int QRP, int QRN, int QRM, List<Double> ScoreEngage, List<Double> ScoreExcitement, List<Double> ScoreMeditation)
        {
            this.NombreOA = NombreOA;
            this.NombreExperimento = NombreExperimento;
            this.Grupo = Grupo;
            this.Path = Path;
            this.QRP = QRP;
            this.QRN = QRN;
            this.QRM = QRM;
            this.ScoreEngage = ScoreEngage;
            this.ScoreExcitement = ScoreExcitement;
            this.ScoreMeditation = ScoreMeditation;
            
        }

        public void Save()
        {
            ExcelManipulator.saveOA(this, "Path");
        }


        public string grupo
        {
            get { return Grupo; }
            set { Grupo = value; }
        }

        public string nombreOA
        {
            get { return NombreOA; }
            set { NombreOA = value; }
        }

        public string path
        {
            get { return Path; }
            set { Path = value; }
        }

        public int qrp
        {
            get { return QRP; }
            set { QRP = value; }
        }

        public int qrn
        {
            get { return QRN; }
            set { QRN = value; }
        }

        public int qrm
        {
            get { return QRM; }
            set { QRM = value; }
        }

        public string nombreExperimento
        {
            get { return NombreExperimento; }
            set { NombreExperimento = value; }
        }

        public List<Double> scoreEngage
        {
            get { return ScoreEngage; }
            set { ScoreEngage = value; }
        }

        public List<Double> scoreExcitement
        {
            get { return ScoreExcitement; }
            set { ScoreExcitement = value; }
        }

        public List<Double> scoreMeditation
        {
            get { return ScoreMeditation; }
            set { ScoreMeditation = value; }
        }

    }
}
