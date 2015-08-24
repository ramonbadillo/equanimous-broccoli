using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;


namespace mindnalytics
{
    public partial class ImagenNeutral : Form
    {
        ReaderEmotiv reader = new ReaderEmotiv();
        public List<Double> ListEngage = new List<Double>();
        public List<Double> ListExcitement = new List<Double>();
        public List<Double> ListMeditation = new List<Double>();
        bool neutralidad = false;
        Timer MyTimer = new Timer();

        public ImagenNeutral()
        {
            InitializeComponent();
        }

        private void ImagenNeutral_Load(object sender, EventArgs e)
        {
            try
            {
                
                reader.emoConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                
            }
            
            
            
            MyTimer.Interval = (500); 
            MyTimer.Tick += new EventHandler(callEmotiv);
            MyTimer.Start();
            
        }

        private void callEmotiv(object sender, EventArgs e)
        {

            if (neutralidad)
            {
                MyTimer.Stop();

                //Mandar llamar a  la funcion de hanamishi

                ClearLists();
            }

            ListEngage.Add(ReaderEmotiv.scoreEngage);
            ListExcitement.Add(ReaderEmotiv.scoreExcitement);
            ListMeditation.Add(ReaderEmotiv.scoreMedidation);

            Console.WriteLine(ListEngage.Average());
            ListEngage.ForEach(i => Console.Write("{0}\t", i));
            //MessageBox.Show("The form will now be closed.", "Time Elapsed");
            
            
            
        }


        public void CheckNeutral()
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            neutralidad = true;
            CreateExcel();
        }


        public void ClearLists()
        {
            ListEngage.Clear();
            ListExcitement.Clear();
            ListMeditation.Clear();

        }



        public void CreateExcel()
        {
            /*
            try
            {
                Application app = new Application();
                string execPath =
                  Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

                Workbook book = app.Workbooks.Open(@"c:\test.xls");
                Worksheet sheet = (Worksheet)book.Worksheets[1];

                Range range = sheet.get_Range("A1");
                range.Columns.ColumnWidth = 22.34;
                range = sheet.get_Range("B1");
                range.Columns.ColumnWidth = 22.34;

                sheet.get_Range("A1", "B1").Font.Bold = true;

                book.SaveAs(@"c:\test2.xls");  // or book.Save();
                book.Close();
            }
            catch (Exception ex)
            {
            }
            */

        }
    }
}
