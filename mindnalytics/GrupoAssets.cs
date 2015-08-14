using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mindnalytics
{
    public partial class GrupoAssets : UserControl
    {
        public CargarAssets cargar;
        public int nGrupo = 0;
        public GrupoAssets(CargarAssets cargar, int numero)
        {
            this.cargar = cargar;
            InitializeComponent();
            groupBox1.Text += numero;
            numZOrder.Value = numero;
            
        }



  

        private void btnNarr_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Sound Files (wav,ogg,m4a)|*.wav;*.ogg;*.m4a";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                txtNarr.Text = file;
            }
        }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {

            if (cargar.listView1.SelectedItems.Count >= 1)
            {

                string name = "";
                foreach (ListViewItem item in cargar.listView1.SelectedItems)
                {
                    name = item.Text;
                    

                    string[] row = new string[] { name.Split('\\').Last(), "0", "0", "1", name};

                    tablaAssets.Rows.Add(row);
                }
            }
        }


        private void btnRmvAsset_Click(object sender, EventArgs e)
        {

            tablaAssets.Rows.RemoveAt(tablaAssets.SelectedRows[0].Index);
            
            //tablaAssets.Rows.RemoveAt();
        }

        private void btnUpAsset_Click(object sender, EventArgs e)
        {
            if (tablaAssets.RowCount > 0)
            {
                if (tablaAssets.SelectedRows.Count > 0)
                {
                    int rowCount = tablaAssets.Rows.Count;
                    int index = tablaAssets.SelectedCells[0].OwningRow.Index;

                    if (index == 0)
                    {
                        return;
                    }
                    DataGridViewRowCollection rows = tablaAssets.Rows;

                    // remove the previous row and add it behind the selected row.
                    DataGridViewRow prevRow = rows[index - 1];
                    rows.Remove(prevRow);
                    prevRow.Frozen = false;
                    rows.Insert(index, prevRow);
                    tablaAssets.ClearSelection();
                    tablaAssets.Rows[index - 1].Selected = true;
                }
            }
        }

        private void btnDwnAsset_Click(object sender, EventArgs e)
        {
            if (tablaAssets.RowCount > 0)
            {
                if (tablaAssets.SelectedRows.Count > 0)
                {
                    int rowCount = tablaAssets.Rows.Count;
                    int index = tablaAssets.SelectedCells[0].OwningRow.Index;

                    if (index == (rowCount - 1)) // include the header row
                    {
                        return;
                    }
                    DataGridViewRowCollection rows = tablaAssets.Rows;

                    // remove the next row and add it in front of the selected row.
                    DataGridViewRow nextRow = rows[index + 1];
                    rows.Remove(nextRow);
                    nextRow.Frozen = false;
                    rows.Insert(index, nextRow);
                    tablaAssets.ClearSelection();
                    tablaAssets.Rows[index + 1].Selected = true;
                }
            }
        }


        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {

        }

        
    }
}
