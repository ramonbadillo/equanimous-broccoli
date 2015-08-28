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

        public List<Asset> listaAssets;

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
            this.listaAssets = grupo.listaAssets;
            this.estudioAbierto = estudioAbierto;
            this.sujetoPrueba = sujetoPrueba;
            this.IN= new ImagenNeutral(estudioAbierto.NeutralImage);
            setNeutral();
            startEstudio();
            Console.WriteLine("Inicia Una nueva clase-------------------------------" + listaAssets.Count);
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

        private void setNeutral()
        {
            if (listaAssets.Count > 0)
            {
                Console.WriteLine("Se llamo a neutral--------------");
                IN.Show();
                IOA.Hide();

            }
            else
            {
                IOA.Hide();
                IN.Hide();
                MyTimer.Stop();
                expe.getElementos();
            }
        }

        private void setIOA()
        {
            if (listaAssets.Count > 0)
            { 
            IOA.Show();
            IOA.setImage(listaAssets.First());
            IN.Hide();
            listaAssets.RemoveAt(0);
            }
            else
            {
                IOA.Hide();
                IN.Hide();
                MyTimer.Stop();
                expe.getElementos();
            }
        }

        private void callEmotiv(object sender, EventArgs e)
        {


            if (registro)
            {
                RegistroEmotiv();
            }

            else
            {
                CheckNeutral();
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
                setIOA();
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
                setNeutral();
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
