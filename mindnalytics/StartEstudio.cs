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
        public string iNeutral;
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
                iNeutral = estudioAbierto.NeutralImage;
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
            startEx();
        }

        private void txtNombreEstudio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                startEx();
            }
        }


        public void startEx()
        {

            if (txtNombreEstudio.Text != "")
            {
                //ObjetosAnalisisScores experimento1 = new ObjetosAnalisisScores(estudioAbierto, txtNombreEstudio.Text);
                Experimento experimentoBueno = new Experimento(estudioAbierto, txtNombreEstudio.Text);
                //ImagenNeutral neutral = new ImagenNeutral();
                this.Hide();
                //neutral.Show();
            }

        }
    }
}
