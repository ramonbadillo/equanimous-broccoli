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
        List<PictureBox> listaGrupos = new List<PictureBox>();

        public Preview(Dictionary<Asset, int> assetPreview)
        {
            


            InitializeComponent();
            var sortedDict = from entry in assetPreview orderby entry.Value ascending select entry;
            
            foreach (var item in sortedDict)
	        {
                Console.WriteLine(item.Key.Path);
                addImage(item.Key);
                //pictureBox2.Image = Image.FromFile(item.Key.Path);
            }

        }

        private void addImage(Asset assetImage){

            System.Windows.Forms.PictureBox pictureBoxX;
            pictureBoxX = new System.Windows.Forms.PictureBox();
            pictureBoxX.BackColor = System.Drawing.Color.Transparent;
            pictureBoxX.Image = Image.FromFile(assetImage.Path);
            pictureBoxX.Location = new System.Drawing.Point(assetImage.X, assetImage.Y);
            pictureBoxX.Name = "pictureBox2";
            pictureBoxX.Size = new System.Drawing.Size(521, 377);
            pictureBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;

            this.Controls.Add(pictureBoxX);
            listaGrupos.Add(pictureBoxX);
            //pictureBox2.Parent = pictureBox1;

        
        }

        private void Preview_Load(object sender, EventArgs e)
        {

            

            
        }  
    }
}
