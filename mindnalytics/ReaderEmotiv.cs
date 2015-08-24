using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emotiv;
using System.Timers;

namespace mindnalytics
{
    public class ReaderEmotiv
    {
        public static EmoEngine engine = EmoEngine.Instance;
        //static EmoState es;
        public static Single scoreMedidation, scoreExcitement, scoreEngage;   //Scores despues de la correcion algoritmica de emotiv
        public static System.Timers.Timer aTimer = new System.Timers.Timer();



        public ReaderEmotiv()
        {


        }




        public void emoConnection()
        {
            
            engine.EmoEngineConnected += new EmoEngine.EmoEngineConnectedEventHandler(engine_EmoEngineConnected);  //Eventos de conexion de usuario
            engine.EmoEngineDisconnected += new EmoEngine.EmoEngineDisconnectedEventHandler(engine_EmoEngineDisconnected); //Eventos de Desconexión de usuario
            engine.EmoStateUpdated += new EmoEngine.EmoStateUpdatedEventHandler(engine_EmoStateUpdated);               //Eventos de actualizacion en deteccion de emociones

            /*
             * Conexiones. Adaptar segun sea el caso.
             */
            //engine.Connect();
            engine.RemoteConnect("127.0.0.1", 1726);

            aTimer.Elapsed += new System.Timers.ElapsedEventHandler(onTimedEvent);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;

        }

        public void engine_EmoStateUpdated(object sender, EmoStateUpdatedEventArgs e)
        {
            EmoState es = e.emoState;
            scoreMedidation = es.AffectivGetMeditationScore();
            //Console.WriteLine(scoreMedidation);
            scoreExcitement = es.AffectivGetExcitementShortTermScore();
            //Console.WriteLine(scoreExcitement);
            scoreEngage = es.AffectivGetEngagementBoredomScore();
            //Console.WriteLine("meditation: " + es.AffectivGetMeditationScore());
            //Console.WriteLine("Excitement: " + es.AffectivGetExcitementShortTermScore());
            //Console.WriteLine("Frustration: " + es.AffectivGetFrustrationScore());

        }

        public void engine_EmoEngineDisconnected(object sender, EmoEngineEventArgs e)
        {
            Console.WriteLine("Disconnected");
        }

        public void engine_EmoEngineConnected(object sender, EmoEngineEventArgs e)
        {
            Console.WriteLine("Connected");
        }

        public void onTimedEvent(object source, ElapsedEventArgs e)
        {
            engine.ProcessEvents();
            engine.EmoStateUpdated += new EmoEngine.EmoStateUpdatedEventHandler(engine_EmoStateUpdated);
            //Console.WriteLine("meditation: " + scoreMedidation);
            //Console.WriteLine("Excitement: " + scoreExcitement);
            //Console.WriteLine("Engagement: " + scoreEngage);

        }

    }
}
