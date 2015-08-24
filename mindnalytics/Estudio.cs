using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindnalytics
{
    class Estudio
    {

        private string projectName;

        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }
        private string folderName;

        public string FolderName
        {
            get { return folderName; }
            set { folderName = value; }
        }
        private List<ItemsEstudio> listaItemsEstudio;

        public List<ItemsEstudio> ListaItemsEstudio
        {
            get { return listaItemsEstudio; }
            set { listaItemsEstudio = value; }
        }

        public Estudio(string projectName, string folderName, List<ItemsEstudio> listaItemsEstudio)
        {
            this.projectName = projectName;
            this.folderName = folderName;
            this.listaItemsEstudio = listaItemsEstudio;
        }

        public Estudio()
        {

        }
    }
}
