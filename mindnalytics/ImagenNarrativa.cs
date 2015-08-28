using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mindnalytics
{
    public partial class ImagenNarrativa : Form
    {
        public Experimento expe;
        Narrativa narr;
        public ImagenNarrativa(Experimento expe,Narrativa narr)
        {
            this.expe = expe;
            this.narr = narr;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            expe.getElementos();
            this.Dispose();
        }

        private void ImagenNarrativa_Load(object sender, EventArgs e)
        {
            PreviewSound(narr.path);
            
        }


        SoundPlayer player;
        private void PreviewSound(String path)
        {
            this.player = new System.Media.SoundPlayer(@"" + path);
            this.player.Play();
            
        }
    }
}
