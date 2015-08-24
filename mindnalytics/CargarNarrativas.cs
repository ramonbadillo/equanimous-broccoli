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
    public partial class CargarNarrativas : Form
    {


        CargarAssets assets;
        public List<Narrativa> listaNarrativas = new List<Narrativa>();
        Narrativa narr;

        public CargarNarrativas(CargarAssets assets)
        {
            this.assets = assets;
            InitializeComponent();
            openFileDialog1.Filter = "Sound Files (wav,ogg,m4a)|*.wav;*.ogg;*.m4a";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = true;
            
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

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count >= 1)
            {

                string name = "";
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    name = item.Text;


                    string[] row = new string[] { name.Split('\\').Last(), "", "", name };

                    tablaAssets.Rows.Add(row);
                }
            }
        }

        private void btnRmvAsset_Click(object sender, EventArgs e)
        {
            tablaAssets.Rows.RemoveAt(tablaAssets.SelectedRows[0].Index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.assets.Show();
        }

        string imagenPath;
        private void btnTimeLine_Click(object sender, EventArgs e)
        {
            listaNarrativas.Clear();
            if (tablaAssets.RowCount != 0)
            {
                foreach (DataGridViewRow item in tablaAssets.Rows)
                {
                    if(item.Cells["Imagen"].Value.ToString() != null){
                        imagenPath = item.Cells["Imagen"].Value.ToString();
                    }else
                        imagenPath = "";

                    narr = new Narrativa(
                                        item.Cells["Nombre"].Value.ToString(),
                                        imagenPath,
                                        item.Cells["Path"].Value.ToString()
                    );
                   
                   
                    listaNarrativas.Add(narr);

                }



                this.Hide();
                assets.tiempo.Show();
                assets.tiempo.refreshLists();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Seguro que quieres continuar sin cargar ninguna narrativa?", "Some Title", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {

                    //do something
                    this.Hide();
                    assets.tiempo.Show();
                    assets.tiempo.refreshLists();
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    return;
                    //do something else
                }
                
            }
            


        }

        private void tablaAssets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {

                openFileDialog2.Filter = "Image Files (jpg,jpeg,png)|*.jpg;*.jpeg;*.png";
                DialogResult result = openFileDialog2.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                {
                    string file = openFileDialog2.FileName;
                    tablaAssets.Rows[e.RowIndex].Cells[1].Value = file;
                    //txtNarrFinal.Text = file;
                }

                MessageBox.Show((e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
            }
        
        }


        

        
    }
}
