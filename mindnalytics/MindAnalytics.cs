using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mindnalytics
{
    public partial class MindAnalytics : Form
    {
        public MindAnalytics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoEstudio estudio = new NuevoEstudio();
            this.Hide();
            estudio.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ExcelManipulator.guardarObjeto();
            openFileDialog1.Filter = "XML Files (xml)|*.xml";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;

                StartEstudio estudio = new StartEstudio(file);
                estudio.Show();
                this.Hide();
            }
            
            
            
            /*
            ImagenNeutral neutral = new ImagenNeutral();
            this.Hide();
            neutral.Show();
             */
        }
    }
}
