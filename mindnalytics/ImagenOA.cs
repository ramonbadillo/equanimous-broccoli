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
    public partial class ImagenOA : Form
    {
        public Experimento expe;
        public ImagenOA(Experimento expe)
        {
            this.expe = expe;
            InitializeComponent();
        }


        public ImagenOA()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            expe.getElementos();
        }
    }
}
