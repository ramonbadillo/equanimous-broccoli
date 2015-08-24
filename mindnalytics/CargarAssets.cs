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

using Polenter.Serialization;

namespace mindnalytics
{
    public partial class CargarAssets : Form
    {

        int yGrupo = 13;
        int nGrupo = 1;
        List<GrupoAssets> listaGrupos = new List<GrupoAssets>();

        public TimeLine tiempo;
        public CargarNarrativas narrativas;

        Grupo grupoForList;
        public List<Grupo> grupoToSave = new List<Grupo>();


        public CargarAssets()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Image Files (jpg,jpeg,png)|*.jpg;*.jpeg;*.png|Sound Files (wav,ogg,m4a)|*.wav;*.ogg;*.m4a";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = true;

            createNewGroup(nGrupo);

            narrativas = new CargarNarrativas(this);
            tiempo = new TimeLine(this);
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
            yGrupo += 500;
            Console.WriteLine(""+yGrupo);

        
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



       
        private void btnNeutral_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Image Files (jpg,jpeg,png)|*.jpg;*.jpeg;*.png";
            DialogResult result = openFileDialog2.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog2.FileName;
                txtNeutral.Text = file;
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

        

        private void btnNeutral_Click_1(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Image Files (jpg,jpeg,png)|*.jpg;*.jpeg;*.png";
            DialogResult result = openFileDialog2.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog2.FileName;
                txtNeutral.Text = file;
            }
        }


        public string folderName = "";

        private void btnTimeLine_Click(object sender, EventArgs e)
        {
            grupoToSave.Clear();
            if (folderName == "")
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                    folderName = folderBrowserDialog1.SelectedPath;
                else
                    return;
                //Console.WriteLine(folderName);
            }

            foreach (GrupoAssets grupo in listaGrupos)
            {
                if (grupo.txtName.Text != "" && grupo.tablaAssets.RowCount != 0)
                {

                    List<Asset> listaAssets = new List<Asset>();
                    Asset assetAt;

                    //Console.WriteLine(grupo.txtName.Text);
                    //Console.WriteLine(grupo.numZOrder.Value);
                    foreach (DataGridViewRow item in grupo.tablaAssets.Rows)
                    {
                        assetAt = new Asset(
                                            item.Cells["Nombre"].Value.ToString(),
                                            int.Parse(item.Cells["X"].Value.ToString()),
                                            int.Parse(item.Cells["Y"].Value.ToString()),
                                            item.Cells["Path"].Value.ToString());
                        Console.WriteLine(item.Cells["Nombre"].Value.ToString()
                        );
                        listaAssets.Add(assetAt);

                    }
                    //Console.WriteLine(grupo.numZOrder.Value.ToString());
                    

                    grupoForList = new Grupo(grupo.txtName.Text, int.Parse(grupo.numZOrder.Value.ToString()), listaAssets);
                    SharpSerializer mySerializer = new SharpSerializer();
                    
                    mySerializer.Serialize(grupoForList, folderName + "\\" + grupo.txtName.Text+ ".xml");
                    grupoToSave.Add(grupoForList);

                }
                else
                {
                    MessageBox.Show("Informacion faltante en el Grupo: " + grupo.nGrupo+1);
                    return;
                }
            }

            this.Hide();
            
            narrativas.Show();
            //tiempo = new TimeLine(grupoToSave);
            //tiempo.Show();
            
        }

        private void CargarAssets_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarAssets_Click(object sender, EventArgs e)
        {
            openFileDialog3.Filter = "XML Files (xml)|*.xml";
            DialogResult result = openFileDialog3.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog3.FileName;
                
                // deserialize
                try
                {
                    var serializer = new SharpSerializer();
                    Console.WriteLine(file);
                    Grupo grupoGuardado = (Grupo)serializer.Deserialize(file);
                    Console.WriteLine(grupoGuardado.nombre);

                    
                }
                catch (Exception es)
                {
                    Console.WriteLine("No Jala");
                    Console.WriteLine(es);
                }
                
            }
        }
        //
        //registrarlo como aviso comercial
    }
}
