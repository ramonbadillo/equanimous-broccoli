using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindnalytics
{
   

    class ObjetoAnalisis
    {
        private string Grupo;
        private string NombreOA;
        private int ExitementQR;
        private string NombreExperimento;
        private List<Double> ScoreEngage ;
        private List<Double> ScoreExcitement;
        private List<Double> ScoreMeditation;


        public ObjetoAnalisis(string Grupo, string NombreOA, int exitementQR, string NombreExperimento, List<Double> ScoreEngage, List<Double> ScoreExcitement, List<Double> ScoreMeditation)
        {
            this.Grupo = Grupo;
            this.NombreOA = NombreOA;
            this.ExitementQR = exitementQR;
            this.NombreExperimento = NombreExperimento;
            this.ScoreEngage = ScoreEngage;
            this.ScoreExcitement = ScoreExcitement;
            this.ScoreMeditation = ScoreMeditation;
            
        }

        public void Save()
        {
            //Guardar en excel
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


        public int exitementQR
        {
        get { return ExitementQR; }
        set { ExitementQR = value; }
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
