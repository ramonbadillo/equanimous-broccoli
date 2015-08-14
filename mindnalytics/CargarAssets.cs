using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mindnalytics
{
    public partial class CargarAssets : Form
    {

        int yGrupo = 13;
        int nGrupo = 1;
        List<GrupoAssets> listaGrupos = new List<GrupoAssets>();

        public CargarAssets()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Image Files (jpg,jpeg,png)|*.jpg;*.jpeg;*.png|Sound Files (wav,ogg,m4a)|*.wav;*.ogg;*.m4a";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = true;

            createNewGroup(nGrupo);

            
        }


        private void createNewGroup(int numero) {

            nGrupo += 1;
            this.userControl11 = new mindnalytics.GrupoAssets(this, numero);
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl11.Location = new System.Drawing.Point(13,yGrupo);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(845, 501);
            this.userControl11.TabIndex = 14;
            this.splitContainer2.Panel2.Controls.Add(this.userControl11);
            //this.Controls.Add(this.userControl11);
            listaGrupos.Add(userControl11);
            yGrupo += 510;

        
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string sFileName = openFileDialog1.FileName;
                string[] arrAllFiles = openFileDialog1.FileNames; //used when Multiselect = true  
                
                    foreach (string file in arrAllFiles)
                    {
                        ListViewItem itm = new ListViewItem(file);
                        listView1.Items.Add(itm);

                    }
                    
                    
               
            }
            

        }



        private void btnNarrInicial_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Sound Files (wav,ogg,m4a)|*.wav;*.ogg;*.m4a";
            DialogResult result = openFileDialog2.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog2.FileName;
                txtNarrInicial.Text = file;
            }
        }

        private void btnNarrFinal_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Sound Files (wav,ogg,m4a)|*.wav;*.ogg;*.m4a";
            DialogResult result = openFileDialog2.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog2.FileName;
                txtNarrFinal.Text = file;
            }
        }

        private void btnNeutral_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Image Files (jpg,jpeg,png)|*.jpg;*.jpeg;*.png";
            DialogResult result = openFileDialog2.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog2.FileName;
                txtNarrFinal.Text = file;
            }
        }
        
        private void btnPreview_Click(object sender, EventArgs e)
        {
            
            

            Dictionary<Asset, int> assetPreview = new Dictionary<Asset, int>();
            


            
            Asset assetAt;
            foreach (GrupoAssets grupo in listaGrupos)
            {
                //Console.WriteLine(
                assetAt = new Asset(grupo.tablaAssets.SelectedRows[0].Cells["Nombre"].Value.ToString(),
                    int.Parse(grupo.tablaAssets.SelectedRows[0].Cells["X"].Value.ToString()),
                    int.Parse(grupo.tablaAssets.SelectedRows[0].Cells["Y"].Value.ToString()),
                    grupo.tablaAssets.SelectedRows[0].Cells["Path"].Value.ToString());
                
                assetPreview.Add(assetAt, int.Parse(grupo.numZOrder.Value.ToString()));
                
                //);
                

            }
            Preview preview = new Preview(assetPreview);
            preview.Show();
            
        }

        private void btnAddNewGroup_Click(object sender, EventArgs e)
        {
            createNewGroup(nGrupo);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (listView1.SelectedItems.Count >= 1)
       
            {
            imagen.Image = Image.FromFile(listView1.SelectedItems[0].Text);
            }

        }
    }
}
