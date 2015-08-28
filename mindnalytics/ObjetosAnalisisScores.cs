using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;
using System.Media;

namespace mindnalytics
{
    class ObjetosAnalisisScores
    {

        Estudio estudioAbierto;
        string sujetoPrueba;
        Experimento expe;
        Grupo grupo;

        ReaderEmotiv reader = new ReaderEmotiv();
        public List<Double> ListEngage = new List<Double>();
        public List<Double> ListExcitement = new List<Double>();
        public List<Double> ListMeditation = new List<Double>();

        bool registro = false;
        Timer MyTimer = new Timer();
        long durationOA = 20 * 1000;
        Stopwatch stopWatch = new Stopwatch();
        int numSamples = 5;
        ImagenOA IOA = new ImagenOA();
        ImagenNeutral IN;


        public ObjetosAnalisisScores(Estudio estudioAbierto, string sujetoPrueba,Experimento expe,Grupo grupo)
        {
            this.expe = expe;
            this.grupo = grupo;
            this.estudioAbierto = estudioAbierto;
            this.sujetoPrueba = sujetoPrueba;
            this.IN= new ImagenNeutral(estudioAbierto.NeutralImage);
            startEstudio();
        }


        public void startEstudio()
        {
            try
            {

                reader.emoConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }


            MyTimer.Interval = (250);
            MyTimer.Tick += new EventHandler(callEmotiv);
            MyTimer.Start();

        }


        private void callEmotiv(object sender, EventArgs e)
        {


            if (registro)
            {
                IOA.Show();
                IOA.SetImage();
                RegistroEmotiv();
                IN.Hide();


            }

            else
            {
                IN.Show();
                CheckNeutral();
                IOA.Hide();
            }


        }

        public void CheckNeutral()
        {

            if (QR.neutral(ReaderEmotiv.scoreExcitement))
            {
                registro = true;
                Console.WriteLine("Acabo el neutral");
                //poner la imagen siguiente
                stopWatch.Start();
            }

            Console.WriteLine("N: " + ReaderEmotiv.scoreExcitement);

        }

        //ObjetoAnalisis OAS;
        //string nombreGrupo = "NuevoGrupo";
        //string nombreOA = "nombredelOA";
        //string nombreExperimento = "NombreExperimento";

        public void RegistroEmotiv()
        {

            Console.WriteLine("S: " + stopWatch.ElapsedMilliseconds / 1000);
            if (stopWatch.ElapsedMilliseconds >= durationOA)
            {
                //set Imagen en Neutral

                stopWatch.Stop();
                //stopWatch.Restart();
                stopWatch.Reset();
                List<int[]> scores = QR.exitementScore(ListExcitement, numSamples);
                //int scoreQRT = QR.exitementScore(ListExcitement, numSamples);
                //Console.WriteLine("QRScore: "+scoreQRT);
                Console.WriteLine("Scores");
                Console.WriteLine(getScoresBonitos(scores));
                //scores.ForEach(i => Console.Write("{0},\t", i));
                /*
                OAS = new ObjetoAnalisis(
                    nombreGrupo, 
                    nombreOA,
                    scoreQRT,
                    nombreExperimento,
                    ListEngage,
                    ListExcitement,
                    ListMeditation
                );
                OAS.Save();
                 */
                QR.countNeutral = 0;
                registro = false;
                ClearLists();
            }



            ListEngage.Add(ReaderEmotiv.scoreEngage);
            ListExcitement.Add(ReaderEmotiv.scoreExcitement);
            ListMeditation.Add(ReaderEmotiv.scoreMedidation);

            //Console.WriteLine(ListEngage.Average());
            //ListEngage.ForEach(i => Console.Write("{0}\t", i));


        }


        private string getScoresBonitos(List<int[]> scores)
        {
            string valoresBonitos = "";
            int positivo = 0, neutral = 0, negativo = 0;

            foreach (int[] item in scores)
            {
                positivo += item[0];
                neutral += item[1];
                negativo += item[2];
            }
            valoresBonitos = "[" + positivo + "," + neutral + "," + negativo + "]";
            return valoresBonitos;
        }



        public void ClearLists()
        {
            ListEngage.Clear();
            ListExcitement.Clear();
            ListMeditation.Clear();

        }


    }
}
