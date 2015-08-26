using Polenter.Serialization;
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
    public partial class StartEstudio : Form
    {
        public string Path;
        public StartEstudio(string Path)
        {
            this.Path = Path;
            InitializeComponent();

        }

        
        public Estudio estudioAbierto;
        public List<ItemsEstudio> listaItemsEstudio;
        private void StartEstudio_Load(object sender, EventArgs e)
        {
            try
            {
                var serializer = new SharpSerializer();
                Console.WriteLine(Path);
                estudioAbierto = (Estudio)serializer.Deserialize(Path);
                Console.WriteLine(estudioAbierto.ProjectName);
                lblProjectName.Text = estudioAbierto.ProjectName;
                listaItemsEstudio = estudioAbierto.ListaItemsEstudio;
                foreach (ItemsEstudio item in listaItemsEstudio)
                {
                    string[] row = new string[] {""+ item.Numero,item.Nombre,item.Tipo };

                    tablaTimeline.Rows.Add(row);
                }



            }
            catch (Exception es)
            {
                Console.WriteLine("No Jala");
                Console.WriteLine(es);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtNombreEstudio.Text != "" )
            {
                ImagenNeutral neutral = new ImagenNeutral(estudioAbierto,txtNombreEstudio.Text);
                this.Hide();
                neutral.Show();
            }
        }
    }
}
