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
    public partial class Preview : Form
    {
        List<PictureBox> listaImagenes = new List<PictureBox>();

        public Preview(Dictionary<Asset, int> assetPreview)
        {
            


            InitializeComponent();
            var sortedDict = from entry in assetPreview orderby entry.Value ascending select entry;
            
            foreach (var item in sortedDict)
	        {
                Console.WriteLine(item.Key.path);
                addImage(item.Key);
                //pictureBox2.Image = Image.FromFile(item.Key.Path);
            }


            
            /*
            if (listaImagenes.Count > 2) {
                
                System.Windows.Forms.PictureBox lastImage;
                int i = 0;
                foreach (var imagen in listaImagenes)
                {
                    if (i > 1)
                    {
                        imagen.Parent = lastImage;

                    }
                    lastImage = imagen;
                    i++;

                }
                 
                
                int i = 1;
                while (i < listaImagenes.Count)
                {
                    listaImagenes[i].Parent = listaImagenes[i-1];
                    i++;
                }
                 
            }*/



        }

        private void addImage(Asset assetImage){

            System.Windows.Forms.PictureBox pictureBoxX;
            pictureBoxX = new System.Windows.Forms.PictureBox();
            pictureBoxX.BackColor = System.Drawing.Color.Transparent;
            pictureBoxX.Image = Image.FromFile(assetImage.path);
            pictureBoxX.Location = new System.Drawing.Point(assetImage.x, assetImage.y);
            pictureBoxX.Name = "pictureBox2";
            //pictureBoxX.Size = new System.Drawing.Size(521, 377);
            pictureBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;

            this.Controls.Add(pictureBoxX);
            listaImagenes.Add(pictureBoxX);
            //pictureBox2.Parent = pictureBox1;

        
        }

        private void Preview_Load(object sender, EventArgs e)
        {

            foreach (var imagen in listaImagenes)
            {
                imagen.Parent = pictureParent;

            }

            
        }  
    }
}
