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
            ImagenNeutral neutral = new ImagenNeutral();
            this.Hide();
            neutral.Show();
        }
    }
}
