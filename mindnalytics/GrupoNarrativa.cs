using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindnalytics
{
    class GrupoNarrativa
    {

        private List<Narrativa> listaAssets;

        

        public GrupoNarrativa()
        {

        }

        public GrupoNarrativa(List<Narrativa> listaAssets)
        {
            this.listaAssets = listaAssets;
        }


        public List<Narrativa> ListaAssets
        {
            get { return listaAssets; }
            set { listaAssets = value; }
        }
    }
}
