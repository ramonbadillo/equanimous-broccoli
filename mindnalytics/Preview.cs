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
        System.Windows.Forms.PictureBox lastImage;
        Bitmap lastPicture;

        public Preview(Dictionary<Asset, int> assetPreview)
        {
            


            /*InitializeComponent();
            var sortedDict = from entry in assetPreview orderby entry.Value ascending select entry;
            
            foreach (var item in sortedDict)
	        {
                Console.WriteLine(item.Key.path);
                addImage(item.Key);
                //pictureBox2.Image = Image.FromFile(item.Key.Path);
            }
            */
            InitializeComponent();
            //this.TransparencyKey = Color.White;
            
            var sortedDict = from entry in assetPreview orderby entry.Value ascending select entry;
            
            /*ImageList myImages = new ImageList();
            foreach (var item in sortedDict)
            {
                var pngImage = new Bitmap(item.Key.path);
                myImages.Images.Add(pngImage);
            }

            myImages.TransparentColor = Color.White;
            */
            int i = 0;
            foreach (var item in sortedDict)
            {
                //Console.WriteLine(item.Key.path);
                //addImage(item.Key);
                //pictureBox2.Image = Image.FromFile(item.Key.Path);
                System.Windows.Forms.PictureBox pictureBoxX = new System.Windows.Forms.PictureBox();

                if (i > 0)
                {
                    pictureBoxX.Parent = lastImage;
                    pictureBoxX.BackgroundImage = lastPicture;
                } else 
                {
                    this.BackgroundImage = new Bitmap(item.Key.path);
                }

                //pictureBoxX.Image = Image.FromFile(item.Key.path);
                var pngImage = new Bitmap(item.Key.path);
                //pictureBoxX.Image = SetAlpha(pngImage, 255);
                //pngImage.MakeTransparent(Color.White);
                pictureBoxX.Image = pngImage;
                //pictureBoxX.BackColor = Color.Transparent;
                pictureBoxX.Location = new Point(item.Key.x, item.Key.y);
                pictureBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                

                pictureBoxX.Name = "pictureBox2";
                
                this.Controls.Add(pictureBoxX);
                listaImagenes.Add(pictureBoxX);

                lastPicture = pngImage;
                lastImage = pictureBoxX;
                i++;
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

        public Bitmap SetAlpha(Bitmap bmp, byte alpha)
        {
            if (bmp == null) throw new ArgumentNullException("bmp");

            var data = bmp.LockBits(
                new Rectangle(0, 0, bmp.Width, bmp.Height),
                System.Drawing.Imaging.ImageLockMode.ReadWrite,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            var line = data.Scan0;
            var eof = line + data.Height * data.Stride;
            while (line != eof)
            {
                var pixelAlpha = line + 3;
                var eol = pixelAlpha + data.Width * 4;
                while (pixelAlpha != eol)
                {
                    System.Runtime.InteropServices.Marshal.WriteByte(
                        pixelAlpha, alpha);
                    pixelAlpha += 4;
                }
                line += data.Stride;
            }
            bmp.UnlockBits(data);
            return bmp;
        }

    }
}
